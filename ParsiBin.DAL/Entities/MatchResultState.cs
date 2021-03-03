using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class MatchResultState : BaseEntity
    {
        public MatchResult MatchResult { get; set; }
        public double HomeTeam_Possession { get; set; }
        public double AwayTeam_Possession { get; set; }
        public int HomeTeam_Total_Shots { get; set; }
        public int AwayTeam_Total_Shots { get; set; }
        public int HomeTeam_On_Target_Shots { get; set; }
        public int AwayTeam_On_Target_Shots { get; set; }
        public int HomeTeam_Of_Target_Shots { get; set; }
        public int AwayTeam_Of_Target_Shots { get; set; }
        public int HomeTeam_Blocked_Shots { get; set; }
        public int AwayTeam_Blocked_Shots { get; set; }
        public int HomeTeam_Passes { get; set; }
        public int AwayTeam_Passes { get; set; }
        public double HomeTeam_Passing_Percentage { get; set; }
        public double AwayTeam_Passing_Percentage { get; set; }
        public int HomeTeam_Clear_Cut_Chances { get; set; }
        public int AwayTeam_Clear_Cut_Chances { get; set; }
        public int HomeTeam_Corners { get; set; }
        public int AwayTeam_Corners { get; set; }
        public int HomeTeam_Offsides { get; set; }
        public int AwayTeam_Offsides { get; set; }
        public double HomeTeam_Tackles_Percentage { get; set; }
        public double AwayTeam_Tackles_Percentage { get; set; }
        public double HomeTeam_Aerial_Duels_Percentage { get; set; }
        public double AwayTeam_Aerial_Duels_Percentage { get; set; }
        public int HomeTeam_Saves { get; set; }
        public int AwayTeam_Saves { get; set; }
        public int HomeTeam_Fouls_Committed { get; set; }
        public int AwayTeam_Fouls_Committed { get; set; }
        public int HomeTeam_Fouls_Won { get; set; }
        public int AwayTeam_Fouls_Won { get; set; }
        public int HomeTeam_Yellow_Cards { get; set; }
        public int AwayTeam_Yellow_Cards { get; set; }
        public int HomeTeam_Red_Cards { get; set; }
        public int AwayTeam_Red_Cards { get; set; }
        public int HomeTeam_Touches { get; set; }
        public int AwayTeam_Touches { get; set; }
    }
}
