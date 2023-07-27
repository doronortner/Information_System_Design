using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Group11_Project
{
    public enum JobTitle
    {
        CEO,
        COO,
        [Description("Program Manager")] ProgramManager,
        [Description("Community Manager")] CommunityManager,
        [Description("International Programs Manager")] InternationalProgramsManager,
        [Description("Marketing Manager")] MarketingManager,
        [Description("Social-Media Manager")] SocialMediaManager
    }
}
