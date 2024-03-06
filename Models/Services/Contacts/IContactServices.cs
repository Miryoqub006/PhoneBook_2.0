using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Models.Services.Contacts;

internal interface IContactServices
{
   public Data AddDataToService(Data data);
   public void ViewDatas();
   public void DeleteDataFromServiceById(int id);
   public void DeleteAllDataFromService(Data data);


    


}
