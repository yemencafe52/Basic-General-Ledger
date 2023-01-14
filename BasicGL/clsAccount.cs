using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGL
{
    class Account
    {
        private int number;
        private string name;
        private double tdebit;
        private double tcredit;
        private byte type;

        internal Account(int number)
        {
            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "SELECT tblAccounts.acc_no, tblAccounts.acc_name, ((IIf(Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit)>0,Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit),0))) AS tdebit, ((IIf(Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit)>0,Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit),0))) AS tcredit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no where tblAccounts.acc_no=" + number +" GROUP BY tblAccounts.acc_no, tblAccounts.acc_name;";

                if (db.ExcuteQuery(sql))
                {
                    if (db.GetDataReader.Read())
                    {
                        this.number = Convert.ToInt32(db.GetDataReader["acc_no"].ToString());
                        this.name = db.GetDataReader["acc_name"].ToString();
                        this.tdebit = Convert.ToDouble(db.GetDataReader["tdebit"]);
                        this.tcredit = Convert.ToDouble(db.GetDataReader["tcredit"]);
                    }
                }
                else
                {
                    this.number = -1;
                }

                db.CloseConnecton();

            }
            catch
            {
                this.number = -1;
            }

        }

        internal Account(int number,string name,double debit,double credit,byte type)
        {
            this.number = number;
            this.name = name;
            this.tdebit = debit;
            this.tcredit = credit;
            this.type = type;
        }

        internal int GetNumber
        {
            get
            {
                return this.number;
            }
        }

        internal string GetName
        {
            get
            {
                return this.name;
            }
        }

        internal double Debit
        {
            get
            {
                return this.tdebit;
            }
        }

        internal double Credit
        {
            get
            {
                return this.tcredit;
            }
        }

        internal byte GetTypeInfo
        {
            get
            {
                return this.type;
            }
        }


    }

    class AccountManager
    {
        
        internal static bool Add(Account account)
        {
            bool res = false;

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "insert into tblAccounts (acc_no,acc_name,acc_type) values("+ account.GetNumber  +",'"+  account.GetName +"'," + ((byte)account.GetTypeInfo) + ")";
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

        internal static List<Account> Search(string txt)
        {
            List<Account> res = new List<Account>();

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "SELECT tblAccounts.acc_type,tblAccounts.acc_no, tblAccounts.acc_name, ((IIf(Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit)>0,Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit),0))) AS tdebit, ((IIf(Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit)>0,Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit),0))) AS tcredit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no where tblAccounts.acc_name like('%" + txt+ "%') GROUP BY tblAccounts.acc_no, tblAccounts.acc_name,tblAccounts.acc_type;";

                if (db.ExcuteQuery(sql))
                {
                    while (db.GetDataReader.Read())
                    {
                        res.Add(new Account(Convert.ToInt32(db.GetDataReader["acc_no"].ToString()), (db.GetDataReader["acc_name"].ToString()), Convert.ToDouble(db.GetDataReader["tdebit"]), Convert.ToDouble(db.GetDataReader["tcredit"]), Convert.ToByte(db.GetDataReader["acc_type"])));
                    }
                }

                db.CloseConnecton();

            }
            catch
            {

            }

            return res;
        }

        internal static List<Account> GetALL()
        {
            List<Account> res = new List<Account>();

            try
            {
                AccessDB db = new AccessDB(Constants.GetConnectionString);
                string sql = "SELECT tblAccounts.acc_type,tblAccounts.acc_no, tblAccounts.acc_name, ((IIf(Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit)>0,Sum(tblTransctions.t_debit)-Sum(tblTransctions.t_credit),0))) AS tdebit, ((IIf(Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit)>0,Sum(tblTransctions.t_credit)-Sum(tblTransctions.t_debit),0))) AS tcredit FROM tblAccounts LEFT JOIN tblTransctions ON tblAccounts.acc_no = tblTransctions.acc_no GROUP BY tblAccounts.acc_no, tblAccounts.acc_name,tblAccounts.acc_type;";

                if(db.ExcuteQuery(sql))
                {
                    while(db.GetDataReader.Read())
                    {
                        res.Add(new Account(Convert.ToInt32(db.GetDataReader["acc_no"].ToString()), (db.GetDataReader["acc_name"].ToString()),Convert.ToDouble(db.GetDataReader["tdebit"]), Convert.ToDouble(db.GetDataReader["tcredit"]), Convert.ToByte(db.GetDataReader["acc_type"])));
                    }
                }

                db.CloseConnecton();

            }
            catch
            {

            }

            return res;
        }

        //internal static int GenerateNewPersonNumber()
        //{
        //    //if (pno > 0)
        //    //{
        //    //    return ++pno;
        //    //}

        //    AccessDB db = new AccessDB(Constants.GetConnectionString);
        //    string sql = "select max(acc_no) as res from tblAccounts";

        //    if (db.ExcuteQuery(sql))
        //    {
        //        if (db.GetDataReader.Read())
        //        {
        //            string r = db.GetDataReader["res"].ToString();
        //            if (string.IsNullOrEmpty(r))
        //            {
        //                pno = 1;
        //            }
        //            else
        //            {
        //                pno = int.Parse(r);
        //                pno++;
        //            }
        //        }

        //    }

        //    db.CloseConnecton();
        //    return pno;

        //}
    }

}
