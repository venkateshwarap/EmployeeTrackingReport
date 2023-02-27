using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Api.Service
{
    public class POCService : IPOCService
    {
        private EtreportContext _dBContext;
        public POCService(EtreportContext etreport)
        {
            this._dBContext = etreport;
        }
        public async Task<List<ProofOfConcept>> GetPOCDetails()
        {
            if (_dBContext != null)
            {
                return  await _dBContext.ProofOfConcepts.ToListAsync();
            }
            return null;
        }


        public async Task<int> PostPOC(ProofOfConcept poc)
        {
            if (_dBContext != null)
            {

                await _dBContext.ProofOfConcepts.AddAsync(poc);
                await _dBContext.SaveChangesAsync();
                return poc.Id;
            }
             return 0;
        }
    }
}
