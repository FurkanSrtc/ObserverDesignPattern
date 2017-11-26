using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Members members = new Model.Members();
            Messages Mesajlar = new Messages();


            Mesajlar.AddUser(members.Member1);
            Mesajlar.AddUser(members.Member2);
            Mesajlar.AddUser(members.Member3);


            Mesajlar.NewWhatsappMessage();
            Mesajlar.NewSmsMessage();

            Mesajlar.TurnOnNotify(members.Member3,n.Sms);

            Mesajlar.TurnOffNotify(members.Member1, n.Whatsapp);

            Mesajlar.NewSmsMessage();
            Mesajlar.NewWhatsappMessage();

            Console.ReadKey();
        }
    }
}
