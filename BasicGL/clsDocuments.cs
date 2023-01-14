using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGL
{
    internal class Document
    {
        private uint doc_no;
        private DateTime doc_date;
        private double amount;
        private string desc;
        private List<Transction> t = new List<Transction>();

        internal Document(uint number)
        {


            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = @"select doc_no,doc_date,doc_amount,doc_desc from tblDocuments where doc_no=" + number.ToString();

                if (db.ExcuteQuery(sql))
                {
                    if (db.GetDataReader.Read())
                    {
                        this.doc_no = Convert.ToUInt32(db.GetDataReader["doc_no"].ToString());
                        this.desc = (db.GetDataReader["doc_desc"].ToString());
                        this.amount = Convert.ToDouble(db.GetDataReader["doc_amount"].ToString());
                        this.doc_date = Convert.ToDateTime(db.GetDataReader["doc_date"].ToString());
                        this.t = TransctionManager.GetDocumentTransctions(this.doc_no);

                        if (!(t.Count > 1))
                        {
                            throw new Exception();
                        }

                    }
                }

                db.CloseConnecton();
            }
            catch
            {
                this.doc_no = 0;
            }

        }


        internal Document(
           uint doc_no,
           DateTime doc_date,
           double amount,
           string desc,
           List<Transction> t
        )
        {
            this.doc_no = doc_no;
            this.doc_date = doc_date;
            this.amount = amount;
            this.desc = desc;
            this.t.AddRange(t);
        }


        internal uint Number
        {
            get
            {
                return this.doc_no;
            }
        }

        internal DateTime Date
        {
            get
            {
                return this.doc_date;
            }
        }

        internal double Amount
        {
            get
            {
                return this.amount;
            }
        }

        internal string Descrption
        {
            get
            {
                return this.desc;
            }
        }

        internal List<Transction> GetTransctions
        {
            get
            {
                return this.t;
            }
        }

    }

    internal static class DocumentManager
    {
        internal static bool Add(Document document)
        {
            bool res = false;

            try
            {
                if(!(document.GetTransctions.Count > 1))
                {
                    throw new Exception();
                }

                if (!(document.Amount > 0))
                {
                    throw new Exception();
                }

                double tdebit = 0;
                double tcredit = 0;

                for(int i=0;i<document.GetTransctions.Count;i++)
                {
                    tdebit += document.GetTransctions[i].GetDebit;
                    tcredit += document.GetTransctions[i].GetCredit;
                }

                if(tdebit != tcredit)
                {
                    throw new Exception();
                }

                if(document.Amount != tdebit)
                {
                    throw new Exception();
                }

                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "insert into tblDocuments (doc_no,doc_date,doc_amount,doc_desc) values("+ document.Number +",'"+ document.Date.ToString() +"',"+ document.Amount +",'" + document.Descrption + "')";

                if(db.ExcuteNonQuery(sql)==1)
                {
                    for(int i=0;i<document.GetTransctions.Count;i++)
                    {
                        if(!TransctionManager.Add(document.GetTransctions[i]))
                        {
                            Delete(document);
                            throw new Exception();
                        }
                    }

                    res = true;
                    
                }


            }
            catch
            {

            }

            return res;
        }


        internal static bool Delete(Document document)
        {
            bool res = false;

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "delete from tblDocuments where doc_no=" + document.Number ;

                if(db.ExcuteNonQuery(sql) == 1)
                {
                    res = true;
                }

            }
            catch
            {

            }

            return res;
        }

        internal static uint GenerateNewDocumentNumber()
        {

            uint res = 0;

            AccessDB db = new AccessDB(Constants.GetConnectionString);
            string sql = "select max(doc_no) as res from tblDocuments";

            if (db.ExcuteQuery(sql))
            {
                if (db.GetDataReader.Read())
                {
                    string r = db.GetDataReader["res"].ToString();
                    if (string.IsNullOrEmpty(r))
                    {
                        res = 1;
                    }
                    else
                    {
                        res = uint.Parse(r);
                        res++;
                    }
                }

            }

            db.CloseConnecton();
            return res;

        }




    }
}
