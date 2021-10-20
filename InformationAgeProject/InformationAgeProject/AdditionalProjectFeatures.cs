using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    class AdditionalProjectFeatures
    {
        private static Random rNum = new Random( );
        private Boolean blnDiceRollRequired = false;
        private List<Resource> listResourceAwared = new List<Resource>( );
        private List<AdditionalProjectFeaturesType> listTypeAwared = new List<AdditionalProjectFeaturesType>( );

        public AdditionalProjectFeatures ( )
        {
            this.listResourceAwared.Add(new Resource(rNum.Next(4)));
            this.listTypeAwared.Add((AdditionalProjectFeaturesType)rNum.Next(11));
            if (0 == rNum.Next(5))
            {
                this.listResourceAwared.Add(listResourceAwared[0]);
            }

            if ((int)listTypeAwared[0] > 7 && 0 == rNum.Next(5))
            {
                this.listTypeAwared.Add(listTypeAwared[0]);
            }
        }

        public AdditionalProjectFeatures (int choice)
        {
            if (choice == 1)
            {
                blnDiceRollRequired = true;
                this.listResourceAwared.Add(new Resource(rNum.Next(4)));
                this.listTypeAwared.Add((AdditionalProjectFeaturesType)rNum.Next(11));

                if ((int)listTypeAwared[0] > 7 && 0 == rNum.Next(5))
                {
                    this.listTypeAwared.Add(listTypeAwared[0]);
                }
            }
            else if (choice == 2)
            {

            }
        }

    }
}
