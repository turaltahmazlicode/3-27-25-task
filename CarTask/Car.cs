namespace CarTask
{
    public class Car
    {
        public Car(string brand, string model, decimal prime, ushort year, string color)
        {
            Brand = brand;
            Model = model;
            Price = prime;
            Year = year;
            Color = color;
        }

        private string _brand;
        private string _model;
        private decimal _price;
        private ushort _year;
        private string _color;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public ushort Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nPrice: {Price}\nYear: {Year}\nColor: {Color}\n";
        }
    }
}
