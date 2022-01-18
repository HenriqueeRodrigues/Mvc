using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SecretaryWebMvc.Models.Enums;


namespace SecretaryWebMvc.Models
{
    public class ActivitiesReport
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Mes do relatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:/MM/yyyy}")]
        public DateTime Date { get; set; }


        public double Publications { get; set; }

        public double Video { get; set; }

        public double Hours { get; set; }

        public double Revisits { get; set; }

        public double BibleStudies { get; set; }

        public double PlusHours { get; set; }

        public string Observation { get; set; }

        public bool? PionerAux { get; set; }

        public  Publisher Publisher { get; set; }
      

        public  int PublisherId { get; set; }

        //public string Months { get; set; }

        ////public int MonthsId { get; set; }

        public ActivitiesReport()
        {
        }

        public ActivitiesReport(int id, 
            DateTime date, 
            double publications, 
            double video, 
            double hours, 
            double revisits, 
            double bibleStudies, 
            double plusHours, 
            string observation, 
            Publisher publisher
           )
        {
            Id = id;
            Date = date;
            Publications = publications;
            Video = video;
            Hours = hours;
            Revisits = revisits;
            BibleStudies = bibleStudies;
            PlusHours = plusHours;
            Observation = observation;
            Publisher = publisher;
        }
    }
}
