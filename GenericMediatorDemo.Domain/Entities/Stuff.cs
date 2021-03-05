namespace GenericMediatorDemo.Domain.Entities
{
    public class Stuff : IName
    {
        public string StuffKey { get; set; }

        public string PersonKey { get; set; }

        public string Name { get; set; }
    }
}
