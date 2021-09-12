using System;

namespace Assignment_3
{
    class Program
    {
        //takes in two doubles
        static double calculateHeatIndex(double T, double R)
        {
            //input constants

            double c1 = -42.379;
            double c2 = 2.04901523;
            double c3 = 10.14333127;
            double c4 = -0.22475541;
            double c5 = -0.00683783;
            double c6 = -0.05481717;
            double c7 = 0.0012274;
            double c8 = 0.00085282;
            double c9 = -0.00000199;

            //fomula is:
            //c1 + c2*T + c3*R + c4*T*R + c5*T^2+ c6*R^2+ c7*T^2*R+c8*T*R^2+ c9*T^2*R^2

            //use regex to swap formula

            return c1 + c2 * T + c3 * R + c4 * T * R + c5 * Math.Pow(T, 2) + c6 * Math.Pow(R, 2) + c7 * Math.Pow(T, 2) * R + c8 * T * Math.Pow(R, 2) + c9 * Math.Pow(T, 2) * Math.Pow(R, 2);
        }

        //takes in two doubles
        static double calculateWindChill(double T, double W)
        {
            //fomula for windchill is 35.74 + 0.6215*T - 35.75 * (W^0.16) + 0.4275 * T * (W^0.16)
            return 35.74 + 0.6215 * T - 35.75 * Math.Pow(W,0.16) + 0.4275 * T * Math.Pow(W, 0.16);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What's the current temperature in farenheit?");
            double tempf = Double.Parse(Console.ReadLine());
            Temperature T = new Temperature(tempf, 'f');


            // if temp gre than 80
            if (tempf > 80)
            {
                Console.WriteLine("What's the current humidity?");
                double humidity = Double.Parse(Console.ReadLine());
                if (humidity > 40)
                {
                    calculateHeatIndex(tempf, humidity);
                }
            }
        }
    }

    class Temperature
    {
        private double temperature;

        public Temperature() {
            temperature = 73f;

        }

        public Temperature(double newTemperature, char unit) {

            if (unit == 'c') temperature = convertCToF(newTemperature);
            else if (unit == 'k') temperature = convertCToF(convertKToC(newTemperature));

            else temperature = newTemperature;
        }

        public double convertCToF(double temp)
        {
            return 9 / 5 * temp + 32;
        }
        public double convertFToC(double temp)
        {
            return 5/9 *(temp-32);
        }
        public double convertKToC(double temp)
        {
            return temp - 273.15;
        }
        public double convertCToK(double temp)
        {
            return temp + 273.15;
        }
        public double getTempInF()
        {
            //return the object temp in fahrenheit
            return temperature;
        }
        public double getTempInC()
        {
            //return the object temp in C
            return convertFToC(temperature);
        }
        public double getTempInK()
        {
            //return the object temp in K
            return convertCToK(convertFToC(temperature));
        }

    }
}
