using System;
using static System.Console;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;//variables para guardar los numeros ingresados por el usuario
            Decimal rest, numero1, numero2;//variables con las cuales se lleva a cabo todo el proceso del programa
            Decimal [] numerosAUtilizar = new decimal[256];//este arreglo guarda los numeros de 0 a 255
            //los deja como una lista de elementos elegibles
            for(int i=0; i<=255; i++)
            {
                numerosAUtilizar[i]=Decimal.Parse(i.ToString());//aqui se convierte primero el entero generado por el For
                //pasa a ser String para despues parsearlo a Decimal 
                //ya que no se puede hacer la conversion implicita int-Decimal
            }
            //termina llenado de la lista
            WriteLine("Ingrese primer numero de la division");
            num1=ReadLine();
            WriteLine("Ingrese segundo numero de la division");
            num2=ReadLine();
            //se guardan los numeros elegidos por el usuarioo
            try 
            {
                numero1 = numerosAUtilizar[int.Parse(num1)]; 
                numero2 = numerosAUtilizar[int.Parse(num2)];
                //las dos lineas anteriores acceden al arreglo en la posicion que indican los numeros elegidos
                //por el usuario y guarda el contenido de esa en las variables que se usaran en la operacion 
                WriteLine($"Números ingresados: {numero1} || {numero2}");
                rest=numero1/numero2;
                WriteLine($"{rest}");//Impresion de resultado
            }
            catch(DivideByZeroException)
            {
                WriteLine("Division por cero no es posible");
            }
            catch(FormatException)
            {
                WriteLine("El formato no es correcto");
            }
            catch(OverflowException)
            {
                WriteLine("El numero ingresado o el resultado está fuera de rango");
            }
            catch(IndexOutOfRangeException) when(int.Parse(num1)<0||int.Parse(num1)>255)
            {
                WriteLine("El primer numero ingresado está fuera de los parametros permitidos");
            }
            catch(IndexOutOfRangeException) when(int.Parse(num2)<0||int.Parse(num2)>255)
            {
                WriteLine("El segundo numero ingresado está fuera de los parametros permitidos");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} dice {ex.Message}");
            }
        }
    }
}
