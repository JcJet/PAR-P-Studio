using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAR_P_Studio.Investments.invClasses
{
    [Serializable]
    public class Trader
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string Notes { get; set; }

        public Trader()
        {
            Name = "";
            Info = "";
            Notes = "";
        }

        public Trader(Trader TraderObj)
        {
            Name = TraderObj.Name;
            Info = TraderObj.Info;
            Notes = TraderObj.Notes;
        }

        public void SaveTrader()
        {
            string filename = "Data//Forex//Traders//" + Name + ".tdr";
            FileStream TraderFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter TraderFormatter = new BinaryFormatter();
            TraderFormatter.Serialize(TraderFile, this);
            TraderFile.Close();
        }

    }

}
