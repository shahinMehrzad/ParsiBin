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
using Microsoft.ML;

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

            #region Results
            //doc.Load("../../../premier league.html");
            //var myNodes = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'fixres__item')]/a");
            //foreach (HtmlNode node in myNodes)
            //{
            //    var url = node.Attributes[0].Value;
            //    var xLenght = url.Length;
            //    url = url.Substring(0, xLenght - 6) + "stats/" + url.Substring(xLenght - 6, 6);
            //    doc = web.Load(url);

            //    var matchtime = doc.DocumentNode.SelectNodes("//script[starts-with(@type,'application/ld+json')]");
            //    var des = JsonConvert.DeserializeObject<match>(matchtime[0].InnerText);
            //    var matchId =  AddMatch(des);
            //    var teamsdiv = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'sdc-site-match-header__teams')]/h4/span[starts-with(@class,'sdc-site-match-header__team-score')]");
            //    var homeGoal = int.Parse(teamsdiv[0].InnerText);
            //    var awayGoal = int.Parse(teamsdiv[1].InnerText);
            //    var matchresultId = AddMatchResult(matchId, homeGoal, awayGoal);
            //    var statisticdiv = doc.DocumentNode.SelectNodes("//div[starts-with(@class,'sdc-site-match-stats__inner')]/div[starts-with(@class,'sdc-site-match-stats__stats')]");
            //    MatchStatistics matchStatistics = new MatchStatistics();
            //    matchStatistics.MatchResultId = matchresultId;
            //    //Possession
            //    matchStatistics.HomeTeam_Possession = double.Parse(statisticdiv[0].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Possession = double.Parse(statisticdiv[0].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Total_Shots
            //    matchStatistics.HomeTeam_Total_Shots = int.Parse(statisticdiv[1].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Total_Shots = int.Parse(statisticdiv[1].ChildNodes[3].ChildNodes[3].InnerText);
            //    //On_Target_Shots
            //    matchStatistics.HomeTeam_On_Target_Shots = int.Parse(statisticdiv[2].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_On_Target_Shots = int.Parse(statisticdiv[2].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Of_Target_Shots
            //    matchStatistics.HomeTeam_Of_Target_Shots = int.Parse(statisticdiv[3].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Of_Target_Shots = int.Parse(statisticdiv[3].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Blocked_Shots
            //    matchStatistics.HomeTeam_Blocked_Shots = int.Parse(statisticdiv[4].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Blocked_Shots = int.Parse(statisticdiv[4].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Passing_Percentage
            //    matchStatistics.HomeTeam_Passing_Percentage = double.Parse(statisticdiv[5].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Passing_Percentage = double.Parse(statisticdiv[5].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Clear_Cut_Chances
            //    matchStatistics.HomeTeam_Clear_Cut_Chances = int.Parse(statisticdiv[6].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Clear_Cut_Chances = int.Parse(statisticdiv[6].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Corners
            //    matchStatistics.HomeTeam_Corners = int.Parse(statisticdiv[7].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Corners = int.Parse(statisticdiv[7].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Offsides
            //    matchStatistics.HomeTeam_Offsides = int.Parse(statisticdiv[8].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Offsides = int.Parse(statisticdiv[8].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Tackles_Percentage
            //    matchStatistics.HomeTeam_Tackles_Percentage = double.Parse(statisticdiv[9].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Tackles_Percentage = double.Parse(statisticdiv[9].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Aerial_Duels_Percentage
            //    matchStatistics.HomeTeam_Aerial_Duels_Percentage = double.Parse(statisticdiv[10].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Aerial_Duels_Percentage = double.Parse(statisticdiv[10].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Saves
            //    matchStatistics.HomeTeam_Saves = int.Parse(statisticdiv[11].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Saves = int.Parse(statisticdiv[11].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Fouls_Committed
            //    matchStatistics.HomeTeam_Fouls_Committed = int.Parse(statisticdiv[12].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Fouls_Committed = int.Parse(statisticdiv[12].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Fouls_Won
            //    matchStatistics.HomeTeam_Fouls_Won = int.Parse(statisticdiv[13].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Fouls_Won = int.Parse(statisticdiv[13].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Yellow_Cards
            //    matchStatistics.HomeTeam_Yellow_Cards = int.Parse(statisticdiv[14].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Yellow_Cards = int.Parse(statisticdiv[14].ChildNodes[3].ChildNodes[3].InnerText);
            //    //Red_Cards
            //    matchStatistics.HomeTeam_Red_Cards = int.Parse(statisticdiv[15].ChildNodes[1].ChildNodes[3].InnerText);
            //    matchStatistics.AwayTeam_Red_Cards = int.Parse(statisticdiv[15].ChildNodes[3].ChildNodes[3].InnerText);
            //    AddMatchState(matchStatistics);
            //}
            ////Console.WriteLine("Hello World!");
            #endregion

            MLContext mlContext = new MLContext(seed: 0);


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

        static int AddMatchResult(int MatchId, int HomeGoal, int AwayGoal)
        {
            string queryString = "Insert Into MatchResult (MatchId, HomeGoal, AwayGoal, CreateDate, Status) "
                    + " VALUES (" + MatchId + "," + HomeGoal + "," + AwayGoal + ",'" + DateTime.Now + "',1) SELECT CAST(scope_identity() AS int)";

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

        static void AddMatchState(MatchStatistics model)
        {
            string queryString = "Insert Into MatchResultState (MatchResultId, HomeTeam_Possession, AwayTeam_Possession, HomeTeam_Total_Shots, AwayTeam_Total_Shots," +
                "HomeTeam_On_Target_Shots, AwayTeam_On_Target_Shots, HomeTeam_Of_Target_Shots, AwayTeam_Of_Target_Shots, HomeTeam_Blocked_Shots, AwayTeam_Blocked_Shots," +
                "HomeTeam_Passes, AwayTeam_Passes, HomeTeam_Passing_Percentage, AwayTeam_Passing_Percentage, HomeTeam_Clear_Cut_Chances, AwayTeam_Clear_Cut_Chances, " +
                "HomeTeam_Corners, AwayTeam_Corners, HomeTeam_Offsides, AwayTeam_Offsides, HomeTeam_Tackles_Percentage, AwayTeam_Tackles_Percentage, HomeTeam_Aerial_Duels_Percentage, AwayTeam_Aerial_Duels_Percentage," +
                "HomeTeam_Saves, AwayTeam_Saves, HomeTeam_Fouls_Committed, AwayTeam_Fouls_Committed, HomeTeam_Fouls_Won, AwayTeam_Fouls_Won, HomeTeam_Yellow_Cards, AwayTeam_Yellow_Cards," +
                "HomeTeam_Red_Cards, AwayTeam_Red_Cards, HomeTeam_Touches, AwayTeam_Touches, CreateDate, Status) "
                    + " VALUES (" + model.MatchResultId + "," + model.HomeTeam_Possession + "," + model.AwayTeam_Possession + "," + model.HomeTeam_Total_Shots + "," + model.AwayTeam_Total_Shots + "," +
                    model.HomeTeam_On_Target_Shots + "," + model.AwayTeam_On_Target_Shots + "," + model.HomeTeam_Of_Target_Shots + "," + model.AwayTeam_Of_Target_Shots + "," + model.HomeTeam_Blocked_Shots + "," + model.AwayTeam_Blocked_Shots + "," +
                    model.HomeTeam_Passes + "," + model.AwayTeam_Passes + "," + model.HomeTeam_Passing_Percentage + "," + model.AwayTeam_Passing_Percentage + "," + model.HomeTeam_Clear_Cut_Chances + "," + model.AwayTeam_Clear_Cut_Chances  + "," +
                    model.HomeTeam_Corners + "," + model.AwayTeam_Corners + "," + model.HomeTeam_Offsides + ","  + model.AwayTeam_Offsides + "," + model.HomeTeam_Tackles_Percentage + ","  + model.AwayTeam_Tackles_Percentage + ","  + model.HomeTeam_Aerial_Duels_Percentage + ","  + model.AwayTeam_Aerial_Duels_Percentage + ","  +
                    model.HomeTeam_Saves + ","  + model.AwayTeam_Saves + ","  + model.HomeTeam_Fouls_Committed + "," + model.AwayTeam_Fouls_Committed + "," + model.HomeTeam_Fouls_Won + ","  + model.AwayTeam_Fouls_Won + ","  + model.HomeTeam_Yellow_Cards + "," +  model.AwayTeam_Yellow_Cards + "," +
                    model.HomeTeam_Red_Cards + "," + model.AwayTeam_Red_Cards +  "," + model.HomeTeam_Touches + "," + model.AwayTeam_Touches + ",'" + DateTime.Now + "',1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        #region Player,Country
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
        #endregion

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
