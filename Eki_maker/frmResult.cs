using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxEXPJPCTLLib;
using EXPDENGNLib;
using AxEXPDCTRL2Lib;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Eki_maker
{
    public partial class frmResult : Form 
    {
        public frmResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="station1"></param>
        /// <param name="station2"></param>
        public frmResult(string station1, string station2) : this()
        {
            ExpDiaNavi6 navi = (ExpDiaNavi6)axExpDiaShowCoursePanel131.ExpDiaNavi_A2;      
            navi.AddKey(station1);
            navi.AddKey(station2);
            axExpDiaShowCoursePanel131.SearchCourse_A2();
            ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
            ExpDiaCourse10 course = couseSet.GetCourse10(1, 1);   
        }

        /// <summary>
        /// frmResult内で入力内容、探索結果を表示。
        /// </summary>
        /// <param name="mainform"></param>
        public frmResult(Form1 mainform) : this()
        {
            ExpDiaNavi6 navi = (ExpDiaNavi6)axExpDiaShowCoursePanel131.ExpDiaNavi_A2;
            navi.AddKey(mainform.axExpDiaStationNameEdit21.StationName);
            navi.AddKey(mainform.axExpDiaStationNameEdit22.StationName);
            axExpDiaShowCoursePanel131.SearchCourse_A2();
          //  ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
          //  Console.WriteLine(couseSet.CourseCount);
          //  ExpDiaCourse10 course = couseSet.GetCourse10(1,1);
          //  ExpDiaCourse10 couseget = new ExpDiaCourse10();  
            
        }

        private void frmResult_Load(object sender, EventArgs e)
        {

            
        }

        public static implicit operator frmResult(AxExpStationNameEdit v)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ボタンがクリックされた時
        /// 探索結果の情報をcousedateの中に入れる。
        /// cousedateをjson形式にコンバートし
        /// jsonファイルを作成する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void botton1_Click(object sender, EventArgs e)
        {
             ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
             ExpDiaCourse10 course = couseSet.GetCourse10(1, 1);
             IExpDiaCourse_A2 couseget = (IExpDiaCourse_A2)axExpDiaShowCoursePanel131.ExpDiaCourse_A2;
             
            //jsonに入れたい探索結果情報
            cousedate route = new cousedate();
            route.Name = couseget.CourseString2;
            route.TotalTime = couseget.TotalTime;
            
            var json = JsonConvert.SerializeObject(route, Formatting.Indented);
            var deserialized = JsonConvert.DeserializeObject<cousedate>(json);

            SaveFileDialog sfd = new SaveFileDialog();
            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "新しいファイル.json";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "jsonファイル|*.json;";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 2;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;
            
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(sfd.FileName);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
               sfd.FileName, false, System.Text.Encoding.GetEncoding("shift_jis"));
                try
                {
                    sw.Write(json);
                }
                finally
                {
                    sw.Close();
                    this.Close();
                }
            }

/*
            if (sfd.ShowDialog() == DialogResult.OK) {
                System.IO.Stream stream   ;
                stream = sfd.OpenFile();
                if(stream != null)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(json);
                    sw.Close();
                    stream.Close();
                    this.Close();
                }
            }*/
            
           
          /* System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", false, System.Text.Encoding.GetEncoding("shift_jis"));
            
            try
            {
                sw.Write(json);
            }
            finally
            {
                sw.Close();
                this.Close();
            }*/
        }
    }
}
