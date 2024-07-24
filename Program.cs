namespace ElectricBills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten khach hang:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Chi so dien thang truoc:");
            int lastMonthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chi so dien thang nay:");
            int thisMonthNumber = Convert.ToInt32(Console.ReadLine());
            
            int comsumedUnit = thisMonthNumber-lastMonthNumber;
            if (comsumedUnit > 0 && comsumedUnit <= 50)
            {
                CalculateElectricBillLevel1(comsumedUnit);
            }
            if(comsumedUnit > 50 && comsumedUnit <=100)
            {
                CalculateElectricBillLevel2(comsumedUnit);
            }
            if (comsumedUnit > 100 && comsumedUnit <= 200)
            {
                CalculateElectricBillLevel3(comsumedUnit);
            }
            if (comsumedUnit > 200 && comsumedUnit <= 300)
            {
                CalculateElectricBillLevel4(comsumedUnit);
            }
            if (comsumedUnit > 300 && comsumedUnit <= 400)
            {
                CalculateElectricBillLevel5(comsumedUnit);
            }
            if (comsumedUnit > 400)
            {
                CalculateElectricBillLevel6(comsumedUnit);
            }

        }

        public static void CalculateElectricBillLevel1(int comsumedUnit)
        {
            
        }
        public static void CalculateElectricBillLevel2(int comsumedUnit)
        {

        }
        public static void CalculateElectricBillLevel3(int comsumedUnit)
        {

        }
        public static void CalculateElectricBillLevel4(int comsumedUnit)
        {

        }
        public static void CalculateElectricBillLevel5(int comsumedUnit)
        {

        }
        public static void CalculateElectricBillLevel6(int comsumedUnit)
        {

        }
    }
}
