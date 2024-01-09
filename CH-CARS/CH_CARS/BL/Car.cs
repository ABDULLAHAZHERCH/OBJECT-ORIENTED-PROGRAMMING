namespace CH_CARS.BL
{
    internal class Car
    {
        private string carName;
        private int carPrice;
        private string carModel;
        private string carCompany;

        protected string CarName { get => carName; set => carName = value; }
        protected int CarPrice { get => carPrice; set => carPrice = value; }
        protected string CarModel { get => carModel; set => carModel = value; }
        protected string CarCompany { get => carCompany; set => carCompany = value; }

        public Car(string carName, int carPrice, string carModel, string carCompany)
        {
            this.CarName = carName;
            this.CarPrice = carPrice;
            this.CarModel = carModel;
            this.CarCompany = carCompany;
        }
        public string GetCarName() { return CarName; }
        public int GetCarPrice() { return CarPrice; }
        public string GetCarModel() { return CarModel; }
        public string GetCarCompany() { return CarCompany; }
        public void SetCarName(string carName) { this.CarName = carName; }
        public void SetCarPrice(int carPrice) { this.CarPrice = carPrice; }
        public void SetCarModel(string carModel) { this.CarModel = carModel; }
        public void SetCarCompany(string carCompany) { this.CarCompany = carCompany; }
    }
}
