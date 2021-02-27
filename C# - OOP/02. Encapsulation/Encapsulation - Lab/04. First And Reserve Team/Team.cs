using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        private string name;

        public Team(string name)
        {
            Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();

        }

        public string Name { get; set; }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get => firstTeam.AsReadOnly();
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get => reserveTeam.AsReadOnly();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}