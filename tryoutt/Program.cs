using System.Runtime.CompilerServices;

Console.Write("masukan nama : ");
string nama = Console.ReadLine();
Console.Write("masukan Nilai Hairan : ");
int nilaiHarian = Convert.ToInt32(Console.ReadLine());
Console.Write("masukan Nilai UTS : ");
int nilaiUts = Convert.ToInt32(Console.ReadLine());
Console.Write("masukan Nilai Uas : ");
int nilaiUas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("_________________");

Console.WriteLine("Nama : " + nama);
Console.WriteLine("Nilai Harian : " + nilaiHarian);
Console.WriteLine("Nilai Uts : " + nilaiUts);
Console.WriteLine("Nilai Uas : " + nilaiUas);

int rata = (nilaiHarian + nilaiUts + nilaiUas)/3;

if(rata >= 80)
{
    Console.WriteLine("Nilai Rata - rata : " + rata);
    Console.WriteLine("Predikat A");
}
else if(rata >= 70)
{
    Console.WriteLine("Nilai Rata - rata : " + rata);
    Console.WriteLine("Predikat B");
}

else if (rata >= 60)
{
    Console.WriteLine("Nilai Rata - rata : " + rata);
    Console.WriteLine("Predikat C");
}

else if (rata >= 50)
{
    Console.WriteLine("Nilai Rata - rata : " + rata);
    Console.WriteLine("Predikat D");
}

else
{
    Console.WriteLine("Nilai Rata - rata : " + rata);
    Console.WriteLine("Predikat E");
}

Console.ReadKey();