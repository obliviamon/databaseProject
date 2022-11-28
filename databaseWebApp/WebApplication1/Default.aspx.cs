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
            string sql = "";
                sql = "SELECT * FROM games";
                switch (RadioButtonList1.SelectedValue)
                {
                    case "Character":
                        sql += ", character, appears WHERE games.id = appears.gameid AND character.id = appears.characterid AND character.name = '" + TextBox1.Text + "';";
                        break;
                    case "Company":
                        sql += ", company, involvedwith WHERE games.id = involvedwith.gameid AND company.developed[1] = involvedwith.companyid AND company.name = '" + TextBox1.Text + "';";
                        break;
                    case "Franchise":
                        sql += ", franchise, consistsof WHERE games.id = consistsof.gameid AND franchise.id = consistsof.franchiseid AND franchise.name = '" + TextBox1.Text + "';";
                        break;
                    case "Games":
                        sql += " WHERE games.name = '" + TextBox1.Text + "';";
                        break;
                    case "Platform":
                        sql += ", platform WHERE games.platforms[1] = platform.id AND platform.name = '" + TextBox1.Text + "';";
                        break;
                    case "Release Date":
                        sql += ", releasedate, hasreleasedate WHERE games.id = hasreleasedate.gameid AND releasedate.id = hasreleasedate.releaseid AND releasedate.human = '" + TextBox1.Text + "';";
                        break;
                    default:
                        break;
                }
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
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Company":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Franchise":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Games":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Platform":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Release Date":
                        TextBox2.Text += rdr.GetString(7);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=Darkstorm96;Database=postgres";

            var con = new NpgsqlConnection(cs);
            con.Open();
            string sql = "SELECT * FROM games";
            switch (RadioButtonList1.SelectedValue)
            {
                case "Character":
                    sql += ", character, appears WHERE games.id = appears.gameid AND character.id = appears.characterid;";
                    break;
                case "Company":
                    sql += ", company, involvedwith WHERE games.id = involvedwith.gameid AND company.developed[1] = involvedwith.companyid;";
                    break;
                case "Franchise":
                    sql += ", franchise, consistsof WHERE games.id = consistsof.gameid AND franchise.id = consistsof.franchiseid;";
                    break;
                case "Games":
                    sql += ";";
                    break;
                case "Platform":
                    sql += ", platform WHERE games.platforms[1] = platform.id;";
                    break;
                case "Release Date":
                    sql += ", releasedate, hasreleasedate WHERE games.id = hasreleasedate.gameid AND releasedate.id = hasreleasedate.releaseid;";
                    break;
                default:
                    break;
            }
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
                        TextBox2.Text += rdr.GetString(7) + " - " + rdr.GetString(10);
                        break;
                    case "Company":
                        TextBox2.Text += rdr.GetString(7) + " - " + rdr.GetString(10);
                        break;
                    case "Franchise":
                        TextBox2.Text += rdr.GetString(7) + " - " + rdr.GetString(10);
                        break;
                    case "Games":
                        TextBox2.Text += rdr.GetString(7);
                        break;
                    case "Platform":
                        TextBox2.Text += rdr.GetString(7) + " - " + rdr.GetString(10);
                        break;
                    case "Release Date":
                        TextBox2.Text += rdr.GetString(7) + " - " + rdr.GetString(10);
                        break;
                    default:
                        break;
                }
                TextBox2.Text += "\n";
            }
            rdr.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
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
            string sql = "";
            sql = "SELECT * FROM " + currentTable + ";";
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
    }
}