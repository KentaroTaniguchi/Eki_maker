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

        public void button1_Click(object sender, EventArgs e)
        {

            
            ExpDataExtraction2 stations = new ExpDataExtraction2();
            if(stations.IsValidStation(20170731, axExpDiaStationNameEdit21.StationName) && stations.IsValidStation(20170731, axExpDiaStationNameEdit22.StationName))
            {
                ExpDiaDB10 idb = new ExpDiaDB10();
                ExpDiaNavi6 navi = idb.CreateNavi6();
                navi.AddKey(axExpDiaStationNameEdit21.StationName);
                navi.AddKey(axExpDiaStationNameEdit22.StationName);
                frmResult f = new frmResult(axExpDiaStationNameEdit21.StationName, axExpDiaStationNameEdit22.StationName );
                f.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("駅名が正しく入力されていません。");
            }

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
                StreamReader sr2 = new StreamReader(ofd.FileName, Encoding.GetEncoding("shift_jis"));
                if (Regex.IsMatch(sr.ReadToEnd(), "\"name\":"))
                {
                    deserialized = JsonConvert.DeserializeObject<cousedate>(sr.ReadToEnd());
                }
                else
                {
                    MessageBox.Show("そのファイルは適していません");
                }

                label4.Text = $"経路名（路線名）: {deserialized.Name}";
                label5.Text = $"合計時間: {deserialized.TotalTime}";

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
