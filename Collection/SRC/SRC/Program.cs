namespace SRC;

internal class Program
{
    static void Main(string[] args)
    {
        string Phone1 = "01012345678";
        string Phone2 = "+201512345678";
        string Phone3 = "01312345678";
        string Phone4 = "0101234567";
        string Phone5 = "0101234567a";
        Console.WriteLine(Phone1.IsValidEgyptianPhone());//true
        Console.WriteLine(Phone2.IsValidEgyptianPhone());//true
        Console.WriteLine(Phone3.IsValidEgyptianPhone());//false
        Console.WriteLine(Phone4.IsValidEgyptianPhone());//false
        Console.WriteLine(Phone5.IsValidEgyptianPhone());//false
        Console.WriteLine("==================");
        string NationalId1 = "29901011234567";
        string NationalId2 = "19901011234567";
        string NationalId3 = "2990101123456";
        Console.WriteLine(NationalId1.IsValidEgyptianNationalId()); //true
        Console.WriteLine(NationalId2.IsValidEgyptianNationalId()); //true
        Console.WriteLine(NationalId3.IsValidEgyptianNationalId()); //false


    }
}
