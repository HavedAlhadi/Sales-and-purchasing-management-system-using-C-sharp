using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SuperSoft
{
     class ClassGenric
    {
        static int i = -1;
        static int Q = 0;
        static int cols = 0;
        static int dis = 0;
        static string U = "";
        static DateTime DE;
        static string Note = "";
        static public OleDbConnection Conaction()
            {
            
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + "\\DatabaseSuperM.mdb");
            return con;
        }
        static public void Ahadi_index(int inde) {i = inde;}
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_Q(int inde){Q = inde;}
        static public int Ahadi_Q() { return Q; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_Cols(int inde) { cols = inde; }
        static public int Ahadi_Cols() { return cols; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_Dis(int inde) { dis = inde; }
        static public int Ahadi_Dis() { return dis; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_U(string inde){ U = inde;}
        static public string Ahadi_U() { return U; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_DE(DateTime inde) { DE = inde; }
        static public DateTime Ahadi_DE() {return DE; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public void Ahadi_Note(string inde) { Note = inde; }
        static public string Ahadi_Note() {return Note; }
        //+++++++++++++++++++++++++++++++++++++++++++++++++
        static public int Ahadi_indexG()
        {
           
                return i;           
        }
        static public void AhadiText(object sender,KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 47 && e.KeyChar <= 58))
            {
                e.KeyChar = '\n';
            }
        }
        static public void AhadiTextNum(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.KeyChar = '\n';
            }
        }

        
    }
}

