using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SecretaryWebMvc.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " O tamanho minimo deve ser de {2} letras ")]
        public string FullName { get; set; }


        public string SimpleAddress { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Data de Batismo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BaptismDate { get; set; }


        public bool IsAnointed { get; set; }

        public bool IsElder { get; set; }

        public bool IsMinisterialServant { get; set; }

        public bool Ispioneer { get; set; }

        public Congregation Congregation { get; set; }

        public int CongregationId { get; set; }

        public bool IsInactive { get; set; }

        public DateTime? LastActivitiesRelated { get; set; }

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
    }
}
