using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Transactions;
using static Car;
using static Car.electric.hybrid.gasoline;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double price;
    private string type;

    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }
    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            value = model;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }

    }
    public class Sale : Car
    {
        private string custoername;
        private double pricepaid;

        public string Customername
        {
            get
            {
                return custoername;
            }
            set
            {
                custoername = value;
            }
        }

        public double pricpaid
        {
            get
            {
                return pricpaid;
            }
            set
            {
                pricpaid = value;
            }
        }
    }





    public class electric : Car
    {
        private int batterycapacity;
        public int kapasbat
        {
            get
            {
                return batterycapacity;
            }
            set
            {
                batterycapacity = value;
            }
        }

        public class hybrid : Car
        {
            private int gastanksize;
            public int tangkigas
            {
                get { return gastanksize; }
                set { gastanksize = value; }
            }
            private int batterycapacity;
            public int kapasbat
            {
                get
                {
                    return batterycapacity;
                }
                set
                {
                    batterycapacity = value;
                }
            }


            public class gasoline : Car
            {
                private int gastanksize;
                public int tangkigas
                {
                    get
                    {
                        return gastanksize;
                    }
                    set
                    {
                        gastanksize = value;
                    }
                }
                public class dealership
                {
                    private string Name;
                    private string Location;

                    public string name
                    {
                        get { return Name; }
                        set { Name = value; }
                    }
                    public string location
                    {
                        get { return Location; }
                        set { Location = value; }
                    }

                    public void removecar(string makecar, string mdl)
                    {
                        foreach (var n in listclas.ToList())
                        {
                            if (n.make == makecar && n.model == mdl)
                            {
                                listclas.Remove(n);
                            }
                            else
                            {
                                Console.Write("Make: ");
                                Console.WriteLine(n.make);
                                Console.Write("Model: ");
                                Console.WriteLine(n.model);
                                Console.Write("Price: ");
                                Console.WriteLine(n.price);
                                Console.Write("Year: ");
                                Console.WriteLine(n.year);
                                Console.Write("Type: ");
                                Console.WriteLine(n.type);
                            }
                        }
                    }
                        public void showcar()
                        {
                            foreach (var n in listclas)
                            {
                                Console.Write("Make: ");
                                Console.WriteLine(n.make);
                                Console.Write("Model: ");
                                Console.WriteLine(n.model);
                                Console.Write("Price: ");
                                Console.WriteLine(n.price);
                                Console.Write("Year: ");
                                Console.WriteLine(n.year);
                                Console.Write("Type: ");
                                Console.WriteLine(n.type);
                                Console.WriteLine();
                            }
                        }

                    List<Car> listclas = new List<Car>();
                    List<Car> sold = new List<Car>();
                    List<Car> namapembeli = new List<Car>();
                    List<Car>carr =new List<Car>();

                    class program
                    {
                        public static void Main(string[] args)
                        {
                            int menu;
                            int pilih;
                            bool exit = false;
                            if (exit == false)
                            {
                                Console.WriteLine("1. Add car");
                                Console.WriteLine("2. remove car");
                                Console.WriteLine("3.Show Car list");
                                Console.WriteLine("4.make sale");
                                Console.WriteLine("5.print sale");
                                Console.WriteLine("6.Exit");
                                Console.WriteLine("Menu Choice: ");
                                menu = Convert.ToInt32(Console.ReadLine());
                                while (menu !=7)
                                {
                                    if (menu == 1)
                                    {
                                        Console.WriteLine("1. Electric car");
                                        Console.WriteLine("2. Hybrid car");
                                        Console.WriteLine("3. Gasoline car");
                                        pilih = Convert.ToInt32(Console.ReadLine());
                                        {
                                            if (pilih == 1)
                                            {
                                                List<Car> listclas = new List<Car>();
                                                electric electricc = new electric();
                                                Console.Write("Add Make: ");
                                                electricc.make = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Model: ");
                                                electricc.model = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Year: ");
                                                electricc.year = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.Write("Add Price: ");
                                                electricc.price = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.WriteLine("Add Baterai Capacity");
                                                electricc.kapasbat = Convert.ToInt32(Console.ReadLine());
                                                electricc.type = "electric";
                                                listclas.Add(electricc);
                                            }
                                            else if (pilih == 2)
                                            {
                                                List<Car> listclas = new List<Car>();
                                                hybrid hybridd = new hybrid();
                                                Console.Write("Add Make: ");
                                                hybridd.make = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Model: ");
                                                hybridd.model = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Year: ");
                                                hybridd.year = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.Write("Add Price: ");
                                                hybridd.price = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.WriteLine("Add Baterai Capacity");
                                                hybridd.kapasbat = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Add Gas Capacity: ");
                                                hybridd.tangkigas = Convert.ToInt32(Console.ReadLine());
                                                hybridd.type = "hybrid";
                                                listclas.Add(hybridd);
                                            }
                                            else if (pilih == 3)
                                            {
                                                List<Car> listclas = new List<Car>();
                                                gasoline gasolinee = new gasoline();
                                                Console.Write("Add Make: ");
                                                gasolinee.make = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Model: ");
                                                gasolinee.model = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.Write("Add Year: ");
                                                gasolinee.year = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.Write("Add Price: ");
                                                gasolinee.price = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.Write("Add Gas Capacity: ");
                                                gasolinee.tangkigas = Convert.ToInt32(Console.ReadLine());
                                                gasolinee.type = "gasoline";
                                                listclas.Add(gasolinee);
                                            }
                                            if (menu == 2)
                                            {
                                                int menu2 = 0;
                                                while (menu2 !=1)
                                                {
                                                    dealership.removecar();
                                                }
                                            }
                                            if (menu == 3)
                                                {
                                                int menu3 = 0;
                                                    while (menu3 != 1)
                                                    {
                                                    dealership.showcar();
                                                    }
                                                }
                                            if ( menu == 4)
                                            {
                                                dealership.sold sale = new dealership.sold();
                                                Console.WriteLine("Add customer name: ");
                                                sold.customername = Console.ReadLine();
                                                Console.WriteLine("Add car make: ");
                                                sold.carmake = Console.ReadLine();
                                                Console.WriteLine("Add car model ");
                                                sold.carmodel = Console.ReadLine();
                                                Console.WriteLine("Car price :");
                                                sold.pricepaid = Convert.ToInt32(Console.ReadLine());

                                            }

                                        }
                                    }

                                        }
                                    }
                                        }


                                    }
                                }
                                    }
                                }
                            }
                        }
    















