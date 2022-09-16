using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAR_P_Studio.Investments.invClasses
{
    [Serializable]
    public class Index
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public Image Logo { get; set; }
        public bool PrivateIndex { get; set; }
        public List<Index.Part> Parts { get; set; }

        [Serializable]
        public class Part
        {
            public string Number { get; set; }
            public double Percentage { get; set; }

            public Part()
            {
                Number = "";
                Percentage = 0;
            }
            public Part(Index.Part PartObj)
            {
                Number = PartObj.Number;
                Percentage = PartObj.Percentage;
            }
        }

        public Index()
        {
            Name = "";
            Description = "";
            Owner = "";
            Logo = null;
            PrivateIndex = false;
            Parts = new List<Index.Part>();
        }

        public Index(Index IndexObj)
        {
            Name = IndexObj.Name;
            Description = IndexObj.Description;
            Owner = IndexObj.Owner;
            Logo = IndexObj.Logo;
            PrivateIndex = IndexObj.PrivateIndex;
            Parts = new List<Index.Part>();
            foreach (Index.Part currPart in IndexObj.Parts)
                Parts.Add(new Part(currPart));
        }

        public void SaveIndex()
        {
            string filename = "Data//Forex//Indexes//" + Name + ".ind";
            FileStream IndexFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter IndexFormatter = new BinaryFormatter();
            IndexFormatter.Serialize(IndexFile, this);
            IndexFile.Close();
        }

    }
}
