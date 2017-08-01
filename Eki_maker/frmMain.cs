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

        private void axExpStationNameEdit1_StationTypeChanged(object sender, AxEXPJPCTLLib._IExpStationNameEditEvents_StationTypeChangedEvent e)
        {
          
        }
        /// <summary>
        /// 探索ボタンが押された時に
        /// 入力値が適しているなら探索結果画面に移動し探索結果を表示
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            //ExpDiaStationNameEdit21の入力状態の値をもとに条件文を作成。
            //１＝未入力状態
            //２＝駅名は未確定状態
            //３＝駅名は確定状態
            if (axExpDiaStationNameEdit21.InputState == 3 && axExpDiaStationNameEdit22.InputState == 3)
            {
                ExpDiaDB10 idb = new ExpDiaDB10();
                ExpDiaNavi6 navi = idb.CreateNavi6();
                frmResult f = new frmResult(axExpDiaStationNameEdit21.StationName, axExpDiaStationNameEdit22.StationName);
                f.ShowDialog(this);
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
            /*
            //駅すぱあと情報リストオブジェクト。
            ExpDataExtraction2 stations = new ExpDataExtraction2();
            //駅すぱあとの情報とaxExpDiaStationNameEdit21（axExpDiaStationNameEdit22)で入力された駅名が同じだった場合に探索結果を表示。
            if(stations.IsValidStation(0, axExpDiaStationNameEdit21.StationName) && stations.IsValidStation(0, axExpDiaStationNameEdit22.StationName))
            {
                ExpDiaDB10 idb = new ExpDiaDB10();
                ExpDiaNavi6 navi = idb.CreateNavi6();
                navi.AddKey(axExpDiaStationNameEdit21.StationName);//botton１_click内で処理する場合
                navi.AddKey(axExpDiaStationNameEdit22.StationName);//botton１_click内で処理する場合
                frmResult f = new frmResult(axExpDiaStationNameEdit21.StationName, axExpDiaStationNameEdit22.StationName );
                f.ShowDialog(this);
            }
            else if (stations.IsValidStation(0, axExpDiaStationNameEdit21.StationName))
            {
                MessageBox.Show("到着駅に正しい駅名を入力してください。\n黒文字が適正駅名です。");

            }
            else if (stations.IsValidStation(0, axExpDiaStationNameEdit22.StationName))
            {
                MessageBox.Show("出発駅に正しい駅名を入力してください。\n黒文字が適正駅名です。");
            }
            else
            {
                MessageBox.Show("出発駅、到着駅に駅名を入力してください。\n" +
                                "例（出発駅：高円寺、到着駅：中野（東京））");
            }*/

            /*  try
              {
                  ExpDiaDB10 idb = new ExpDiaDB10();
                  ExpDiaNavi6 navi = idb.CreateNavi6();
                  navi.AddKey(axExpDiaStationNameEdit21.StationName);
                  navi.AddKey(axExpDiaStationNameEdit22.StationName);
                  frmResult f = new frmResult(axExpDiaStationNameEdit21.StationName, axExpDiaStationNameEdit22.StationName);
                  f.ShowDialog(this);
              }
              finally
              {

              }*/






        }

        private void axExpStationNameEdit2_StationTypeChanged(object sender, _IExpStationNameEditEvents_StationTypeChangedEvent e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void rbtAverage_CheckedChanged(object sender, EventArgs e)
        {
            Height = 290;
            
        }

        private void axExpDiaStationNameEdit22_StationTypeChanged(object sender, AxEXPDCTRL2Lib._IExpDiaStationNameEdit2Events_StationTypeChangedEvent e)
        {

        }

        private void axExpDiaStationNameEdit21_StationTypeChanged(object sender, AxEXPDCTRL2Lib._IExpDiaStationNameEdit2Events_StationTypeChangedEvent e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ファイル読み込みを行う。
        /// jsonファイルではない、cousedata内の値が空だった場合に例外処理が発生する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "新しいファイル.json";
            ofd.InitialDirectory= @"C:\";
            ofd.Filter = "JSONファイル(*.json)|*.json";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            cousedate deserialized = new cousedate();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.GetEncoding("shift_jis"));
                try
                {
                    deserialized = JsonConvert.DeserializeObject<cousedate>(sr.ReadToEnd());
                   
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
               if(deserialized.Name == "")
                {
                    MessageBox.Show("必要な値が存在しません。\n jsonの中身を確認してください。");
                }
                else
                {
                    label4.Text = $"経路名（路線名）: {deserialized.Name}";
                    label5.Text = $"合計時間: {deserialized.TotalTime}";
                }
                

            }
           



            //System.Windows.Forms.MessageBox.Show();
            /* string addr = "";
             cousedate read_route = new cousedate();

             System.Windows.Forms.MessageBox.Show(read_route.Name); 
            // StreamReader sr = new StreamReader(@"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", Encoding.GetEncoding("shift_JIS"));
             string text = sr.ReadToEnd();
             sr.Close();
             addr += text;*/
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           StreamReader sr = new StreamReader(@"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", Encoding.GetEncoding("shift_JIS"));
           

        }

    }
}
