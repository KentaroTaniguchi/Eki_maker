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
        private bool v;

        public frmResult()
        {
            InitializeComponent();
        }

        public frmResult(int count)
        {
            
        }
        public frmResult(string station1, string station2) : this()
        {

            ExpDiaNavi6 navi = (ExpDiaNavi6)axExpDiaShowCoursePanel131.ExpDiaNavi_A2;
            navi.AddKey(station1);
            navi.AddKey(station2);
            axExpDiaShowCoursePanel131.SearchCourse_A2();
            ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
            
            ExpDiaCourse10 course = couseSet.GetCourse10(1, 1);
            
        }

        public frmResult(Form1 mainform) : this()
        {
            ExpDiaNavi6 navi = (ExpDiaNavi6)axExpDiaShowCoursePanel131.ExpDiaNavi_A2;
            navi.AddKey(mainform.axExpDiaStationNameEdit21.StationName);
            navi.AddKey(mainform.axExpDiaStationNameEdit22.StationName);
            axExpDiaShowCoursePanel131.SearchCourse_A2();
          //  ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
          //  Console.WriteLine(couseSet.CourseCount);
          //  ExpDiaCourse10 course = couseSet.GetCourse10(1,1);
          // ExpDiaCourse10 couseget = new ExpDiaCourse10();
          
           
            
        }

        private void frmResult_Load(object sender, EventArgs e)
        {

            
        }

        public static implicit operator frmResult(AxExpStationNameEdit v)
        {
            throw new NotImplementedException();
        }

        public void botton1_Click(object sender, EventArgs e)
        {
             ExpDiaCourseSet10 couseSet = (ExpDiaCourseSet10)axExpDiaShowCoursePanel131.ExpDiaCourseSet10;
             ExpDiaCourse10 course = couseSet.GetCourse10(1, 1);
            
            IExpDiaCourse_A2 couseget = (IExpDiaCourse_A2)axExpDiaShowCoursePanel131.ExpDiaCourse_A2;

            //JSONに入れたい探索結果情報
            cousedate route = new cousedate();
            route.Name = couseget.DDEStyleString2;
            route.TotalTime = couseget.TotalTime;

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) {
                System.IO.Stream stream   ;
                stream = sfd.OpenFile();
            }
            
            var json = JsonConvert.SerializeObject(route,Formatting.Indented);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"C:\Users\kentaro\Desktop\SDKを使ったプログラム\Eki_maker\Eki_maker\bin\Debug\routedata.json", false, System.Text.Encoding.GetEncoding("shift_jis"));
            frmResult fm = new frmResult();
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
    }
}
