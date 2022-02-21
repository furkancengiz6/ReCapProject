using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] arg)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id+car.Description+car.DailyPrice+car.DailyPrice);
            }
        }
    }

}