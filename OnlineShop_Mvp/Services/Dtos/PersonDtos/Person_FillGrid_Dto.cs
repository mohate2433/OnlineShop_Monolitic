namespace OnlineShop_Mvp.Services.Dtos.PersonDtos
{
    public class Person_FillGrid_Dto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get
            {
                return String.Format(LastName + " " + FirstName);
            } 
        }
    }
}
