using System.Collections.Generic;

namespace SecretaryWebMvc.Models.ViewModels
{
    public class PublisherFormViewModel
    {
        public Publisher Publisher { get; set; }

        public ICollection<Congregation> Congregations { get; set; }

        public ICollection<Publisher> Publishers { get; set; }


        public Publisher delete(int id)
        {

            var henrique = new Publisher();

            foreach (var item in Publishers)
            {
                if (item.Id == id)
                {
                    henrique = item;
                }
            }
            return henrique;
        }


        public bool EditChargeType()
        {
            return true;
        }


    }
}