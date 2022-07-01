using Microsoft.AspNetCore.Http;
using SecretaryWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class ActivitiesReportFormViewModel
    {
        public ActivitiesReport ActivitiesReport { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<Publisher> Publishers { get; set; }

        public ICollection<ActivitiesReport> ActivitiesReports { get; set; }

        public ICollection<Assistance> Assistances { get; set; }


        public string Name { get => Publisher.Id != default ? Publisher.FullName : string.Empty; }

        public string Adress { get => Publisher.Id != default ? Publisher.SimpleAddress : string.Empty; }

        public DateTime BirthDate { get => Publisher.Id != default ? Publisher.BirthDate : DateTime.MinValue; }

        public DateTime BaptismDate { get => Publisher.Id != default ? Publisher.BaptismDate : DateTime.MinValue; }

        public bool Gender { get => Publisher.Id != default ? Publisher.IsMan : false; }

        public bool IsAnointed { get => Publisher.Id != default ? Publisher.IsAnointed : false; }

        public bool IsElder { get => Publisher.Id != default ? Publisher.IsElder : false; }

        public bool IsMinisterialServant { get => Publisher.Id != default ? Publisher.IsMinisterialServant : false; }

        public bool Ispioneer { get => Publisher.Id != default ? Publisher.Ispioneer : false; }

        public double Assistance(string week = null)
        {
            if (string.IsNullOrEmpty(week))
            {
                var assistanceWeekend = Assistances.Where(x => x.Date.DayOfWeek == DayOfWeek.Saturday || x.Date.DayOfWeek == DayOfWeek.Sunday);
                double sumWeekeend = assistanceWeekend.Sum(x => x.Quantity);
                double countDays = assistanceWeekend.Count();
                double mediaWeekend =   sumWeekeend / countDays;

                return mediaWeekend;
            }

            var assistanceWeek = Assistances.Where(x => x.Date.DayOfWeek == DayOfWeek.Wednesday || x.Date.DayOfWeek == DayOfWeek.Thursday);
            double sumWeek = assistanceWeek.Sum(x => x.Quantity);
            double countDaysWeek = assistanceWeek.Count();

            double mediaWeek = sumWeek / countDaysWeek;
            return mediaWeek;
        }

        public ActivitiesReport ActivitiesToCard(int month)
        {
            ActivitiesReport activities = new ActivitiesReport();
            if (Publisher.Id == default)
            {
                return activities;
            }

            foreach (var item in ActivitiesReports)
            {
                if (item.Date.Month == month)
                {
                    activities.Date = item.Date;
                    activities.Publications = item.Publications;
                    activities.Video = item.Video;
                    activities.Hours = item.Hours;
                    activities.Revisits = item.Revisits;
                    activities.BibleStudies = item.BibleStudies;
                    activities.PlusHours = item.PlusHours;
                    activities.Observation = item.Observation;
                }
            }

            return activities;
        }

        public double TotalActivitiesOrMedia(int colum, int media = default)
        {
            double result = 0;

            if (Publisher.Id == default)
            {
                return result;
            }

            var activitiesNumbers = ActivitiesReports.Count(x => x.Id != default);

            switch (colum)
            {
                case 1:
                    var publications = ActivitiesReports.Sum(x => x.Publications) / (media != default ? activitiesNumbers : 1);
                    publications = Math.Round((double)publications, 2);
                    result = (double)publications;
                    break;
            }
            switch (colum)
            {
                case 2:
                    var videos = ActivitiesReports.Sum(x => x.Video) / (media != default ? activitiesNumbers : 1);
                    videos = Math.Round((double)videos, 2);
                    result = (double)videos;
                    break;
            }
            switch (colum)
            {
                case 3:
                    var hours = ActivitiesReports.Sum(x => x.Hours) / (media != default ? activitiesNumbers : 1);
                    hours = Math.Round((double)hours, 2);
                    result = (double)hours;
                    break;
            }
            switch (colum)
            {
                case 4:
                    var revisits = ActivitiesReports.Sum(x => x.Revisits) / (media != default ? activitiesNumbers : 1);
                    revisits = (int)Math.Round((double)revisits, 2);
                    result = (double)revisits;
                    break;
            }
            switch (colum)
            {
                case 5:
                    var bibleStudies = ActivitiesReports.Sum(x => x.BibleStudies) / (media != default ? activitiesNumbers : 1);
                    bibleStudies = (int)Math.Round((double)bibleStudies, 2);
                    result = (double)bibleStudies;
                    break;
            }
            switch (colum)
            {
                case 6:
                    var plusHours = ActivitiesReports.Sum(x => x.PlusHours) / (media != default ? activitiesNumbers : 1);
                    plusHours = (int)Math.Round((double)plusHours, 2);
                    result = (double)plusHours;
                    break;
            }
            return result;
        }


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

        public string DateOrNull(int date = default)
        {
            if (date == 1)
            {
                if (this.BirthDate != DateTime.MinValue)
                {
                    return this.BirthDate.ToString("dd/MM/yyyy");
                }
                return string.Empty;
            }
            else
            {
                if (this.BaptismDate != DateTime.MinValue)
                {
                    return this.BaptismDate.ToString("dd/MM/yyyy");
                }
                return string.Empty;
            }
        }
    }

}
