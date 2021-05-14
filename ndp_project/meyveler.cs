using System;
using System.Collections.Generic;
using System.Text;

namespace ndp_project
{
    class Meyveler:IMeyveler
    {
        private string name;
        private string img;
        private int vitaminA;
        private int vitaminC;

        public Meyveler(string name, int vitaminA, int vitaminC, string img)
        {
            this.name = name;
            this.vitaminA = vitaminA;
            this.vitaminC = vitaminC;
            this.img = img;
        }


        public string getname()
        {
            return this.name;
        }
        public int getvitaminA()
        {
            return this.vitaminA;
        }
        public int getvitaminC()
        {
                return this.vitaminC;
        }
        
        public string getimg()
        {
            return this.img;
        }
       
            
        
            
        


    }
}
