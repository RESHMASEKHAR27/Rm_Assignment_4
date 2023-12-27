namespace Rm_Assignment_4
{


    class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.WriteLine("Enter OrderId:");
            OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter OrderDate (yyyy-mm-dd):");
            OrderDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Furniture Type (Chair/Cot):");
            FurnitureType = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Total Amount:");
            TotalAmt = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Payment Mode (credit/debit card):");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"OrderId: {OrderId}");
            Console.WriteLine($"OrderDate: {OrderDate.ToShortDateString()}");
            Console.WriteLine($"FurnitureType: {FurnitureType}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }

    }
    class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public string WoodType { get; set; }
        public string SteelType { get; set; }
        public string PlasticColor { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData(); // call base class GetData method

            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic):");
            ChairType = Console.ReadLine();

            Console.WriteLine("Enter Purpose (Home/Office):");
            Purpose = Console.ReadLine();

            if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                WoodType = Console.ReadLine();
            }
            else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Steel Type (Gray Steel/Green Steel/Brown Steel):");
                SteelType = Console.ReadLine();
            }
            else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Plastic Color (Green/Red/Blue/White):");
                PlasticColor = Console.ReadLine();
            }

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDecimal(Console.ReadLine());

        }

        public override void ShowData()
        {
            base.ShowData(); // call base class ShowData method

            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");

            if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }
            else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Plastic Color: {PlasticColor}");
            }

            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class Cot : Furniture
    {
        public string CotType { get; set; }
        public string WoodType { get; set; }
        public string SteelType { get; set; }
        public string Capacity { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData(); 

            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();

            if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                WoodType = Console.ReadLine();
            }
            else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Steel Type (Gray Steel/Green Steel/Brown Steel):");
                SteelType = Console.ReadLine();
            }

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDecimal(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData(); // call base class ShowData method

            Console.WriteLine($"Cot Type: {CotType}");

            if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }

            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair();
            chair.GetData();
            chair.ShowData();

            Console.WriteLine();

            Cot cot = new Cot();
            cot.GetData();
            cot.ShowData();
        }
    }
}