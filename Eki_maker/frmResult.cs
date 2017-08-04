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
        /// 探索結果の表示
        /// </summary>
        /// <param name="station1"></param>
        /// <param name="station2"></param>
        public frmResult(string station1, string station2) : this()
        {
            ExpDiaNavi6 navi = (ExpDiaNavi6)axExpDiaShowCoursePanel131.ExpDiaNavi_A2;
            ExpDiaDB10 db10 = new ExpDiaDB10();
            navi.AddKey(station1);
            navi.AddKey(station2);
            axExpDiaShowCoursePanel131.SearchCourse_A2();
            
            /*  try
        {
            axExpDiaShowCoursePanel131.SearchCourse_A2();
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.Message);

        }*/


        }
      

        /// <summary>
        /// ボタンがクリックされた時
        /// 探索結果の情報をCouseDateの中に入れる。
        /// 中身をjson形式にコンバートし
        /// jsonファイルを作成する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Write_Json(object sender, EventArgs e)
        {
            ExpDiaCourseSet10 courseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
            ExpDiaCourse10 course = courseSet.GetCourse10(axExpDiaShowCoursePanel131.CurrentSortType, axExpDiaShowCoursePanel131.CurrentCourseNo);
            //jsonに入れたい探索結果情報
            CourseDate coursedate = new CourseDate();
            coursedate.Route = course.DDEStyleString;
            coursedate.TotalTime = course.TotalTime;

            var json = JsonConvert.SerializeObject(coursedate, Formatting.Indented);
            var deserialized = JsonConvert.DeserializeObject<CourseDate>(json);
            
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "新しいファイル.json";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"C:\Users\kentaro\デスクトップ";
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
                sw.Write(json);
                sw.Close();
                this.Close();
            }
        }
    }
}




