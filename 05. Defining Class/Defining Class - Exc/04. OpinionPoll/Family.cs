using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class Family
    {

        public Family()
        {
                this.Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public void GetOldestMember()

        {
            foreach (var member in Members.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
