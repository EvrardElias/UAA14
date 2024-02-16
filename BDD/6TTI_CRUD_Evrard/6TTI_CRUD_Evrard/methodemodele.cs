using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Google.Protobuf.WellKnownTypes;
using System.Data.Common;

namespace _6TTI_CRUD_Evrard
{
    internal class methodemodele
    {
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=immo;port=3306;User Id=elias;password=root";
        }

        public bool ChercherBiens(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "Select * FROM biens";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos, "infoBiens");
                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }

        public bool AjouterBien(string[] donnees)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
        }

        public string AfficheDataUsers(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["nomBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["tailleBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["prixBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["villeBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["userIdBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["descriptionBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["chambreBien"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["imageBien"].ToString() + " | " + "\n";
            }
            return infos;
        }
    }
}
