using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Entity_Framework_Core_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deleting the Db
            using(var context =new NameContext())
            {
                context.Database.EnsureDeleted();
            }



            //Creating the Db
            using(var context = new NameContext())
            {
                context.Database.EnsureCreated();
            }





            //Adding Data to the Db
            using (var context = new NameContext())
            {
                var Data = new class1 
                {
                    Class1id = 1,
                    name = "name test"
                };
                context.class1.Add(Data);
                context.SaveChanges();
            }






            //Querying the Db
            using (var context = new NameContext())
            {
                var Datas = context.class1.ToList(); 
                foreach (var Data in Datas)
                {
                    System.Console.WriteLine(Data.Class1id + " " + Data.name);
                    
                } 
            }


            


            //Updating the Db
            using (var context = new NameContext())
            {
                var Data = context.class1.First();
                Data.name = "name test 2";
                context.SaveChanges();
            }




            //Deleting Data from the Db
            using (var context = new NameContext())
            {
                var blog = context.class1.First();
                context.class1.Remove(blog);
                context.SaveChanges();
            }







            
        }
    }
}
