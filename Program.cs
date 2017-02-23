using System;

public class MixedFraction
{

    public string transform_MF(int n, int d){

        string toReturn = (n/d).ToString()+' '+(n%d).ToString()+'/'+d.ToString();   
        return toReturn;

    }

}

public class Program
{
        public static void Main(string[] args)
        {
            MixedFraction mF = new MixedFraction();
            string[] lines = System.IO.File.ReadAllLines("fracciones.in");

            foreach(string actual in lines)
            {

                string[] getNumbers = actual.Split(' ');

                if(getNumbers[0].Equals("0") && getNumbers[1].Equals("0")){
                    break;
                }

                int n = Int32.Parse(getNumbers[0]);
                int d = Int32.Parse(getNumbers[1]);

                Console.WriteLine("Regular Form: "+n+'/'+d);
                Console.WriteLine("Mixed Fraction: "+mF.transform_MF(n,d));
                Console.WriteLine("====================================");

            }

            Console.Read();

        }
        
}