using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double BMI;


            Console.WriteLine("BMI kalkulačka");
            Console.WriteLine("zadejte váhu v kilogramech");
           weight=double.Parse (Console.ReadLine());
            Console.WriteLine("zadejte výšku v metrech");
            height=double.Parse (Console.ReadLine());

            BMI = weight / (height * height);
            Console.WriteLine();
            BMI = Math.Round(BMI,1);
            Console.WriteLine(BMI);


            if (BMI < (18.5))
            {
                Console.WriteLine("podváha");

            }

            if (BMI < ())
            

           
          
          


            

        }
    }
}
