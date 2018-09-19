using System;
using System.ComponentModel;




namespace Models
{
    public class VehicleInformation
    {
        [DisplayName("Model Name")]
        public string ModelName { get; set; }

        [DisplayName("Model Year")]
        public string ModelYear { get; set; }

        [DisplayName("Price")]
        public String Price { get; set; }


    }
}
