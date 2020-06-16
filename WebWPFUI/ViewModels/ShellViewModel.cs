using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WebWPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private KirjautuminenViewModel _kirjautuminenVM;

        //Kun sovellus käynnistyy, viewiksi asetetaan kirjautuminen.
        public ShellViewModel(KirjautuminenViewModel kirjautuminenVM)
        {
            _kirjautuminenVM = kirjautuminenVM;
            ActivateItem(_kirjautuminenVM);
        }
    }
}
