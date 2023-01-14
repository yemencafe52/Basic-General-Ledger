//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;

//namespace BasicGL
//{
//    static class clsTest
//    {
//        static void Main()
//        {
//            //bool res = clsUtilities.CheckDBFile();
//            //res = clsUtilities.TestDB();

//            // Person p = new Person(PeopleManager.GenerateNewPersonNumber(), "perons2");

//            // bool res = PeopleManager.Add(p);

//            //List<Person> r = PeopleManager.Search("2");

//            //int x = r.Count;


//            //List<Transction> t = TransctionManager.Search(new DateTime(2022, 1, 1), new DateTime(2022, 12, 31), new Person(1, "", 0, 0));

//            //Console.Write(t.Count);


//            //TransctionManager.Add(new Transction(0, 1, new DateTime(), "test", 100, 0));


//            // UserManager.ChangePassword("123");
//            // UserManager.Login("123");

//            //Person p = new Person(1);


//            //List<Transction> t = new List<Transction>();
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, 4));
//            //t.Add(new Transction(0, 122001, "test 1",0, 300, 4));

//            //Document doc = new Document(4, DateTime.Now, 300, "doc test", t);
//            //bool res = (DocumentManager.Add(doc));
//            // res = (DocumentManager.Delete(doc));

//            // Document doc = new Document(3);

//            //  uint num = DocumentManager.GenerateNewDocumentNumber();
//            //DateTime date = new DateTime(2022, 11, 16);
//            //Microsoft.Reporting.WinForms.ReportParameter p = new Microsoft.Reporting.WinForms.ReportParameter("p", date.ToString("yyyy/MM/dd"));
//            //frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptJETempTable", (DataTable)Reports.GetJE(date)), "BasicGL.rptDailyTransctions.rdlc",p);
//            ////frv.SetDataTable = Reports.GetJEDocument(1);
//            //frv.ShowDialog();




//            //frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptDASTempTable", (DataTable)Reports.GetDAS(121001)), "BasicGL.rptDAS.rdlc");
//            //frv.ShowDialog();

//            //frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptTASTempTable", (DataTable)Reports.GetTAS(121001)), "BasicGL.rptTAS.rdlc");
//            //frv.ShowDialog();


//            //frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptBSTempTable", (DataTable)Reports.GetBS(new DateTime())), "BasicGL.rptBS.rdlc");
//            //frv.ShowDialog();




//            //List<Transction> t = new List<Transction>();


//            //uint num = DocumentManager.GenerateNewDocumentNumber();


//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));

//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));

//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));

//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//            //t.Add(new Transction(0, 121001, "test 0", 300, 0, num));











//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//            //t.Add(new Transction(0, 122001, "test 1", 0, 300, num));

//            //Document doc = new Document(num, DateTime.Now, 30000, "doc test", t);
//            //bool res = (DocumentManager.Add(doc));
//            ////res = (DocumentManager.Delete(doc));



//            int counter = 0;

//            while (counter < 10000)
//            {

//                List<Transction> t = new List<Transction>();


//                uint num = DocumentManager.GenerateNewDocumentNumber();


//                t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//                t.Add(new Transction(0, 121001, "test 0", 300, 0, num));
//                t.Add(new Transction(0, 121001, "test 0", 300, 0, num));

//                t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//                t.Add(new Transction(0, 122001, "test 1", 0, 300, num));
//                t.Add(new Transction(0, 122001, "test 1", 0, 300, num));


//                Document doc = new Document(num, DateTime.Now, 900, "doc test", t);
//                bool res = (DocumentManager.Add(doc));
//                //res = (DocumentManager.Delete(doc));

//                counter++;
//            }


//            // frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptISTempTable", (DataTable)Reports.GetIS(new DateTime())), "BasicGL.rptIS.rdlc");
//            // frv.ShowDialog();

//        }
//    }
//}
