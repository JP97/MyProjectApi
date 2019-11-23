using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class DbInitialize
    {
        public static void Initialize(MyProjectContext context)
        {
            context.Database.EnsureCreated();
            var team1 = new List<Player>();
            var team2 = new List<Player>();
            var team3 = new List<Player>();
            var team4 = new List<Player>();

            List<Player> playersList = new List<Player>()
            {
                new Player{Name="bob"},
                new Player{Name="jens"},
                new Player{Name="malene"},
                new Player{Name="Hans"},
                new Player{Name="Günther"},
                new Player{Name="Manfred"},
                new Player{Name="Gertrud"},
                new Player{Name="Walter"},
                new Player{Name="Wolfgang"},
                new Player{Name="Joachim"},
                new Player{Name="Frank"},
                new Player{Name="Jens"},
                new Player{Name="Mia"},
                new Player{Name="Julian"},
                new Player{Name="bobo"},
                new Player{Name="babo"}
            };

            context.AddRange(playersList);


            for (int i = 0; i < 4; i++)
            {
                team1.Add(playersList[i]);
            }

            for (int i = 4; i < 8; i++)
            {
                team2.Add(playersList[i]);
            }
            for (int i = 8; i < 12; i++)
            {
                team3.Add(playersList[i]);
            }
            for (int i = 12; i < 16; i++)
            {
                team4.Add(playersList[i]);
            }

            context.SaveChanges();

            context.AddRange(
                new Team
                {
                    TeamName = "holeinone",
                    players = team1
                },

                new Team
                {
                    TeamName = "strikeZero",
                    players = team2
                },

                new Team
                {
                    TeamName = "DarkenssIncoming",
                    players = team3
                },

                new Team
                {
                    TeamName = "LightShade",
                    players = team4
                }
                );
            context.SaveChanges();
        }
    }
}
