using System.Collections.Generic;
using System.ServiceModel;
using UserForms.Models;

namespace UserForms
{
    [ServiceContract]
    public interface IServiceChat
    {
        [OperationContract]
        List<Person> GetPersons();

        [OperationContract]
        List<Person> GeteSerchedPersons(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room);

        [OperationContract]
        void Create(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room);

        [OperationContract]
        void Update(string id, string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room);

        [OperationContract]
        void Detele(int id);
    }
}
