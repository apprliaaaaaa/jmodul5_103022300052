// See https://aka.ms/new-console-template for more information
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
