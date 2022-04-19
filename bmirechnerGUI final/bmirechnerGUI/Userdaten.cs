using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bmirechnerGUI
{
    [Serializable]
    class Userdaten
    {
        public string name { get; set; }
        public string nachname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string geschlecht { get; set; }
        public string daten1 { get; set; }
        public string daten2 { get; set; }
        public string daten3 { get; set; }
        public string daten4 { get; set; }
        public string daten5 { get; set; }
        public string code { get; set; }


        public void save(string path)
        {
            FileStream save = new FileStream(path, FileMode.Create);
            BinaryFormatter bnfm = new BinaryFormatter();
            
            bnfm.Serialize(save, this);
            
            save.Dispose();
            save.Close();
        }

        
        public Userdaten load(string path)
        {
            Userdaten USA = new Userdaten();

            FileStream save = new FileStream(path, FileMode.Open);
            BinaryFormatter bnfm = new BinaryFormatter();

            USA = (Userdaten)bnfm.Deserialize(save);

            save.Dispose();
            save.Close();

            return USA;
        }
    }
}