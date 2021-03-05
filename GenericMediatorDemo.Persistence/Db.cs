using GenericMediatorDemo.Domain.Entities;
using System.Collections.Generic;

namespace GenericMediatorDemo.Persistence
{
    public static class Db
    {
        public static readonly IEnumerable<Person> Persons = new List<Person> 
        {
            new Person { PersonKey = "1", Name = "Ian" },
            new Person { PersonKey = "2", Name = "Casey" },
            new Person { PersonKey = "3", Name = "Richard" }
        };

        public static readonly IEnumerable<Thing> Things = new List<Thing> 
        {
            new Thing { ThingKey = "1", PersonKey = "1", Name = "Thing 1" },
            new Thing { ThingKey = "2", PersonKey = "1", Name = "Thing 2" },
            new Thing { ThingKey = "3", PersonKey = "1", Name = "Thing 3" },
            new Thing { ThingKey = "4", PersonKey = "2", Name = "Thing 4" },
            new Thing { ThingKey = "5", PersonKey = "2", Name = "Thing 5" },
            new Thing { ThingKey = "6", PersonKey = "2", Name = "Thing 6" },
            new Thing { ThingKey = "7", PersonKey = "3", Name = "Thing 7" },
            new Thing { ThingKey = "8", PersonKey = "3", Name = "Thing 8" },
            new Thing { ThingKey = "9", PersonKey = "3", Name = "Thing 9" },
        };

        public static readonly IEnumerable<Stuff> Stuffs = new List<Stuff> 
        {
            new Stuff { StuffKey = "1", PersonKey = "1", Name = "Stuff 1" },
            new Stuff { StuffKey = "2", PersonKey = "2", Name = "Stuff 2" },
            new Stuff { StuffKey = "3", PersonKey = "3", Name = "Stuff 3" },
            new Stuff { StuffKey = "4", PersonKey = "1", Name = "Stuff 4" },
            new Stuff { StuffKey = "5", PersonKey = "2", Name = "Stuff 5" },
            new Stuff { StuffKey = "6", PersonKey = "3", Name = "Stuff 6" },
            new Stuff { StuffKey = "7", PersonKey = "1", Name = "Stuff 7" },
            new Stuff { StuffKey = "8", PersonKey = "2", Name = "Stuff 8" },
            new Stuff { StuffKey = "9", PersonKey = "3", Name = "Stuff 9" },
        };
    }
}
