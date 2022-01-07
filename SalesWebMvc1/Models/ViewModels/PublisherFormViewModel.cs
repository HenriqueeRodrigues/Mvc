using System.Collections.Generic;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class PublisherFormViewModel
    {
        public Publisher Publisher { get; set; }

        public ICollection<Congregation> Congregations { get; set; }

       
    }
}