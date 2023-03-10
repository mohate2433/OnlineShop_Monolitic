using OnlineShop_Mvp.Models.DomainModels.PersonAggregates;

namespace OnlineShop_Mvp.Models.Services.Contracts
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Guid id);
        Person GetPerson(Guid id);

    }
}
