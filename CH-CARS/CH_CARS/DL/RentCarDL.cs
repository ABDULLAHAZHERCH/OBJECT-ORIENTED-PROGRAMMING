using CH_CARS.BL;
using System.Collections.Generic;
using System.IO;

namespace CH_CARS.DL
{
    internal class RentCarDL
    {
        static string rentCarFile = "rentCars.txt";
        public static List<RentCar> RentCars = new List<RentCar>();

        public static void AddInList(RentCar car) { RentCars.Add(car); }
        internal static void RemoveFromList(RentCar car) { RentCars.Remove(car); }
        public static RentCar FindCarinList(string name)
        {
            foreach (RentCar car in RentCars)
            {
                if (name == car.GetCarName())
                    return car;
            }
            return null;
        }
        public static bool StoreInFileRent()
        {
            StreamWriter filevariable = new StreamWriter(rentCarFile, false);
            foreach (RentCar car in RentCars)
            {
                filevariable.WriteLine("{0},{1},{2},{3}",car.GetCarName(), car.GetCarPrice(), car.GetCarModel(), car.GetCarCompany());
            }
            filevariable.Flush();
            filevariable.Close();
            return true;
        }
        public static bool ReadFromRentFile()
        {
            StreamReader fileVariable = new StreamReader(rentCarFile);
            string record;
            if (File.Exists(rentCarFile))
            {
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        break;
                    }
                    else
                    {
                        string[] splittedRecord = record.Split(',');
                        string carName = splittedRecord[0];
                        int carPrice = int.Parse(splittedRecord[1]);
                        string carModel = splittedRecord[2];
                        string carCompany = splittedRecord[3];
                        RentCar info = new RentCar(carName, carPrice, carModel, carCompany);
                        AddInList(info);
                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
    }
}
