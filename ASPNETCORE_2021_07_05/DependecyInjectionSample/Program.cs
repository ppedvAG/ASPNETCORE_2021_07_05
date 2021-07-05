using System;

namespace DependecyInjectionSample
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {


    //        BadCar badCar = new BadCar(); 
    //        //Man kann nur von BadCar vererben -> alle Basisklassen informationen und Logiken werden mit übernommen. 


    //        BadCarService carService = new BadCarService();
    //        carService.RepairCar(badCar);




    //        ICar mockObj = new MockCar();
    //        ICar orginalObj = new Car();
            
    //        ICarService service = new CarService();
    //        service.RepairCar(mockObj);
    //        service.RepairCar(orginalObj);
    //    }
    //}


    #region BadCode
    public class BadCar  
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public DateTime ConstructionYear { get; set; }
    }


    public class BadCarService // Programmierer B: 3 Tage (Entwickler B kann erst an Tag 6 mit seiner Arbeit anfangen)
    {
        public void RepairCar(BadCar car) //Flexibilität ist eingeschränkt - Es geht nur über Vererbung
        {
            //Mach etwas in 
        }
    }
    #endregion


    #region Better

    public interface ICar
    {
        string Brand { get; set; }
        string Modell { get; set; }
        DateTime ConstructionYear { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }

    public class Car : ICar // Programmierer A: 5 Tage
    {
        //Im Hintergrund wird eine private Variable zu public string Brand { get; set; } (AutoProperty) angelegt
        public string Brand { get; set; } //Auto Property -> 
        public string Modell { get; set; }
        public DateTime ConstructionYear { get; set; }
    }

    public class ElektorCar : ICar
    {
        public string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Modell { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ConstructionYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class CarService : ICarService // Programmierer B: 3 Tage
    {
        public void RepairCar(ICar car) //Flexibilität ist eingeschränkt - Es geht nur über Vererbung
        {
            //Mach etwas in 
        }
    }

    public class MockCar : ICar //Programmierer B - MockCar 30 Minuten 
    {
        //Im Hintergrund wird eine private Variable zu public string Brand { get; set; } (AutoProperty) angelegt
        public string Brand { get; set; } = "VW";
        public string Modell { get; set; } = "Polo";
        public DateTime ConstructionYear { get; set; } = DateTime.Now;
    }

    #endregion
}
