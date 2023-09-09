using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetContactTypeByKeyQuery : Query
    {
        public int Key { get; set; }
    }
    public class GetContactTypeByKeyResult : SingleQueryResult<GetContactTypeByKeyModel> { }

    public class GetContactTypeByKeyModel
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int LanguageRef { get; set; }
        public int ContactTypeRef { get; set; }
        public string _Title { get; set; }
    }
}
