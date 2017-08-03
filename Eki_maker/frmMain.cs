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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 探索ボタンが押された時に
        /// 入力値が適しているなら探索結果画面に移動し探索結果を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_route(object sender, EventArgs e)
        {
            //ExpDiaStationNameEdit21の入力状態の値をもとに条件文を作成。
            //１＝未入力状態
            //２＝駅名は未確定状態
            //３＝駅名は確定状態
            if (axExpDiaStationNameEdit21.InputState == 3 && axExpDiaStationNameEdit22.InputState == 3)
            {
                ExpDiaDB10 idb = new ExpDiaDB10();
                ExpDiaNavi6 navi = idb.CreateNavi6();
                frmResult station_name_fr = new frmResult(axExpDiaStationNameEdit21.StationName, axExpDiaStationNameEdit22.StationName);
                station_name_fr.ShowDialog(this);
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

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  ファイル読み込みを行う。
        /// jsonファイルではない、cousedata内の値が空だった場合に例外処理が発生する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Read(object sender, EventArgs e)
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
            CouseDate cousedate = new CouseDate();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.GetEncoding("shift_jis"));
                try
                {
                    cousedate = JsonConvert.DeserializeObject<CouseDate>(sr.ReadToEnd());

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
                //deserialized.Nameの中身が何もなかった場合に
                if (cousedate.Route == null)
                {
                    MessageBox.Show("探索結果の経路情報が空となっています。\n" + ofd.FileName + "の中身に経路情報が存在するか確認してください。");

                }
                else
                {
                    label4.Text = $"経路名（路線名）: {cousedate.Route}";
                    label5.Text = $"合計時間: {cousedate.TotalTime}";
                }
            }
        }
    }
}
