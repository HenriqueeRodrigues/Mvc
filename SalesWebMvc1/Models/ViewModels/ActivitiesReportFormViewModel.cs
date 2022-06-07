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


        public string Month(int month)
        {
            var result = string.Empty;

            switch (month)
            {
                case 1:
                    result = "Janeiro";
                    break;
                case 2:
                    result = "Fevereiro";
                    break;
                case 3:
                    result = "Março";
                    break;
                case 4:
                    result = "Abril";
                    break;
                case 5:
                    result = "Maio";
                    break;
                case 6:
                    result = "Junho";
                    break;
                case 7:
                    result = "Julho";
                    break;
                case 8:
                    result = "Agosto";
                    break;
                case 9:
                    result = "Setembro";
                    break;
                case 10:
                    result = "Outubro";
                    break;
                case 11:
                    result = "Novembro";
                    break;
                case 12:
                    result = "Dezembro";
                    break;
            };
            return result;
        }
    }

}
