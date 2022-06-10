using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //class Program
    //{
    //    public class Vaccine
    //    {
    //        public void Getname()
    //        {
    //            Console.WriteLine("Covidshield Vaccine");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Vaccine _Vaccine = new Vaccine();
    //        _Vaccine.Getname();//Tight couple becuase if need changes then need rewrite exist tested class.
    //        Console.ReadLine();
    //    }


    //    public interface IVaccine
    //    {
    //        void Getname();
    //    }
    //    public class Covishield : IVaccine //Service Class Covishield
    //    {
    //        public void Getname()
    //        {
    //            Console.WriteLine("Inject Covidshield Vaccine");
    //        }
    //    }
    //    public class Covaxine : IVaccine //Service Class Covaxine
    //    {
    //        public void Getname()
    //        {
    //            Console.WriteLine("Inject Covaxine Vaccine");
    //        }
    //    }
    //    public class VaccineClientService : IVaccine
    //    {
    //        private IVaccine _ClientService;
    //        public VaccineClientService(IVaccine _ClientService)
    //        {
    //            this._ClientService = _ClientService;
    //        }
    //        public void Getname()
    //        {
    //            _ClientService.Getname();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        VaccineClientService vaccineClientService = new VaccineClientService(new Covishield());
    //        VaccineClientService vaccineClientService = new VaccineClientService(new Covishield());//Inector
    //        vaccineClientService.Getname();
    //        vaccineClientService = new VaccineClientService(new Covaxine());
    //        vaccineClientService.Getname();
    //        Console.ReadLine();
    //    }
    //}
}
