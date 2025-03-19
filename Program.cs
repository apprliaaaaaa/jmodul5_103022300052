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