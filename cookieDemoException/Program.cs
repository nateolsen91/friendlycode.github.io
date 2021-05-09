using System;
using static System.Console;
namespace CookieDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CookieOrder ChocolateChip = new CookieOrder("Chocolate Chip ", 12345, " Fred Meyer ", 2);
            CookieOrder PeanutButter = new CookieOrder("Peanut Butte r", 23456, " Albertsons ", 5);
            CookieOrder Oatmeal = new CookieOrder("Oatmeal", 34567, " Winco", 1);
            SpecialCookieOrder SnickerDoodle = new SpecialCookieOrder("SnickerDoodle ", 45678, " Whole Foods ", 3, " Gluten-Free");
            SpecialCookieOrder IcedSugar = new SpecialCookieOrder("Sugar ", 56789, " Sweet Valley Cookie Company ", 1, " Iced");*/

            CookieOrder[] cookieArray = new CookieOrder[3];
            int x = 0;
            bool areNumbersGood = false;
            while ((!areNumbersGood) || (x < cookieArray.Length))
            {
                try
                {
                    GetData(out string cookie, out string name, out int orderNum, out int dozen);
                    cookieArray[x] = new CookieOrder(cookie, name, orderNum, dozen);
                    WriteLine("");
                    WriteLine(cookieArray[x].ToString());
                    ++x;
                    areNumbersGood = true;
                }
                catch(FormatException e)
                {
                    WriteLine(e.Message);
                    WriteLine("\nThe order number or dozen number was not a numeric value.");
                }
                   

            }
        }

        static void GetData(out string cookie, out string name, out int orderNum, out int dozen)
        {
            try
            {
                Write("Enter Order Number: ");
                orderNum = Convert.ToInt32(ReadLine());
                Write("Type of Cookie: ");
                cookie = ReadLine();
                Write("Name of Company: ");
                name = ReadLine();               
                Write("Number of dozens: ");
                dozen = Convert.ToInt32(ReadLine());
            }
            catch (FormatException e)
            {
                //WriteLine(e.Message);
                throw (e);
            }
        }
  
    }//end program


    class CookieOrder
    {

        public string Cookie { get; set; }
        public string Name { get; set; }
        public int OrderNum { get; set; }
        public string Company { get; set; }
        public int Dozen { get; set; }
        public double price;

        public virtual double Price
        {
            get
            {
                //price = 15;
                if (Dozen <= 2)
                    price = Dozen * 15;
                else
                    price = 30 + (Dozen - 2) * 13;
                return price;
            }
        }
        public CookieOrder()
        { }

        public CookieOrder(string cookie, string name, int orderNum, int dozen)
        {
            Cookie = cookie;
            OrderNum = orderNum;
            Name = name;
            Dozen = dozen;
            //this.price = price;

        }

        public override string ToString()
        {
            return ("Order Number: " + OrderNum + " for " + Company + "\n" + Cookie + "\nHow many dozen: " + Dozen + "\nTotal price: " + Price.ToString("C") + "\n");
        }

    }//endcookieorder
     //public SpecialCookieOrder(string cookie, int orderNum, string company, int dozen, string v) : base(cookie, orderNum, company, dozen)


    class SpecialCookieOrder : CookieOrder
    {
        public string SpecialOrder { get; set; }

        public override double Price
        {
            get
            {
                if (base.Price <= 40)
                    this.price = base.price + 10;
                else
                    this.price = base.price + 8;
                return price;

            }

        }
        public SpecialCookieOrder(string cookie, string name, int orderNum, int dozen, string specialOrder) : base(cookie, name, orderNum, dozen)
        {
            SpecialOrder = specialOrder;


        }
        public override string ToString()
        {
            return (base.ToString() + "\nSpecial Order: " + SpecialOrder);
        }


    }

}


