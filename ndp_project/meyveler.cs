using System;
using System.Collections.Generic;
using System.Text;

namespace ndp_project
{
    class Meyveler:IMeyveler
    {
        private int vitaminA_;
        private int vitaminC_;
        private int meyveGrami_;

        public Meyveler()
        {
            
        }

        public int vitaminA
        {
            get
                {
                return vitaminA_;
                }
            set { }
        }
        public int vitaminC
        {
            get
            {
                return vitaminC_;
            }
            set
            { }
        }
        public int meyveGrami
        {
            get
            {
                return meyveGrami_;
            }
            set
            { }
        }



    }
}
