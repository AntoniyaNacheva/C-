using System.Collections;

ArrayList myArrayList1 = new ArrayList();
ArrayList myArrayList2 = new ArrayList(100);

myArrayList1.Add(25);
myArrayList1.Add("Hello");
myArrayList1.Add(13.37);
myArrayList1.Add(13);
myArrayList1.Add(128);
myArrayList1.Add(25.3);
myArrayList1.Add(13);

myArrayList1.Remove(13);

myArrayList1.RemoveAt(0);

Console.WriteLine(myArrayList1.Count);

double sum = 0;

foreach(object obj in myArrayList1)
{
    if (obj is int)
    {
        sum+= Convert.ToDouble(obj);
    }
    else if (obj is double) 
    {
        sum += (double)obj;
    }
    else if (obj is string) 
    {
        Console.WriteLine(obj);
    }
}

Console.WriteLine(sum);

Console.ReadKey();


