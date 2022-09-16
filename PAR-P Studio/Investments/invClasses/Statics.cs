using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAR_P_Studio.Investments.invClasses
{
    static class Statics
    {
        static public Trader currTrader;
        static public Account currAccount;
        static public Index currIndex;

        public static void LoadAccount(string name)
        {
            FileStream AccFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Forex\\Accounts\\" + name
                + ".act", FileMode.Open, FileAccess.Read);
            BinaryFormatter AccFormatter = new BinaryFormatter();
            Statics.currAccount = new Account((Account)AccFormatter.Deserialize(AccFile));
            AccFile.Close();
        }
        public static void LoadIndex(string name)
        {
            FileStream IndFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Forex\\Indexes\\" + name
                + ".ind", FileMode.Open, FileAccess.Read);
            BinaryFormatter IndFormatter = new BinaryFormatter();
            Statics.currIndex = new Index((Index)IndFormatter.Deserialize(IndFile));
            IndFile.Close();
        }
    }
}
