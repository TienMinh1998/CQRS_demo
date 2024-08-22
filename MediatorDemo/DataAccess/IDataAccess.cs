using MediatorDemo.Models;

namespace MediatorDemo.DataAccess
{
    public interface IDataAccess
    {
        PersonModel InsertPerson(string name, string lastname, string full_name, string first_name);
        List<PersonModel> GetPeople();
    }
}