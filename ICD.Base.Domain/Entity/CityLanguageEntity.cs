using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.Entity
{
    public class CityLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

        #region Navigation Prop
        public int CityRef { get; set; }
        public CityEntity City { get; set; }
        #endregion
    }
}
