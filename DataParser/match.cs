using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    internal class match
    {
        public TeamModel homeTeam { get; set; }
        public TeamModel awayTeam { get; set; }
        public DateTime startDate { get; set; }
        public location location { get; set; }
    }


    internal class location
    {
        public string name { get; set; }
        public int Id
        {
            get
            {
                switch (name)
                {
                    case ("Anfield"):
                        return 1;
                    case ("Bramall Lane"):
                        return 2;
                    case ("Craven Cottage"):
                        return 3;
                    case ("Elland Road"):
                        return 4;
                    case ("Falmer Stadium"):
                        return 5;
                    case ("Goodison Park"):
                        return 6;
                    case ("King Power Stadium"):
                        return 7;
                    case ("London Stadium"):
                        return 8;
                    case ("Molineux"):
                        return 9;
                    case ("Old Trafford"):
                        return 10;
                    case ("Selhurst Park"):
                        return 11;
                    case ("St James' Park"):
                        return 12;
                    case ("St Mary’s"):
                        return 13;
                    case ("Stamford Bridge"):
                        return 14;
                    case ("The Emirates"):
                        return 15;
                    case ("The Etihad"):
                        return 16;
                    case ("The Hawthorns"):
                        return 17;
                    case ("Tottenham Hotspur Stadium"):
                        return 18;
                    case ("Turf Moor"):
                        return 19;
                    case ("Villa Park"):
                        return 20;
                    default:
                        return 0;
                }
            }
        }
    }

    internal class TeamModel
    {
        public string name { get; set; }
        public int teamId
        {
            get
            {
                switch (name)
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
}
