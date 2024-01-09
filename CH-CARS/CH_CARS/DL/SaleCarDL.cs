using CH_CARS.BL;
using System.Collections.Generic;
using System.IO;

namespace CH_CARS.DL
{
    internal class SaleCarDL
    {
        static string saleCarFile = "saleCars.txt";
        public static List<SaleCar> SaleCars = new List<SaleCar>();

        public static void AddInList(SaleCar car) { SaleCars.Add(car); }
        public static void RemoveFromList(SaleCar car) { SaleCars.Remove(car); }
        public static SaleCar FindCarinList(string name)
        {
            foreach (SaleCar car in SaleCars)
            {
                if(name==car.GetCarName())
                    return car;
            }
            return null;
        }
        public static bool StoreInFileSale()
        {
            StreamWriter filevariable = new StreamWriter(saleCarFile, false);
            foreach (SaleCar car in SaleCars)
            {
                filevariable.WriteLine("{0},{1},{2},{3}",car.GetCarName(),car.GetCarPrice(),car.GetCarModel(),car.GetCarCompany());
            }
            filevariable.Flush();
            filevariable.Close();
            return true;
        }
        public static bool ReadFromSaleFile()
        {
            StreamReader file = new StreamReader(saleCarFile);
            string record;
            if (File.Exists(saleCarFile))
            {
                while ((record = file.ReadLine()) != null)
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
                        SaleCar info = new SaleCar(carName, carPrice, carModel, carCompany);
                        AddInList(info);
                    }
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
