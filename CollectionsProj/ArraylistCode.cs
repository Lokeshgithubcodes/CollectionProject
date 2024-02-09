//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CollectionsProj
//{
//    class Demo<T>
//    {
//        //public bool Compare(object a, object b)
//        //{
//        //    if(a.Equals(b)) return true;  
//        //    return false;
//        //}
//        //public bool Compare<T>(T a, T b)
//        //{
//        //    if(a.Equals(b)) return true;
//        //    return false;
//        //}

//        public void add(T a, T b)
//        {
//            dynamic d1 = a;
//            dynamic d2 = b;
//            Console.WriteLine("Sum= " + d1 + d2);
//        }
//        public void sub(T a, T b)
//        {
//            dynamic d1 = a;
//            dynamic d2 = b;
//            Console.WriteLine("Sub=" + (d1 - d2));
//        }

//        public void mul(T a, T b)
//        {
//            dynamic d1 = a;
//            dynamic d2 = b;
//            Console.WriteLine("Mul=" + (d1 * d2));
//        }

//        public void div(T a, T b)
//        {
//            dynamic d1 = a;
//            dynamic d2 = b;
//            Console.WriteLine("div" + (d1 / d2));
//        }



//        static void Main(string[] args)
//        {
//            //Hashtable ht=new Hashtable();
//            //ht.Add("Eid", 101);
//            //ht.Add("Ename", "Lokesh");
//            //ht.Add("Salary", 400000);
//            //ht.Add("loc", "Blore");
//            //ht.Add("kdvs", null);
//            //foreach(object Key in ht.Keys)
//            //{
//            //    Console.WriteLine(Key+":"+ht[Key]);
//            //}

//            //ArrayList al=new ArrayList();
//            //al.Add(100);
//            //al.Add(200);
//            //al.Add(300);
//            //al.Add(400);
//            //al.Remove(200);
//            //foreach(object obj in al)
//            //{
//            //    Console.WriteLine(obj+" ");
//            //}

//            //List<int> l=new List<int>();
//            //l.Add(10);
//            //l.Add(20);
//            //l.Add(48);
//            //l.Add(45);
//            //l.Add(35);
//            //l.Insert(3,57);
//            //l.RemoveAt(4);

//            //foreach(int i in l)
//            //{
//            //    Console.Write(i+" ");
//            //}

//            //ArraylistCode c=new ArraylistCode();
//            //bool res=c.Compare("lokesh", "lokesh");

//            //Console.WriteLine(res);

//            //Demo d = new Demo();
//            //bool res = d.Compare<int>(10, 10);
//            //Console.WriteLine(res);
//            //bool res1 = d.Compare<float>(10.13f, 20.34f);
//            //Console.WriteLine(res1);

//            Demo<int> d = new Demo<int>();
//            d.add(10, 20);
//            d.sub(8, 6);
//            d.mul(10, 20);
//            d.div(10, 20);

//        }
//    }

//}
