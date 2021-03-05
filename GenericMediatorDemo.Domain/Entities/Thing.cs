namespace GenericMediatorDemo.Domain.Entities
{
    public class Thing : IName
    {
        public string ThingKey { get; set; }

        public string PersonKey { get; set; }

        public string Name { get; set; }
    }
}
