using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class PersonView
    {
        //person
        public long Key { get; set; }
        public string NationalIdentity { get; set; }
        public string EconomicId { get; set; }
        public int PersonTitleRef { get; set; }


        //person language
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _FatherName { get; set; }
        public string FullName { get; set; }

        //person title

        public int Order { get; set; }
        public bool IsLegal { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }

        public string _PersonTitleName { get; set; }

        public string BaseTypeAlias { get; set; }
    }
}
