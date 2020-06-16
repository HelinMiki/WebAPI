using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WebWPFUI.ViewModels;

namespace WebWPFUI
{
    public class Bootstrapper : BootstrapperBase
    {
        //Käsittelee instanssit
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container.Instance(_container);

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            //Haetaan kaikki tyypit nykyiselle instanssille (Assembly).
            //Rajoitetaan haku luokkiin ja haetaan luokista nimet, jotka loppuvat ViewModeliin. 
            //Lista käydään läpi ja _container rekisteröi pyyntöjen tyypin ja nimen.
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }

        //Kun ohjelma käynnistetään, otetaan käyttöön ShellViewModel-ikkuna.
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        //Haetaan containerin avulla ShellViewModel.
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        //Instanssin konstruktori.
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
