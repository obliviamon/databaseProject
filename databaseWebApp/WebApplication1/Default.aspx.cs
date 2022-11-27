using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=Darkstorm96;Database=postgres";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            //TextBox1.Text = ($"PostgreSQL version: {version}");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=Darkstorm96;Database=postgres";

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM games";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                TextBox2.Text += rdr.GetString(7) + "\n";
            }
        }
    }
}