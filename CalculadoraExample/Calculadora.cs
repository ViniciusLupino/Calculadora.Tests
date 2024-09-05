namespace CalculadoraExample
{
    public class Calculadora
    {
        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
        public static int Dividir(int x, int y)
        {
           

            if (x == 0 || y == 0)
            {
                return 0;
            }
            return x / y;
        }

        public static double [] Bhaskara(double a, double b, double c)
        {
            double deltaParc = b * b;
            double deltaParc2 = 4 * a * c;
            double delta = deltaParc - deltaParc2;
            double raiz = Math.Sqrt(delta);

            if (a == 0)
            {
                return new double [0];
            }

            if (delta < 0)
            {
                return new double[0];
            }

            double raiz1 = (-b + raiz)/2*a;
            double raiz2 = (-b - raiz)/2*a;
           

            return new double[] {raiz1, raiz2};

        }

    }
}
