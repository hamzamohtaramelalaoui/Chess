using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CondidatForm
{
    public partial class AfficheCond : System.Web.UI.Page
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string query = @"SELECT C.CondidatId, C.Nom, C.Prenom, C.DateNaissance, C.Email, C.Phone, C.Adresse, C.sexe, C.Situation, C.Sources, R.Nom AS RegionName, V.Nom AS VilleName, K.Nom AS CommuneName FROM condidat AS C
    LEFT JOIN 
        Region AS R ON C.RegionId = R.RegionId
    LEFT JOIN 
        Ville AS V ON C.VilleId = V.VilleId
    LEFT JOIN 
        Commune AS K ON C.CommuneId = K.CommuneId
";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    Cond.DataSource = ds;
                    Cond.DataBind();
                }
            }

        }
    }
}