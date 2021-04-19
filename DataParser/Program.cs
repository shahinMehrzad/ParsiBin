using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using ParsiBin.Services.Contracts;
using ParsiBin.Services.Implements;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.DAL.Context;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace DataParser
{
    public class Program
    {
        static string connectionString = @"Server=DESKTOP-V0T1R5F\SQLEXPRESS;Initial Catalog=ParsiBin;Integrated Security=True;";

        static void Main(string[] args)
        {
            HtmlDocument doc = new HtmlDocument();
            HtmlWeb web = new HtmlWeb();
            #region Players
            //doc.Load("../../../players.html");
            //var myNodes = doc.DocumentNode.SelectNodes("//tr");
            //int counter = 1;
            //foreach (HtmlNode node in myNodes)
            //{
            //    var url = node.ChildNodes[0].FirstChild.Attributes[0].Value;
            //    var player = new player();
            //    player.name = node.ChildNodes[0].FirstChild.InnerText;
            //    int PlayerPosition = GetPlayerPosition(node.ChildNodes[1].InnerText);
            //    var countryId = GetCountry(node.ChildNodes[2].ChildNodes[3].InnerText);
            //    if (countryId == 0)
            //    {
            //        countryId = AddCountry(node.ChildNodes[2].ChildNodes[3].InnerText);
            //    }                
            //        player.NationalityId = countryId;

            //    doc = web.Load("https:" + url);
            //    var playerNumber = "0";
            //    try
            //    {
            //        playerNumber = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'number t-colour')]").FirstOrDefault().InnerText;
            //    }
            //    catch
            //    {                    
            //    }
            //    try
            //    {
            //        var birthvalue = doc.DocumentNode.SelectNodes("//ul[starts-with(@class, 'pdcol2')]/li/div[starts-with(@class, 'info')]").FirstOrDefault().ChildNodes[0].InnerText.Split('/');
            //        player.BirthDate = Convert.ToDateTime(birthvalue[2] + "-" + birthvalue[1] + "-" + birthvalue[0]);
            //    }
            //    catch
            //    {
            //        player.BirthDate = DateTime.Now.AddYears(-20);
            //    }


            //    var playerId = AddPlayer(player);
            //    AddPlayerPosition(playerId, PlayerPosition);
            //    var teamId = GetTeamId(doc.DocumentNode.SelectNodes("//section[starts-with(@class,'sideWidget playerIntro')]").First().SelectNodes("//div[starts-with(@class, 'info')]/a").First().ChildNodes[0].InnerText.Trim());
            //    AddPlayerToTeam(teamId, playerId, int.Parse(playerNumber));
            //}
            #endregion



            doc.Load("../../../premier league.html");
            var myNodes = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'fixres__item')]/a");
            foreach (HtmlNode node in myNodes)
            {
                var url = node.Attributes[0].Value;
                var xLenght = url.Length;
                url = url.Substring(0, xLenght - 6) + "stats/" + url.Substring(xLenght - 6, 6);
                doc = web.Load(url);

                var matchtime = doc.DocumentNode.SelectNodes("//script[starts-with(@type,'application/ld+json')]");
                var des = JsonConvert.DeserializeObject<match>(matchtime[0].InnerText);
                //var matchId =  AddMatch(des);
                var teamsdiv = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'sdc-site-match-header__teams')]/h4/span[starts-with(@class,'sdc-site-match-header__team-score')]");
                var homeGoal = int.Parse(teamsdiv[0].InnerText);
                var awayGoal = int.Parse(teamsdiv[1].InnerText);
            }
            //Console.WriteLine("Hello World!");

        }

        static int AddMatch(match des)
        {
            string queryString = "Insert Into Match (LeagueId, SeasonId, StadiumId, HomeTeamId, AwayTeamId, Week, MatchDate, MatchStatus, CreateDate, Status) "
                    + " VALUES (1,1," + des.location.Id + "," + des.homeTeam.teamId + "," + des.awayTeam.teamId + ",1,'" + des.startDate + "',1,'" + DateTime.Now + "',1) SELECT CAST(scope_identity() AS int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var x = (int)command.ExecuteScalar();
                    System.Threading.Thread.Sleep(350);
                    return x;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;

        }

        static int AddCountry(string Country)
        {
            string queryString = "Insert Into Country (Name, CreateDate, Status) "
                    + " VALUES ('" + Country + "','" + DateTime.Now + "',1) SELECT CAST(scope_identity() AS int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var x = (int)command.ExecuteScalar();
                    System.Threading.Thread.Sleep(350);
                    return x;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        static int GetCountry(string Country)
        {
            string queryString = "select Id from Country where Name = '" + Country + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());                        
                    }
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return 0;
        }

        static int AddPlayer(player model)
        {
            string queryString = "Insert Into Player (Name, BirthDate, NationalityId, CreateDate, Status) "
                    + " VALUES ('" + model.name + "','" + model.BirthDate + "'," + model.NationalityId + ",'" + DateTime.Now + "',1) SELECT CAST(scope_identity() AS int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var x = (int)command.ExecuteScalar();
                    System.Threading.Thread.Sleep(350);
                    return x;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        static void AddPlayerToTeam(int TeamId, int PlayerId, int ShirtNumber)
        {
            string queryString = "Insert Into TeamPlayers (TeamId, PlayerId, JoinDate, ShirtNumber, Status) "
                    + " VALUES (" + TeamId + "," + PlayerId + ",'" + DateTime.Now.AddYears(-1) + "'," + ShirtNumber + ",1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    System.Threading.Thread.Sleep(350);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void AddPlayerPosition(int playerid, int PositionId)
        {
            string queryString = "Insert Into PlayerPositions (PlayerId, PositionId) "
                    + " VALUES (" + playerid + "," + PositionId + ")";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    System.Threading.Thread.Sleep(350);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static int GetPlayerPosition(string Position)
        {
            switch (Position)
            {
                case ("Goalkeeper"):
                    return 1;
                case ("Defender"):
                    return 2;
                case ("Midfielder"):
                    return 3;
                case ("Forward"):
                    return 4;
                default:
                    return 0;
            }
        }

        static int GetTeamId(string Team)
        {
            switch (Team)
            {
                case ("Arsenal"):
                    return 1;
                case ("Aston Villa"):
                    return 2;
                case ("Brighton and Hove Albion"):
                    return 3;
                case ("Burnley"):
                    return 4;
                case ("Chelsea"):
                    return 5;
                case ("Crystal Palace"):
                    return 6;
                case ("Everton"):
                    return 7;
                case ("Fulham"):
                    return 8;
                case ("Leeds United"):
                    return 9;
                case ("Leicester City"):
                    return 10;
                case ("Liverpool"):
                    return 11;
                case ("Manchester City"):
                    return 12;
                case ("Manchester United"):
                    return 13;
                case ("Newcastle United"):
                    return 14;
                case ("Sheffield United"):
                    return 15;
                case ("Southampton"):
                    return 16;
                case ("Tottenham Hotspur"):
                    return 17;
                case ("West Bromwich Albion"):
                    return 18;
                case ("West Ham United"):
                    return 19;
                case ("Wolverhampton Wanderers"):
                    return 20;
                default:
                    return 0;
            }
        }

    }
}
