using PhoneBook2.Brokers.Storages;
using PhoneBook2.Models;
using PhoneBook2.Models.Services.Contacts;

namespace PhoneBook2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactServices broker = new ContactServices();
            Data data = new Data()
            {
                Id = 1,
                Name = "Test",
                PhoneNumber = "1234567890",
            };

            broker.AddDataToService(data);

            broker.ViewDatas();
                

        }
    }
}

