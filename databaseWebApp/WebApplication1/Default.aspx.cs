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
        string currentTable = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            var cs = "Host=localhost;Username=postgres;Password=Darkstorm96;Database=postgres";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            TextBox1.Text = ($"PostgreSQL version: {version}");
            */
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            switch (RadioButtonList1.SelectedValue)
            {
                case "Character":
                    currentTable = "character";
                    break;
                case "Company":
                    currentTable = "company";
                    break;
                case "Franchise":
                    currentTable = "franchise";
                    break;
                case "Games":
                    currentTable = "games";
                    break;
                case "Platform":
                    currentTable = "platform";
                    break;
                case "Release Date":
                    currentTable = "releasedate";
                    break;
                default:
                    break;
            }
            var cs = "Host=localhost;Username=postgres;Password=Darkstorm96;Database=postgres";

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM " + currentTable + ";";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            TextBox2.Text = "";
            while (rdr.Read())
            {
                //id, genres, game_engines, franchise, age_ratings, platforms, release_dates, name, involved_companies
                TextBox2.Text += rdr.GetInt32(0) + " - ";
                switch (RadioButtonList1.SelectedValue)
                {
                    case "Character":
                        TextBox2.Text += rdr.GetString(1);
                        break;
                    case "Company":
                        TextBox2.Text += rdr.GetString(1);
                        break;
                    case "Franchise":
                        TextBox2.Text += rdr.GetString(1);
                        break;
                    case "Games":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Platform":
                        TextBox2.Text += rdr.GetString(1);
                        break;
                    case "Release Date":
                        TextBox2.Text += rdr.GetString(1);
                        break;
                    default:
                        break;
                }
                TextBox2.Text += "\n";
            }
            rdr.Close();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            
        }
    }
}