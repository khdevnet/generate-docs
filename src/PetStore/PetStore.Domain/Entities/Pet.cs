namespace PetStore.Domain.Entities
{
    public class Pet
    {
        /// <remarks>
        /// Length: 0-256
        /// </remarks>
        public string? Name { get; set; }

        /// <remarks>
        /// Range: 1-20
        /// </summary>
        public int Age { get; set; }
    }
}
