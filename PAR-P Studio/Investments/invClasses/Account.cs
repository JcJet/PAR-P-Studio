using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAR_P_Studio.Investments.invClasses
{
    [Serializable]
    public class Account
    {
        public string Number; //Номер счета
        public string Owner; //Какому трейдеру принадлежит
        public string Info; //доп. инфо.

        public Account()
        {
            Number = "";
            Owner = "";
            Info = "";
        }

        public Account(Account AccountObj)
        {
            Number = AccountObj.Number;
            Owner = AccountObj.Owner;
            Info = AccountObj.Info;
        }

        public void SaveAccount()
        {
            string filename = "Data//Forex//Accounts//" + Number + ".act";
            FileStream AccountFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter AccountFormatter = new BinaryFormatter();
            AccountFormatter.Serialize(AccountFile, this);
            AccountFile.Close();
        }
    }
}
