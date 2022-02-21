using Microsoft.AspNetCore.Http;
using SecretaryWebMvc.Models.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class ActivitiesReportFormViewModel 
    {
        public ActivitiesReport ActivitiesReport { get; set; }

        public ICollection<Publisher> Publishers { get; set; }

        public ICollection<ActivitiesReport> ActivitiesReports { get; set; }

        public ICollection<Assistance> Assistances { get; set; }

    }

}
