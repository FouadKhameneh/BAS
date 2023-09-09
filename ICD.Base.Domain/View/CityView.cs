using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.View
{
    public class CityView
    {
        public int Key { get; set; }
        public bool IsActive { get; set; }
        public int CountryRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

    }
}
