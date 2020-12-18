using System;

namespace Overcoat
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv massiv = new Massiv();
            Massiv mass = massiv;
            var nazva = mass.InputNazva();
            var price = mass.InputPrice();
            Massiv c1 = new Massiv { A = nazva[0], B = price[0] };
            Massiv c2 = new Massiv { A = nazva[1], B = price[1] };
            Console.WriteLine("Выберите действие (==,=,>): ");
            String math = Console.ReadLine();
            if (math == "==")
            {
                if(c1 == c2)
                Console.WriteLine("==");
                else
                    Console.WriteLine("!");
            }
            else if (math == "=")
            {
                Massiv c3 = c1;
                Console.WriteLine("c1 = " + c1 + " = c3 = " + c3);
            }
            else if (math == ">")
            {
                Console.WriteLine("Дороже вышел костюм: ");
                if (c1 > c2)
                   Console.WriteLine("Первый");
                else if(c1 == c2)
                   Console.WriteLine("Цена одинаковая");
                else
                    Console.WriteLine("Второй");
            }
                else
                Console.WriteLine("Неверное действие");
        }
    }

    class Massiv
    {
        public String[] InputNazva()
        {
           String[] arr = new String[2];
            Console.WriteLine("Введите названия одежды");
            Console.WriteLine("Введите Первое: ");
            arr[0] = Console.ReadLine();
            Console.WriteLine("Введите Второе: ");
            arr[1] = Console.ReadLine();
               return arr;
        }
        public Double[] InputPrice()
        {
            Double[] arr = new Double[2];
            Console.WriteLine("Введите цену");
            Console.WriteLine("Первого товара: ");
            arr[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второго товара: ");
            arr[1] = Convert.ToDouble(Console.ReadLine());
            return arr;
        }

        public override bool Equals(object obj)
        {
            return obj is Massiv massiv &&
                   A == massiv.A &&
                   B == massiv.B;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }

        public Double A { get; set; }
        public Double B { get; set; }


        public static bool operator ==(Massiv c1, Massiv c2)
        {
            return c1.B == c2.B;
        }
        public static bool operator !=(Massiv с1, Massiv с2)
        {
            return с1.B != с2.B;
        }
        public static Massiv operator +(Massiv c1)
        {
            return new Massiv
            {
                A = c1.A,
                B = c1.B
            };
        }
        public static bool operator >(Massiv c1, Massiv c2)
        {
            return c1.B > c2.B;
        }
        public static bool operator <(Massiv c1, Massiv c2)
        {
            return c1.B < c2.B;
        }

   
    }

    /*

    public static Massiv operator -(Massiv cont1, Massiv cont2)
    {
        return new Massiv
        {
            A = cont1.A - cont2.A,
            B = cont1.B - cont2.B
        };
    }
    public static Massiv operator +(Massiv cont1, Massiv cont2)
    {
        return new Massiv
        {
            A = cont1.A + cont2.A,
            B = cont1.B + cont2.B
        };
    }
    public static Massiv operator /(Massiv cont1, Massiv cont2)
    {
        return new Massiv
        {
            A = cont1.A / cont2.A,
            B = cont1.B / cont2.B

        };
    }
    }
}
    */
}

