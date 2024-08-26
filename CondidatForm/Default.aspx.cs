using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CondidatForm
{
    public partial class _Default : Page
    {
        public class Item
        {
            public string ID { get; set; }
            public string Name { get; set; }

        }

        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private object dateNaissance;

        public List<Item> Regions { get; set; } = new List<Item>();
        public List<Item> Villes { get; set; } = new List<Item>();
        public List<Item> Communes { get; set; } = new List<Item>();

        public List<string> Ids { get; set; } = new List<string>();

        protected void submit(object sender, EventArgs e)
        {
            var result = new List<string>();

            string Sources = string.Empty;

            if (source1.Checked)
            {
                result.Add(source1.Text);
            }

            if (source2.Checked)
            {
                result.Add(source2.Text);
            }

            if (source3.Checked)
            {
                result.Add(source3.Text);
            }



            Sources = string.Join(", ", result);

            string conid = cond_id.Text;

            string queryId = "SELECT CondidatId FROM condidat WHERE CondidatId=@CondidatId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryId, conn))
                {
                    cmd.Parameters.AddWithValue("@CondidatId", conid);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Ids.Clear();

                        while (reader.Read())
                        {

                            string id = reader.GetString(reader.GetOrdinal("CondidatId"));

                            Ids.Add(id);
                        }


                    }
                    conn.Close();
                }
            }


            if (!Ids.Any())
            {
                string query = "INSERT INTO condidat (CondidatId, Nom, Prenom, DateNaissance, Email, Phone, Adresse, sexe, Situation, Sources, RegionId, VilleId, CommuneId) " +
               "VALUES (@CondidatId, @Nom, @Prenom, @DateNaissance, @Email, @Phone, @Adresse, @sexe, @Situation, @Sources, @RegionId, @VilleId, @CommuneId)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.Add("@CondidatId", SqlDbType.VarChar, 50).Value = cond_id.Text;
                        cmd.Parameters.Add("@Nom", SqlDbType.VarChar, 50).Value = nom.Text;
                        cmd.Parameters.Add("@Prenom", SqlDbType.VarChar, 50).Value = prenom.Text;
                        cmd.Parameters.Add("@DateNaissance", SqlDbType.DateTime).Value = DateTime.Parse(date_naissance.Text); ;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email.Text;
                        cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = phone.Text;
                        cmd.Parameters.Add("@Adresse", SqlDbType.VarChar, 100).Value = adresse.Text;
                        cmd.Parameters.Add("@sexe", SqlDbType.VarChar, 20).Value = sexe.Text;
                        cmd.Parameters.Add("@Situation", SqlDbType.VarChar, 20).Value = Situation.Text;
                        cmd.Parameters.Add("@Sources", SqlDbType.VarChar, 50).Value = Sources;
                        cmd.Parameters.Add("@RegionId", SqlDbType.VarChar, 50).Value = Region.SelectedValue;
                        cmd.Parameters.Add("@VilleId", SqlDbType.VarChar, 50).Value = Ville.SelectedValue;
                        cmd.Parameters.Add("@CommuneId", SqlDbType.VarChar, 50).Value = Commune.SelectedValue;


                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                Response.Redirect("/afficheCond");


            }


            else
            {
                string script = "alert('This ID already exists.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alertScript", script, true);
            }



        }


        protected void Page_load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



                string queryR = "SELECT * FROM Region";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(queryR, conn))
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            Region.Items.Clear();

                            Region.Items.Insert(0, new ListItem("--Select Region--", ""));
                            while (reader.Read())
                            {

                                string id = reader.GetString(reader.GetOrdinal("RegionId"));
                                string name = reader.GetString(reader.GetOrdinal("Nom"));
                                Region.Items.Add(new ListItem(name, id));
                            }
                        }

                        conn.Close();
                    }
                }
            }
        }

        protected void Ville_Liste(object sender, EventArgs e)
        {
            string regionId = Region.SelectedValue;
            string queryV = "SELECT VilleId, Nom FROM Ville WHERE RegionId = @RegionId";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryV, conn))
                {
                    cmd.Parameters.AddWithValue("@RegionId", regionId);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Ville.Items.Clear();
                        Ville.Items.Insert(0, new ListItem("--Select Ville--", ""));

                        while (reader.Read())
                        {
                            string id = reader.GetString(reader.GetOrdinal("VilleId"));
                            string name = reader.GetString(reader.GetOrdinal("Nom"));

                            Ville.Items.Add(new ListItem(name, id));
                        }
                    }

                    conn.Close();
                }
            }

        }



        protected void Commune_Liste(object sender, EventArgs e)
        {
            string villeId = Ville.SelectedValue;
            string queryC = "SELECT CommuneId, Nom FROM Commune WHERE VilleId = @VilleId";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryC, conn))
                {
                    cmd.Parameters.AddWithValue("@VilleId", villeId);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Commune.Items.Clear();
                        Commune.Items.Insert(0, new ListItem("--Select Commune--", ""));

                        while (reader.Read())
                        {
                            string id = reader.GetString(reader.GetOrdinal("CommuneId"));
                            string name = reader.GetString(reader.GetOrdinal("Nom"));

                            Commune.Items.Add(new ListItem(name, id));
                        }
                    }

                    conn.Close();
                }
            }

        }
    }
}