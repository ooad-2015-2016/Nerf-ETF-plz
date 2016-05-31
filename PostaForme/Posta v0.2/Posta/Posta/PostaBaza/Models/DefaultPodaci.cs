using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class DefaultPodaci
    {
        public static void Initialize(PostaDBContext context)
        {


            if (!context.login.Any())
            {
                context.login.AddRange(
                new LoginDB()
                {
                    username = "test",
                    password = "test1"
                }
                );
                context.SaveChanges();
            }

            if (!context.rejoni.Any())
            {
                context.rejoni.AddRange(
                new RejonDB()
                {
                    naziv = "alipasino"

                }
                );
                context.SaveChanges();
            }
            
            

           
                
            
            
        }
    }
}
