using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebWPFUI.ViewModels
{
    public class KirjautuminenViewModel : Screen
    {
        private string _user;
        private string _salasana;

        public string User
        {
            get { return _user; }
            set 
            { 
                _user = value;
                NotifyOfPropertyChange(() => User);
            }
        } 
        public string Salasana
        {
            get { return _salasana; }
            set { 
                _salasana = value;
                NotifyOfPropertyChange(() => Salasana);
                NotifyOfPropertyChange(() => VoiKirjautua);
            }
        }

        //Tarkistetaan, että kentät ei ole null tai kenttiin ollaan kirjoitettu vähintään 1 kirjain.
        public bool VoiKirjautua
        {
            get
            {
                bool output = false;

                if (User?.Length > 0 && Salasana?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public void Kirjaudu()
        {
            Console.WriteLine();
        }



    }
}
