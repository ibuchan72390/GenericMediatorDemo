namespace GenericMediatorDemo.Domain.Entities
{
    public class Person : IName
    {
        public string PersonKey { get; set; }

        public string Name { get; set; }
    }
}
