using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string Nombre;
            int ConsignarDinero=0;
            char Consignar;
            char Retirar;
            long NumeroCuenta;
            int RetirarDinero = 0;
            int SaldoApertura=0;
            int RetiroDefinitivo = 0;
          

            Console.WriteLine("POR FAVOR DIGITE EL NOMBRE DEL CLIENTE:  ");
            Nombre = Console.ReadLine();
            Console.WriteLine("POR FAVOR INGRESAR EL NUMERO DE LA CUENTA:  ");
            NumeroCuenta = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE EL SALDO QUE TENDRA LA CUENTA:  ");
            SaldoApertura = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

            Console.WriteLine("DESEA REALIZAR UNA CONSIGNACION EN LA CUENTA? (S O N) ");
            Consignar = Convert.ToChar(Console.ReadLine());

            if( Consignar == 'S')
            {
              
                Console.WriteLine("POR FAVOR DIGITE LA CANTIDAD A CONSIGNAR: ");
                ConsignarDinero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("LA CONSIGNACION SE REALIZO DE MANERA EXITOSA");   
            }
            Console.WriteLine("EL SALDO DE LA CUENTA ACTUALMENTE ES: " + (SaldoApertura+ConsignarDinero));
            Console.ReadKey();

            RetiroDefinitivo = (SaldoApertura + ConsignarDinero);

            Console.WriteLine("DESEA REALIZAR UN RETIRO DE DINERO DE LA CUENTA? : (S O N) ");
            Retirar = Convert.ToChar(Console.ReadLine());

            if(Retirar == 'S')
            {
                Console.WriteLine("POR FAVOR DIGITE LA CANTIDAD A RETIRAR DE LA CUENTA: ");
                RetirarDinero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("EL RETIRO SE REALIZO DE MANERA CORRECTA");
            }
            Console.WriteLine("EL SALDO DE LA CUENTA DESPUES DEL RETIRO ES: " + (RetiroDefinitivo-RetirarDinero));
            Console.ReadKey();
        }  
    }
}
