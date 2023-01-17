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
        Task AddNewCollectionData(SkipOn skipOn);
    }
}
