using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Entity_Framework_Core_Template
{
    public class class1 //Entity
    {
        //
        public int Class1id { get; set; } 
        public string name { get; set; }
        
        public List<class2> classs2 { get; set; } //foreign key from class2
        
    }

    public class class2 //Entity
    {
        public int Class2id { get; set; }
        public int Class1id { get; set; }
        public class1 class1 { get; set; }
        
    }
}