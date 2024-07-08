using System;

namespace PrimeFactors
{
    public class Functions
    {   
        int [] ArrayNP = new int[168];//arreglo donde se guardan todos los numeros primos del 1 al 1000
        public string SacarFactores(int numeroIng)
        {   
            ObtenerNmPr();//Llena el arreglo antes de empezar a descomponer el numero ingresado
            int posArray=0;//determina la posicion del arreglo que se va a utilizar
            string factoresObtenidos="";
            while(numeroIng>1)
            {
                while(numeroIng%ArrayNP[posArray]==0)
                {
                    factoresObtenidos+="|"+ArrayNP[posArray].ToString();
                    numeroIng=numeroIng/ArrayNP[posArray];//Se hace la division del numero 
                                                          //ingresado hasta el punto en que sea 1
                }
                posArray++;//Una vez que ya no se puede hacer una division exacta aumenta el 
                            //aumenta el contador para seleccionar el siguiente numero primo
            }
            return factoresObtenidos;
        }
        public void ObtenerNmPr()
        {   //Funcion que sirve para llenar un arreglo con todos los numeros primos del 1 al 100
            //El algoritmo se basa en la caracteristica de que un numero primo solo se divide sin dejar
             //residuo por 2 numeros es decir entre si mismo y 1
            int divisor, numero=2, check=0, pos=0;
            while (numero<=1000)
            {
                for(divisor=1; divisor<=numero; divisor++) //Ciclo que se encarga de dividir al numero por 
                                                            //todos sus antecesores
                {
                    if(numero%divisor==0)
                    {
                        check++;
                    }
                    if(check>2)
                    //si el numero en turno se dividió sin dejar residuo
                    //por mas de 2 numeros este no es primo
                    //sale del bucle sin necesidad de hacer el todo el conteo
                    {
                        break;
                    }
                }
                if(check==2)
                //si el numero en turno solo se dividió exactamente por 2 numeros
                //es decir por 1 y por si mismo este numero si es primo
                {
                    ArrayNP[pos]=numero;
                    pos++;
                }
                check=0;
                numero++;
            }
        }
    }
}
