using BIWEBAPI.DataContracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIWEBAPI.DataContracts.Repositories
{
    public  interface ISkipRepository
    {
        Task<List<SkipOn>> GetAlldetails();
        Task<SkipOn>GetDetailById(string id);   
        Task AddNewCollectionData(SkipOn skipOn);
        Task UpDateSkipOn(string id,SkipOn skipOn);
        Task<bool> DeleteSkipOnById(string id);   
        
    }
}
