using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Properties
{
    public class CarModel
    {
        private string _name;
        public string Model;
        private string _color;

        List<string> validColor = new List<string>() { "red", "blue", "black" };

        List<string> validCar = new List<string>() { "pride", "samand", "vanet" };


        public CarModel(string name, string model, string color)
        {
            Name = name;
            Model = model;
            Color = color;
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                if(validColor.Contains(value)) 
                
                {
                    _color= value;
                }
                else
                {
                    _color = "ND";
                }
            }

        }

        public string Name {
            get
            {
                return _name;
            } 
            
            set
            {
                if (validCar.Contains(value))
                {
                    _name= value;
                }
                else
                {
                    _name = "ND";
                }
            }
        
        }


    }
}
