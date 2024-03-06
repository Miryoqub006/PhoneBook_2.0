using PhoneBook2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Brokers.Storages;

internal class FileStorageBroker : IFileStorageBroker
{
    private const string FilePath = @"C:\Users\Asus\Desktop\c#\PhoneBook2\Assests\Files.txt";
    public FileStorageBroker()
    {
        EnsureFileExist();   
    }

    public Data[] ReadAllDataFromFiles()
    {
        string[] warpdata = File.ReadAllLines(FilePath);
        int datalines = warpdata.Length;

        Data[] data = new Data[datalines];

        for(int i = 0; i <warpdata.Length; i++)
        {
            string datas = warpdata[i];
            string[] splits = datas.Split('*');
            Data data2 = new Data
            {
               Id = Convert.ToInt32( splits[0]),
               Name = splits[1],
               PhoneNumber = splits[2]
            };

            if (data[i] is null)
            {
                data[i] = data2;
            }
        }
        return data;

    }           
    public Data AddDataToFiles(Data data)
    {
        string datas = $"{data.Id}*{data.Name}*{data.PhoneNumber}\n";
        File.AppendAllText(FilePath, datas);
        return data;
    }
    private void EnsureFileExist()
    {
        bool exists = File.Exists(FilePath);
        if (!exists)
        {
            File.Create(@"C:\Users\Asus\Desktop\c#\PhoneBook2\Assests\Files.txt").Close();
        }
    }

     
    
    



}
