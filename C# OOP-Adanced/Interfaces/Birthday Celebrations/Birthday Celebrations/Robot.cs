using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
     public class Robot : IRobot
    {
         public Robot(string model, string id)
         {
             this.Model = model;
             this.Id = id;
         }
        public string Model { get; }
        public string Id { get; }
       
    }
}
