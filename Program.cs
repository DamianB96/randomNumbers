﻿using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber, attempts = 0;

            Random number = new Random();
            int randomNum = number.Next(1, 100);

            Console.WriteLine("****************************************************" +
                "**********************");
            Console.WriteLine("*Este programa genera un numero aleatorio entre el " +
                "1 y el 100, adivinalo!*");
            Console.WriteLine("****************************************************" +
                "**********************");

            Console.WriteLine("Introduce un numero entre el 1 y el 100.");

            do
            {

                attempts++;

                try
                {
                    myNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No introdujo un valor numerico valido.");
                    Console.WriteLine("Se pondra un 0 en su lugar.");
                    myNumber = 0;
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("Has introducido un valor muy alto.");
                    Console.WriteLine("Se pondra un 0 en su lugar.");
                    myNumber = 0;
                }

                if (myNumber > randomNum) Console.WriteLine("El numero es mas bajo.");

                if (myNumber < randomNum) Console.WriteLine("El numero es mas alto.");

            } while (randomNum != myNumber);

            Console.WriteLine($"Excelente!, encontraste el numero, te tomo {attempts} intentos.");
        }
    }
}
