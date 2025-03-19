// See https://aka.ms/new-console-template for more information

class PemrosesData
{

    public T DapatkanNilaiTerbesar <T>(T nilai1, T nilai2 , T nilai3)
    {
        dynamic temp = (dynamic) nilai1;
        dynamic temp2 = (dynamic)nilai2;
        dynamic temp3 = (dynamic)nilai3;
       
        if (temp > temp2 && temp > temp3)
        {
            return nilai1;
        }
        else if (temp2 > temp && temp2 > temp3)
        {
            return nilai2;
        }
        else
        {
            return nilai3;
        }
    }


}

    class Program
{
    static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
       
        //103022300052
        Console.WriteLine(pemrosesData.DapatkanNilaiTerbesar(3.0, 0.0, 5.2));
      
    }
}

using System;
using System.Net.Mail;

public class Program
{
    class simpleDataBase<T>
    {
        private List<T> storedData = new List<T>();
        private List<DateTime> inputDates = new List<DateTime>();
        public void SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data: " + storedData[i] + " | Date: " + inputDates[i]);
            }
        }
    }

    public static void Main(string[] args)
    {
        simpleDataBase<int> db = new simpleDataBase<int>();
        db.addNewData(12);
        db.addNewData(34);
        db.addNewData(56);

        db.printAllData();
    }
}

