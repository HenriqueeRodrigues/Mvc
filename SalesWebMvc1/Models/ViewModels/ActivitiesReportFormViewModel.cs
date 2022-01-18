using Microsoft.AspNetCore.Http;
using SecretaryWebMvc.Models.Enums;
using System.Collections.Generic;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class ActivitiesReportFormViewModel 
    {
        public ActivitiesReport ActivitiesReport { get; set; }

        public ICollection<Publisher> Publishers { get; set; }


    }


}
