using Employee.DataModel.Models;
using EmployeeTrackingApp.Service;
using Microsoft.AspNetCore.Components;

namespace EmployeeTrackingApp.Pages
{
    public partial class POC
    {
       // List<ProofOfConcept> proofOfConcepts = new List<ProofOfConcept>();
        [Inject]
        public POCService pOCService { get; set; }

        public IEnumerable<ProofOfConcept> proofOfConcepts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            proofOfConcepts = (await pOCService.GetPOCDetails()).ToList();
        }
    }
}
