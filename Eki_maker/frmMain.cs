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
          

            ExpDiaDB10 idb = new ExpDiaDB10();
            ExpDiaNavi6 navi = idb.CreateNavi6();
          
            navi.AddKey(axExpDiaStationNameEdit21.StationName);
            navi.AddKey(axExpDiaStationNameEdit22.StationName);

            frmResult f = new frmResult(this);
            f.ShowDialog(this);
            
            navi.RemoveAllKey();// 登録してある探索用駅情報（出発駅、到着駅、経由駅）を全て削除します





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
            string addr = "";
            StreamReader sr = new StreamReader(@"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", Encoding.GetEncoding("shift_JIS"));
            string text = sr.ReadToEnd();
            sr.Close();
            addr += text;
            System.Windows.Forms.MessageBox.Show(addr);
            Form1 f = new Form1();
            f.richTextBox1_TextChanged(text,e);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           StreamReader sr = new StreamReader(@"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", Encoding.GetEncoding("shift_JIS"));
           

        }
    }
}
