using System;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace OrmLite.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbFactory = new OrmLiteConnectionFactory(
                "Server=im.gshichina.com;Port=5002;Database=geshidb;Uid=ge;Pwd=shi2019;",  
               MySqlDialect.Provider);
            
            using (var db = dbFactory.Open())
            {
                db.Insert(new ormlite_demo
                {
                    Id = 1,
                    Name = "Seed Data",
                    CreateDateTime = DateTime.Now,
                        
                });

                var result = db.SingleById<ormlite_demo>(1);
                result.PrintDump(); //= {Id: 1, Name:Seed Data}
            }

        }
    }

    public class ormlite_demo
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime CreateDateTime { get; set; }
        
        public bool IsSuper { get; set; }

        public int Sex { get; set; }
    }
}