using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetContactTypeQuery : Query
    {

    }
    public class GetContactTypeResult : ListQueryResult<GetContactTypeModel> { }

    public class GetContactTypeModel
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int LanguageRef { get; set; }
        public int ContactTypeRef { get; set; }
        public string _Title { get; set; }
    }
}
