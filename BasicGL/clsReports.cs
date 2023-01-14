using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BasicGL
{
    internal class Reports
    {
        internal static DSet.rptJETempTableDataTable GetJEDocument(uint number)
        {
            DSet.rptJETempTableDataTable res = new DSet.rptJETempTableDataTable();

            try
            {
                string sql = "SELECT tblDocuments.doc_no, doc_date, doc_amount, doc_desc, t_no, t_debit, t_credit, t_desc, tblAccounts.acc_no, acc_name FROM (tblDocuments INNER JOIN tblTransctions ON tblDocuments.doc_no = tblTransctions.doc_no) INNER JOIN tblAccounts ON tblTransctions.acc_no = tblAccounts.acc_no WHERE tblDocuments.doc_no=" + number;
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }


        internal static DSet.rptJETempTableDataTable GetJE(DateTime date)
        {
            DSet.rptJETempTableDataTable res = new DSet.rptJETempTableDataTable();

            try
            {
                string sql = "SELECT tblDocuments.doc_no, doc_date, doc_amount, doc_desc, t_no, t_debit, t_credit, t_desc, tblAccounts.acc_no, acc_name FROM (tblDocuments INNER JOIN tblTransctions ON tblDocuments.doc_no = tblTransctions.doc_no) INNER JOIN tblAccounts ON tblTransctions.acc_no = tblAccounts.acc_no WHERE DateValue(Format(tblDocuments.doc_date,\"yyyy/MM/dd\")) = DateValue(Format(\""+ date.ToString("yyyy/MM/dd") + "\",\"yyyy/MM/dd\"))";
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }

        internal static DSet.rptDASTempTableDataTable GetDAS(int number)
        {
            DSet.rptDASTempTableDataTable res = new DSet.rptDASTempTableDataTable();

            try
            {
                string sql = "SELECT tblDocuments.doc_no, doc_date, doc_amount, doc_desc, t_no, t_debit, t_credit, t_desc, tblAccounts.acc_no, acc_name FROM (tblDocuments INNER JOIN tblTransctions ON tblDocuments.doc_no = tblTransctions.doc_no) INNER JOIN tblAccounts ON tblTransctions.acc_no = tblAccounts.acc_no WHERE tblAccounts.acc_no=" + number;
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }


        internal static DSet.rptTASTempTableDataTable GetTAS(int number)
        {
            DSet.rptTASTempTableDataTable res = new DSet.rptTASTempTableDataTable();

            try
            {
                string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name,iif(Sum(tblTransctions.t_debit) - sum(tblTransctions.t_credit) > 0,Sum(tblTransctions.t_debit) - sum(tblTransctions.t_credit),0) AS debit,iif(Sum(tblTransctions.t_credit) - sum(tblTransctions.t_debit) > 0 ,Sum(tblTransctions.t_credit) - sum(tblTransctions.t_debit),0) AS credit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no where tblAccounts.acc_no=" + number + " GROUP BY tblAccounts.acc_no, tblAccounts.acc_name";
                //string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name, Sum(tblTransctions.t_debit) AS debit, Sum(tblTransctions.t_credit) AS credit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no where tblAccounts.acc_no="+ number +" GROUP BY tblAccounts.acc_no, tblAccounts.acc_name";
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }

        internal static DSet.rptTBTempTableDataTable GetTB()
        {
            DSet.rptTBTempTableDataTable res = new DSet.rptTBTempTableDataTable();

            try
            {
                string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name,iif(Sum(tblTransctions.t_debit) - sum(tblTransctions.t_credit) > 0,Sum(tblTransctions.t_debit) - sum(tblTransctions.t_credit),0) AS debit,iif(Sum(tblTransctions.t_credit) - sum(tblTransctions.t_debit) > 0 ,Sum(tblTransctions.t_credit) - sum(tblTransctions.t_debit),0) AS credit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no GROUP BY tblAccounts.acc_no, tblAccounts.acc_name";
                
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }


        internal static DSet.rptTASTempTableDataTable GetBS(DateTime date)
        {
            DSet.rptTASTempTableDataTable res = new DSet.rptTASTempTableDataTable();

            try
            {
                string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name, (IIf(Sum(tblTransctions.t_debit)-sum(tblTransctions.t_credit)>0,Sum(tblTransctions.t_debit)-sum(tblTransctions.t_credit),0)) AS debit, (IIf(Sum(tblTransctions.t_credit)-sum(tblTransctions.t_debit)>0,Sum(tblTransctions.t_credit)-sum(tblTransctions.t_debit),0)) AS credit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no WHERE tblAccounts.acc_type=1 GROUP BY tblAccounts.acc_no, tblAccounts.acc_name ORDER BY tblAccounts.acc_no";
                
                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }


        internal static DSet.rptTASTempTableDataTable GetIS(DateTime date)
        {
            DSet.rptTASTempTableDataTable res = new DSet.rptTASTempTableDataTable();

            try
            {
                string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name, (IIf(Sum(tblTransctions.t_debit)-sum(tblTransctions.t_credit)>0,Sum(tblTransctions.t_debit)-sum(tblTransctions.t_credit),0)) AS debit, (IIf(Sum(tblTransctions.t_credit)-sum(tblTransctions.t_debit)>0,Sum(tblTransctions.t_credit)-sum(tblTransctions.t_debit),0)) AS credit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no WHERE tblAccounts.acc_type=2 GROUP BY tblAccounts.acc_no, tblAccounts.acc_name ORDER BY tblAccounts.acc_no";

                using (OleDbDataAdapter da = new OleDbDataAdapter(sql, new OleDbConnection(Constants.GetConnectionString)))
                {
                    da.Fill(res);
                }
            }
            catch
            {

            }

            return res;
        }

    }
}
