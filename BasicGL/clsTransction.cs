using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGL
{
    internal class Transction
    {
        private int t_no;
        private int acc_no;
        private uint doc_no;
        private DateTime t_time;
        private string t_desc;
        private double t_debit;
        private double t_credit;

        internal Transction(
            int t_no,
            int acc_no,
            
            string t_desc,
            double t_debit,
            double t_credit,
            uint doc_no
            )
        {
            this.t_no = t_no;
            this.acc_no = acc_no;
            
            this.t_desc = t_desc;
            this.t_debit = t_debit;
            this.t_credit = t_credit;
            this.doc_no = doc_no;
        }


        internal int GetTransction
        {
            get
            {
                return this.t_no;
            }
        }

        internal int GetAccountNumber
        {
            get
            {
                return this.acc_no;
            }
        }


        internal string GetDescrption
        {
            get
            {
                return this.t_desc;
            }
        }

        internal double GetDebit
        {
            get
            {
                return this.t_debit;
            }
        }

        internal double GetCredit
        {
            get
            {
                return this.t_credit;
            }
        }

        internal uint DocumentNumber
        {
            get
            {
                return this.doc_no;
            }
        }

    }

    internal static class TransctionManager
    {
        internal static bool Add(Transction transction)
        {
            bool res = false;

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "insert into tblTransctions (acc_no,t_desc,t_debit,t_credit,doc_no) values("+ transction.GetAccountNumber + ",'"+ transction.GetDescrption +"',"+ transction.GetDebit +","+ transction.GetCredit +","+ transction.DocumentNumber +")";
                if (db.ExcuteNonQuery(sql) == 1)
                {
                    res = true;
                }
            }
            catch
            {

            }


            return res;
        }
        

        internal static List<Transction> GetDocumentTransctions(uint number)
        {
            List<Transction> res = new List<Transction>();

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "select t_no,acc_no,t_desc,t_debit,t_credit,doc_no from tblTransctions where doc_no=" + number;

                if (db.ExcuteQuery(sql))
                {
                    while (db.GetDataReader.Read())
                    {
                          res.Add(new Transction(Convert.ToInt32(db.GetDataReader["t_no"]), Convert.ToInt32(db.GetDataReader["acc_no"]), Convert.ToString(db.GetDataReader["t_desc"]), Convert.ToDouble(db.GetDataReader["t_debit"]), Convert.ToDouble(db.GetDataReader["t_credit"]),Convert.ToUInt32(db.GetDataReader["doc_no"].ToString())));
                    }
                }

                db.CloseConnecton();

            }
            catch
            {
                res.Clear();
            }

            return res;
        }
    }
}
