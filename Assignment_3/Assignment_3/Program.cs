using System;

namespace Assignment_3
{
    class Program
    {
        //double HI, HIc, HIk;
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
            //ask for temp in f
            Console.WriteLine("What's the current temperature in farenheit?");
            double tempf = Double.Parse(Console.ReadLine());

            // created temperature object
            Temperature T = new Temperature(tempf, 'f');
            double HI, HIc, HIk;


            // if temp gre than 80
            if (tempf >= 80)
            {
                Console.WriteLine("What's the current humidity?");
                double humidity = Double.Parse(Console.ReadLine());
                //if gre 40
                if (humidity > 40)
                {
                    HI = calculateHeatIndex(tempf, humidity);
                    //output in C F and K
                    HIc = Temperature.convertFToC(HI);
                    HIk = Temperature.convertCToK(HIc);
                    Console.WriteLine("Heat Index is {0}f and {1}c and {2}c", HI, HIc, HIk);
                }
                else
                {
                    //output in C F and K
                    Console.WriteLine("The Heat Index is just temperature");
                    HIc = Temperature.convertFToC(tempf);
                    HIk = Temperature.convertCToK(HIc);
                    Console.WriteLine("The current temperature is {0}f, {1}, and {2}c", tempf, HIc, HIk);
                }
            } else if (tempf <= 50){
                Console.WriteLine("What's the current windspeed?");
                double windspeed = Double.Parse(Console.ReadLine());
                //if gre 3
                if (windspeed >= 3)
                {
                    //print out windchill in F C K
                    double WC, WCc, WCk;
                    WC = calculateWindChill(tempf, windspeed);
                    WCc = Temperature.convertFToC(WC);
                    WCk = Temperature.convertCToK(WCc);
                    Console.WriteLine("The current wind chill is {0}f, {1}c, and {2}k", WC, WCc, WCk);
                }
                else
                {
                    Console.WriteLine("There is no WindChill");
                    //print out temp in KCF
                    double tempc, tempk;
                    tempc = Temperature.convertFToC(tempf);
                    tempk = Temperature.convertCToK(tempc);
                    Console.WriteLine("Temperature you entered is {0}f, {1}c and {2}k", tempf, T.getTempInC(), T.getTempInK());
                }

            } else if (tempf > 50 && tempf < 80)
            {
                //print out temp in KCF
                Console.WriteLine("There is currently no HeadIndex nor WindChill.");
                double tempc, tempk;
                tempc = Temperature.convertFToC(tempf);
                tempk = Temperature.convertCToK(tempc);
                Console.WriteLine("Temperature you entered is {0}f, {1}c and {2}k", tempf, T.getTempInC(), T.getTempInK());
            }
        }
    }

    class Temperature
    {
        private double temperature;

        public Temperature() {
            temperature = 72f;

        }

        public Temperature(double newTemperature, char unit) {

            if (unit == 'c') temperature = convertCToF(newTemperature);
            else if (unit == 'k') temperature = convertCToF(convertKToC(newTemperature));

            else temperature = newTemperature;
        }

        static public double convertCToF(double temp)
        {
            return (double)9 / 5 * temp + 32;
        }
        static public double convertFToC(double temp)
        {
            return (temp-32)*(double)5/9;
        }
        public double convertKToC(double temp)
        {
            return temp - 273.15;
        }
        static public double convertCToK(double temp)
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
