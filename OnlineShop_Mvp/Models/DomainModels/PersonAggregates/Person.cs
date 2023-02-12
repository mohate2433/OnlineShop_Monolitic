namespace OnlineShop_Mvp.Models.DomainModels.PersonAggregates
{
    public class Person
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsRemoved { get; set; } = false;
        public string? FullName
        {
            get
            {
                return String.Format(LastName + " " + FirstName);
            }
        }
    }
}
