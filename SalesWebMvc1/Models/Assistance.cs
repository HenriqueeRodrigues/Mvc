using System;
using System.ComponentModel.DataAnnotations;

namespace SecretaryWebMvc.Models
{
    public class Assistance
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public int CongregationId { get; set; }

        public Congregation Congregation { get; set; }
    }
}
