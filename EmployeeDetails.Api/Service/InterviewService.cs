using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Api.Service
{
    public class InterviewService : IInterviewService
    {
        private EtreportContext _context;
        public InterviewService(EtreportContext etreport)
        {
            this._context = etreport;
        }
        public async Task<List<Interviews>> GetInterviewDetails()
        {
            if (_context != null)
            {
                return await _context.Interviews.ToListAsync();
            }
            return null;
        }

        public async Task<int> PostInterview(Interviews interview)
        {
            if (_context != null)
            {
                await _context.Interviews.AddAsync(interview);
                await _context.SaveChangesAsync();
                return interview.Id;
            }
            return 0;
        }
    }
}
