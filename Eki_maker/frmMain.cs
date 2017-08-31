using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxEXPJPCTLLib;
using EXPDCTRL2Lib;
using EXPDENGNLib;
using AxEXPDCTRL2Lib;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO.Compression;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Eki_maker
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// jsonファイルを読込
        ///jsonファイル内に記載されている値をcoursedateに入れる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Read_Json(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "新しいファイル.json";
            ofd.InitialDirectory = @"C:\Users\kentaro\デスクトップ";
            ofd.Filter = "JSONファイル(*.json)|*.json";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            CourseDate coursedate = new CourseDate();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.GetEncoding("shift_jis"));
                //Jsonファイルに適した中身でない場合に例外処理が発生する。
                try
                {
                    coursedate = JsonConvert.DeserializeObject<CourseDate>(sr.ReadToEnd());
                }
                catch (Newtonsoft.Json.JsonReaderException ex)
                {
                    MessageBox.Show("jsonの形式が正しくありません。\n jsonの中身を確認してください。" + ex.Message);
                }
                finally
                {
                    sr.Close();
                    sr.Dispose();
                }

                //JSONファイルの中身が無記入の場合に処理（try_catchではじけなったときの処理）
                if (coursedate == null)
                {
                    MessageBox.Show(ofd.FileName+"の中身が無記入となっています。\n 別のファイルを用意してください。");
                }
                else
                {   
                    //JSONファイルに経路情報等の値が入っていない場合に処理
                    if (coursedate.Route == null)
                    {
                        MessageBox.Show("探索結果の経路情報が空となっています。\n" + ofd.FileName + "の中身に経路情報が存在するか確認してください。");
                    }
                    else
                    {
                        Route_Display.Text = $"経路名（路線名）: {coursedate.Route}";
                        Route＿Display.Text = $"合計時間: {coursedate.TotalTime}";
                    }
                }
            }
        }

        /// <summary>
        /// ファイル読み込みを行う。
        /// jsonファイルではない、cousedata内の値が空だった場合に例外処理が発生する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Route(object sender, EventArgs e)
        {
            //ExpDiaStationNameEdit21の入力状態の値をもとに条件文を作成。
            //１＝未入力状態
            //２＝駅名は未確定状態
            //３＝駅名は確定状態
            if (axExpDiaStationNameEdit21.InputState == 3 && axExpDiaStationNameEdit22.InputState == 3)
            {
                ExpDiaDB10 idb = new ExpDiaDB10();
                ExpDiaNavi6 navi = idb.CreateNavi6();
                navi.AddKey(axExpDiaStationNameEdit21.StationName);
                navi.AddKey(axExpDiaStationNameEdit22.StationName);

                //登録された駅名が探索に用いるときに正しいかどうかを判定する
                //エラーコードの式は
                //エラーコード ＝ エラー種別 × １００ ＋ エラー位置
                //詳しいコードは【エラー種別】で調べる
                //※エラーがない場合は0である。
                if (idb.CheckNavi6((ExpDiaNavi6)navi) > 0)
                {
                    MessageBox.Show("探索結果が０件です。\n入力内容を変更してください。");                   
                }
                else
                { 
                    frmResult station_name_fr = new frmResult(axExpDiaStationNameEdit21.StationName,axExpDiaStationNameEdit22.StationName);
                    station_name_fr.ShowDialog(this);
                }
            }
            else if (axExpDiaStationNameEdit21.InputState == 3)
            {
                MessageBox.Show("到着駅に正しい駅名を入力してください。\n黒文字が適正駅名です。");
            }
            else if (axExpDiaStationNameEdit22.InputState == 3)
            {
                MessageBox.Show("出発駅に正しい駅名を入力してください。\n黒文字が適正駅名です。");
            }
            else
            {
                MessageBox.Show("出発駅、到着駅に駅名を入力してください。\n" +
                                "例（出発駅：高円寺、到着駅：中野（東京））");
            }
        }
    }
}
