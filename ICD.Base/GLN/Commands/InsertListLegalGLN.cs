using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class InsertListLegalGLNRequest : Request<InsertListLegalGLNResult>
    {
        public ICollection<InsertListLegalGLNDto> InsertListLegalGLNs { get; set; }
    }
    public class InsertListLegalGLNResult : SingleQueryResult<InsertListLegalGLNModel> { }
    public class InsertListLegalGLNModel { }

    public class InsertListLegalGLNDto
    {
        public long PersonRef { get; set; }
        public ICollection<InsertListLegalGLNDetailDto> Details { get; set; }
    }
    public class InsertListLegalGLNDetailDto
    {
        public string GLN { get; set; }

        public string _Title { get; set; }
        public string _Address { get; set; }
    }
}
