using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    public class RecruitmentOffice
    {
        private int _devs;

        public RecruitmentOffice(int devs)
        {
            _devs = devs;
        }

        public int RecruitNewDev()
        {
            _devs += 1;
            int devsRecruited = _devs;
            return devsRecruited;
        }
    }
}
