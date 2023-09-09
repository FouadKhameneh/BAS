using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class LocationView
    {
        //location
        public int Key { get; set; }
        public int LocationTypeRef { get; set; }
        public int? ParentRef { get; set; }
        public int LevelNo { get; set; }
        public bool IsActive { get; set; }

        //location language

        public string _Name { get; set; }
        public int LocationRef { get; set; }

        //location type

        public string Alias { get; set; }
    }
}
