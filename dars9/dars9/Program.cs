using System.Collections;

namespace dars9;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.Add(5);

        //foreach (var item in arrayList)
        //{
        //    Console.WriteLine(item);
        //}

        //var sum = arrayList.Count;
        //Console.WriteLine(sum);

        //var third = arrayList[2];
        //Console.WriteLine(third);

        ArrayList arrayList2 = new ArrayList();
        arrayList2.Add("mouse");
        arrayList2.Add("computer");
        arrayList2.Add("Laptop");
        arrayList2.Add(4);
        arrayList2.Add(5);

        //foreach (var item in arrayList2)
        //{
        //    Console.WriteLine(item);
        //}

        //if (arrayList2.Contains("mous"))
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //arrayList2.Remove("mouse");

        //arrayList2.Clear();   

        arrayList.Add(6);
        arrayList.Add(7);
        arrayList.Add(8);
        arrayList.Add(9);
        arrayList.Add(10);

        //var sum = 0;

        //foreach (var item in arrayList)
        //{
        //    sum += (int)item;
        //}
        //Console.WriteLine(sum);

        //for (int i = 0; i < arrayList.Count; i++)
        //{
        //    Console.WriteLine(arrayList[i]);
        //}

        //var sum = 0;
        //foreach (var item in arrayList2)
        //{
        //    if (item is int)
        //    {
        //        sum += (int)item;
        //    }
        //}
        //Console.WriteLine(sum);


        //var big = arrayList[0];
        //foreach (var item in arrayList)
        //{
        //    if (item is int)
        //    {
        //        big = item;
        //    }
        //}
        //Console.WriteLine(big);

        //ArrayList arrayList3 = new ArrayList();
        //foreach (var item in arrayList)
        //{
        //    if (item is int)
        //    {
        //        if ((int)item % 2 == 0)
        //        {
        //            arrayList3.Add(item);
        //        }
        //    }
        //}

        //foreach (var item in arrayList3)
        //{
        //    Console.WriteLine(item);
        //}

        //arrayList.Reverse();
        //foreach (var item in arrayList)
        //{
        //    Console.WriteLine(item);
        //}

        //arrayList.Sort();
        //foreach (var item in arrayList)
        //{
        //    Console.WriteLine(item);
        //}
    }
}