using PhoneBook2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Brokers.Storages;

internal interface IFileStorageBroker
{
    Data AddDataToFiles(Data data);

    Data[] ReadAllDataFromFiles();  



}
