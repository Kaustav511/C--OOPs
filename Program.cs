using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcs_ipa
{
    class Program
    {
        static void Main(string[] args)
        {
            Auton[] a = new Auton[4];
            for(int i = 0; i < a.Length; i++)
            {
                int cid = Convert.ToInt32(Console.ReadLine());
                string br = Console.ReadLine();
                int notc=Convert.ToInt32(Console.ReadLine());
                int notp=Convert.ToInt32(Console.ReadLine());
                string env=Console.ReadLine();
                a[i] = new Auton(cid, br, notc, notp, env);
            }
            string envv=Console.ReadLine();
            string brr=Console.ReadLine();
            int res1 = func1(a, envv);
            if (res1 == 0)
            {
                Console.WriteLine("There are no tests passed in this particular environment");
            }
            else
            {
                Console.WriteLine(res1);
            }
            Auton res2 = func2(a, brr);
            if (res2 == null)
            {
                Console.WriteLine("No Car is available with the specified brand");
            }
            else
            {
                Console.WriteLine(res2.br + "::" +res2.gr);
            }
        }
        static int func1(Auton[] a,string envv)
        {
            int sum = 0;
            for(int i=0;i<a.Length; i++)
            {
                if (a[i].env.Equals(envv))
                {
                    sum += a[i].notp;
                }
            }
            return sum;
        }
        static Auton func2(Auton[] a,String brr)
        {
            int grade;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i].br.Equals(brr))
                {
                    grade = a[i].notp / a[i].notc;
                    if (grade >= 80)
                    {
                        a[i].setgr("A1");
                    }
                    else
                    {
                        a[i].setgr("B2");
                    }
                    return a[i];
                }
            }
            return null;
        }
    }
    class Auton
    {
        public int cid, notc, notp;
        public string br, env, gr;
        public Auton(int cid,string br,int notc,int notp,string env)
        {
            this.cid = cid;
            this.br = br;
            this.notc = notc;
            this.notp = notp;
            this.env = env;
            //this.gr = gr;
        }
        public void setgr(string gr)
        {
            this.gr = gr;
        }
    }
}
