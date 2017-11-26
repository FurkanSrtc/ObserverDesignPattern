using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer3
{
    enum n
    {
        Whatsapp,
        Sms
    }

   public class Users
    {
        public string Ad { get; set; }
        public Boolean WhatsappNotify { get; set; }
        public Boolean SmsNotify { get; set; }
        public int WMessages { get; set; }
        public int SMessages { get; set; }
    }




}
