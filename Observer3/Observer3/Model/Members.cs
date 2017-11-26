using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer3.Model
{
    class Members
    {
      

       public Users Member1 = new Users()
       {
           Ad = "Şahin Aydın",
           SmsNotify = true,
           WhatsappNotify = true,
           SMessages = 0,
           WMessages = 0
       };

        public Users Member2 = new Users()
        {
            Ad = "Nurşen Topçubaşı",
            SmsNotify = true,
            WhatsappNotify = false,
            SMessages = 0,
            WMessages = 0
        };

        public Users Member3 = new Users()
        {
            Ad = "Oğuzhan Özdemir",
            SmsNotify = false,
            WhatsappNotify = true,
            SMessages = 0,
            WMessages = 0
        };

    }

}



