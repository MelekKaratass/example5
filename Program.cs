//A B C D ŞUBESİ    -> Sınıf mevcudu


int A, B, C, D;
char sube;
Console.WriteLine("Lütfen A şubesinin sınıf mevcudunu giriniz.");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen B şubesinin sınıf mevcudunu giriniz.");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen C şubesinin sınıf mevcudunu giriniz.");
C = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen D şubesinin sınıf mevcudunu giriniz.");
D = int.Parse(Console.ReadLine());

Console.WriteLine("Hangi sınıftaki mevcudu merak ediyorsunuz.A-B-C-D");
sube = char.Parse(Console.ReadLine().ToUpper());

switch (sube)
{
    case 'A':
        Console.WriteLine(A);
        break;

    case 'B':
        Console.WriteLine(B);
        break;
    case 'C':
        Console.WriteLine(C);
        break;
    case 'D':
        Console.WriteLine(D);
        break;
    default:
        Console.WriteLine("Sadece A-B-C-D sınıfları mevcuttur.");
        break;

}

