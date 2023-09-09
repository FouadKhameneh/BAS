using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetGLNByKeyQuery : Query
    {
        public long Key { get; set; }
    }

    public class GetGLNByKeyResult : SingleQueryResult<GetGLNByKeyModel> { }

    public class GetGLNByKeyModel
    {
        public long Key { get; set; }
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public long GLNLanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Address { get; set; }

        public string FullName { get; set; }
    }
}
