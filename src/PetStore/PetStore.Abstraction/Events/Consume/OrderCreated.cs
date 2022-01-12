namespace PetStore.Abstraction.Events.Consume
{
    public class OrderCreated
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string Summary { get; set; }
    }
}