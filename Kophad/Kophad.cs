using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kophad
{
    public class Kophad
    {
        private string qosh = "";
        private string ayir = "";
        private string kop = "";
        private double qiymat = 0;
        private double qiymat2 = 0;
        public Kophad(string p1,string p2,int value)
        {
            string[] p11 = p1.Split('+');
            string[] p22 = p2.Split('+');
            if (p11.Length >= p22.Length)
            {
                for (int i = 0; i < p11.Length; i++)
                {
                    for (int j = 0; j < p22.Length; j++)
                    {
                            Qosh(p11[i], p22[j]);
                            Ayir(p11[i], p22[j]);
                       
                        
                        Kopay(p11[i], p22[j]);
                    }
                   
                }
            }
            for (int i = 0; i < p11.Length; i++)
            {
                Qiymat(p11[i], value);
            }
            for (int i = 0; i < p22.Length; i++)
            {
                Qiymat2(p22[i], value);
            }
            Console.WriteLine("P(x)+Q(x)="+qosh);
            Console.WriteLine("P(x)-Q(x)="+ayir);
            Console.WriteLine("P(x)*Q(x)="+kop);
            Console.WriteLine("P(a):="+qiymat);
            Console.WriteLine("Q(a):="+qiymat2);
        }
        public bool Qosh(string p1,string p2)
        {
            string[] p11 = p1.Split('*', '^');
            string[] p22= p2.Split('*', '^');
            if (p11[2]==p22[2])
            {
                qosh +="+"+ (int.Parse(p11[0]) + int.Parse(p22[0])).ToString() +"*"+ p11[1] + "^" + p11[2];
                return true;
            }
            return false;
        }
        public bool Ayir(string p1, string p2)
        {
            string[] p11 = p1.Split('*', '^');
            string[] p22 = p2.Split('*', '^');
            if (p11[2] == p22[2])
            {
                ayir += "+" + (int.Parse(p11[0]) - int.Parse(p22[0])).ToString() + "*" + p11[1] + "^" + p11[2];
                return true;
            }
            return false;
        }
        public void Kopay(string p1, string p2)
        {
            string[] p11 = p1.Split('*', '^');
            string[] p22 = p2.Split('*', '^');
                kop += "+" + (int.Parse(p11[0])*int.Parse(p22[0])).ToString() 
                    + "*" + p11[1] + "^" + (int.Parse(p11[2])+int.Parse(p22[2]));
        }
        public void Qiymat(string p1,int value)
        {
            string[] p11 = p1.Split('*', '^');
            qiymat += int.Parse(p11[0]) * Math.Pow(value, int.Parse(p11[2]));
        }
        public void Qiymat2(string p1, int value)
        {
            string[] p11 = p1.Split('*', '^');
            qiymat2 += int.Parse(p11[0]) * Math.Pow(value, int.Parse(p11[2]));
        }
    }
}
