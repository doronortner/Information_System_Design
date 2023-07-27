using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Group11_Project
{
    public enum AllowedOccupation
    {
       [Description("School Student")] SchoolStudent,
       [Description("University Student")] UniversityStudent,
       Entreprenuer,
       [Description("Industry Representative")] IndustryRepresentative,
       [Description("Municipal Representative")] MunicipalRepresentative,
       [Description("Academic Researcher")] AcademicResearcher
    }
}
