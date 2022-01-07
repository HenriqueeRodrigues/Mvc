using System.Collections.Generic;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class CongregationFormViewModel
    {
        public Congregation Congregation { get; set; }

        public Users Users { get; set; }

        public ICollection<Congregation> UserCongregations { get; set; }

    }
}