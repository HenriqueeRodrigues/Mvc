﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SecretaryWebMvc.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string FullName { get; set; }


        public string SimpleAddress { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Baptism Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BaptismDate { get; set; }


        public bool IsAnointed { get; set; }

        public bool IsElder { get; set; }

        public bool IsMinisterialServant { get; set; }

        public bool Ispioneer { get; set; }


        public Congregation Congregation { get; set; }

        public int CongregationId { get; set; }

        public ICollection<ActivitiesReport> Activities { get; set; } = new List<ActivitiesReport>();

        public Publisher()
        {
        }

        public Publisher(int id, 
            string fullName, 
            string simpleAddress,
            DateTime birthDate, 
            DateTime baptismDate, 
            bool isAnointed,
            bool isElder, 
            bool isMinisterialServant, 
            bool ispioneer, 
            Congregation congregation)
        {
            Id = id;
            FullName = fullName;
            SimpleAddress = simpleAddress;
            BirthDate = birthDate;
            BaptismDate = baptismDate;
            IsAnointed = isAnointed;
            IsElder = isElder;
            IsMinisterialServant = isMinisterialServant;
            Ispioneer = ispioneer;
            Congregation = congregation;
        }


        public void AddPublisher(ActivitiesReport sr)
        {
            this.Activities.Add(sr);
        }
    
        public void RemovePublisher(ActivitiesReport sr)
        {
            this.Activities.Remove(sr);
        }

        public double TotalPublisher(DateTime init, DateTime final)
        {

            return Activities.Where(x => x.Date >= init && x.Date <= final).Sum( y => y.Hours);
        }
    }
}
