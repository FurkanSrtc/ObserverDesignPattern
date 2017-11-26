using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer3
{
    class Messages
    {
        public void NewWhatsappMessage()
        {
            
                Notification(n.Whatsapp);
            
        }
        public void NewSmsMessage()
        {
            
                Notification(n.Sms);
            
        }

        public List<Users> users = new List<Users>();


         

        public void Notification(n value)
        {
            foreach (Users user in users)
            {
                if (value == n.Whatsapp)
                {
                    if (user.WhatsappNotify == true)
                    {
                        user.WMessages++;
                        WhatsappNotify(user.Ad, user.WMessages);
                    }

                }

                else
                {
                    if (user.SmsNotify == true)
                    {
                        user.SMessages++;
                        SmsNotify(user.Ad, user.SMessages);
                    }
                }
            }
        }


        public void WhatsappNotify(string ad, int messages)
        {
            Console.WriteLine(ad + " Kullanıcısının " + messages + " Adet Whatsapp Bildirimi Var");
        }

        public void SmsNotify(string ad, int messages)
        {
            Console.WriteLine(ad + " Kullanıcısının " + messages + " Adet Sms Bildirimi Var");
        }



        #region Kullanıcı Ekle-Sil

        public void AddUser(Users member)
        {
            users.Add(member);
            Console.WriteLine(member.Ad+" Kullanıcısı Eklendi");
        }

        public void RemoveUser(Users member)
        {
            users.Remove(member);
            Console.WriteLine(member.Ad + " Kullanıcısı Silindi");
        }

        #endregion

        #region Bildirimleri Aç-Kapat

        public void TurnOnNotify(Users user, n notify)
        {
            if (notify == n.Whatsapp)
                user.WhatsappNotify = true;

            else
                user.SmsNotify = true;
            Console.WriteLine("\n>" + user.Ad + " Kullanıcısının " + notify + " Bildirimi Açıldı" + "\n");
        }

        public void TurnOffNotify(Users user, n notify)
        {
            if (notify == n.Whatsapp)
                user.WhatsappNotify = false;

            else
                user.SmsNotify = false;
            Console.WriteLine("\n>" + user.Ad + " Kullanıcısının " + notify + " Bildirimi Kapatıldı" + "\n");
        }

        #endregion


    }
}
