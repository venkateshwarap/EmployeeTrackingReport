using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Api.Service
{
    public class DashboardService : IDashboardService
    {

        private EtreportContext _dBContext;
        public DashboardService(EtreportContext etreport)
        {
            this._dBContext = etreport;
        }
        public async Task<List<Employees>> GetEmployeeDetails()
        {

            if (_dBContext != null)
            {
                return await _dBContext.Employees.ToListAsync();
            }
            return null;
        }
    }
}
