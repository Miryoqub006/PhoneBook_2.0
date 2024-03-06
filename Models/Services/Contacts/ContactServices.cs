using PhoneBook2.Brokers.Loggins;
using PhoneBook2.Brokers.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Models.Services.Contacts;

internal class ContactServices : IContactServices
{

    IFileStorageBroker fileStorageBroker;
    ILoggingBroker loggingBroker;


    public ContactServices()
    {
        fileStorageBroker = new FileStorageBroker();
        loggingBroker = new LoggingBroker();
    }

    public void ViewDatas()
    {
        Data[] data = this.fileStorageBroker.ReadAllDataFromFiles();

        for(int i = 0; i < data.Length; i++)
        {
            this.loggingBroker.LoginInformation($"{data[i].Id} {data[i].Name} {data[i].PhoneNumber}");
        }

        this.loggingBroker.LoginInformation("Datas ends ");

    }

    public Data AddDataToService(Data data)
    {

        if (data == null)
        {
            this.loggingBroker.LogWarning("Datas empty");
        }
        else
        {
            fileStorageBroker.AddDataToFiles(data);

        } 
            return data;

        

    }

    public void DeleteDataFromServiceById(int id)
    {
        string[] warpdata = File.ReadAllLines(@"C:\Users\Asus\Desktop\c#\PhoneBook2\Assests\Files.txt");
        int datalines = warpdata.Length;

        Data[] data = new Data[datalines];

        for (int i = 0; i < warpdata.Length; i++)
        {
            string datas = warpdata[i];
            string[] splits = datas.Split('*');
            Data data2 = new Data
            {
                Id = Convert.ToInt32(splits[0]),
                Name = splits[1],
                PhoneNumber = splits[2]
            };

            if (data[i] is null)
            {
                data[i] = data2;
            }
        }
         for (int i = 0; i < data.Length; i++)
         {
            if (data[i].Id == id)
            {
                data[i] = null;
            }
         }

    }

    public void DeleteAllDataFromService(Data data)
    {
        data = null;
    }
   



}
