using System;

namespace console_examples
{
    class _Program
{
    static void Main(string[] args)
    {
        string continueKey = "";
        do
        {
            Calculation();

            Console.WriteLine("Cikis yapmak icin x\'e basiniz");
            continueKey = Console.ReadLine();

        } while (continueKey != "x");

    }

    public static void ShowNumbers()
    {
        Console.WriteLine("Lutfen bir sayi giriniz.");
        //var ilkSayi = Console.ReadKey();
        //var IlkSayi = 0; Pascal case
        //var ilkSayi = Console.ReadLine(); Camel case
        //var ilk_sayi = Console.ReadLine(); snake case


        var firstNumber = Console.ReadLine();

        Console.WriteLine("Lütfen ikinci sayı giriniz.");
        var secondNumber = Console.ReadLine();

        Console.WriteLine("Girdiginiz sayilar =" + firstNumber + " " + secondNumber);

        Console.ReadLine();
    }

    public static void ParseInteger()
    {
        Console.WriteLine("Lutfen bir sayi giriniz.");


        string firstNumber = Console.ReadLine();

        Console.WriteLine("Lütfen ikinci sayı giriniz.");
        var secondNumber = Console.ReadLine();

        //int parsedFirstNumber = int.Parse(firstNumber);
        //int parsedSecondNumber = int.Parse(secondNumber);

        int parsedFirstNumber = 0, parsedSecondNumber = 0;
        Console.WriteLine(parsedFirstNumber);
        bool isSuccess = int.TryParse(firstNumber, out parsedFirstNumber);
        Console.WriteLine(parsedFirstNumber);
        bool isSuccessSecond = int.TryParse(secondNumber, out parsedSecondNumber);

        Console.WriteLine("Girdiginiz sayilar =" + (parsedFirstNumber + parsedSecondNumber));
    }
    public static void WhileLoop()
    {
        int iterator = 0;

        while (iterator < 10)
        {
            Console.WriteLine("Donguye devam iterator = " + iterator);
            iterator++;
        }

        Console.WriteLine("Dongu bitti iterator= " + iterator);

    }

    public static void NumberValidation()
    {
        int parsedFirstNumber = 0, parsedSecondNumber = 0;
        string firstNumber = "", secondNumber = "";
        bool isSuccess = false, isSuccessSecond = false;

        do
        {
            Console.WriteLine("Lutfen bir sayi giriniz.");
            firstNumber = Console.ReadLine();
            isSuccess = int.TryParse(firstNumber, out parsedFirstNumber);
        }
        while (!isSuccess);


        do
        {
            Console.WriteLine("Lutfen ikinci sayiyi giriniz.");
            secondNumber = Console.ReadLine();
            isSuccessSecond = int.TryParse(secondNumber, out parsedSecondNumber);
        }
        while (!isSuccessSecond);


        Console.WriteLine("Girdiginiz sayilarin toplami =" + (parsedFirstNumber + parsedSecondNumber));

        Console.ReadLine();
    }

    /// <summary>
    /// bu fonksiyon switch case ornegidir.
    /// </summary>
    public static void SwitchCase()
    {
        int parsedFirstNumber = 0, parsedSecondNumber = 0;
        string firstNumber = "", secondNumber = "", symbol = "";
        bool isSuccess = false, isSuccessSecond = false;

        do
        {
            Console.WriteLine("Lutfen bir sayi giriniz.");
            firstNumber = Console.ReadLine();
            isSuccess = int.TryParse(firstNumber, out parsedFirstNumber);
        }
        while (!isSuccess);


        do
        {
            Console.WriteLine("Lutfen ikinci sayiyi giriniz.");
            secondNumber = Console.ReadLine();
            isSuccessSecond = int.TryParse(secondNumber, out parsedSecondNumber);
        }
        while (!isSuccessSecond);

        do
        {
            Console.WriteLine("Lütfen bir islem seciniz.");
            Console.WriteLine("Toplama icin 1.");
            Console.WriteLine("Cikarma icin 2.");
            Console.WriteLine("Carpma icin 3.");
            Console.WriteLine("Bolme icin 4.");

            symbol = Console.ReadLine();
        }
        while (symbol != "1" && symbol != "2" && symbol != "3" && symbol != "4");

        decimal result = 0;

        switch (symbol)
        {
            case "1":
                result = parsedFirstNumber + parsedSecondNumber;
                break;
            case "2":
                result = parsedFirstNumber - parsedSecondNumber;
                break;
            case "3":
                result = parsedFirstNumber * parsedSecondNumber;
                break;
            case "4":
                result = parsedFirstNumber / parsedSecondNumber;
                break;
            default:
                Console.WriteLine("!!!Farklı bir islem girildi");
                break;
        }

        Console.WriteLine("Girdiginiz islemin sonucu =" + result);

        Console.ReadLine();
    }

    public static void Calculation()
    {
        int parsedFirstNumber = 0, parsedSecondNumber = 0;
        string firstNumber = "", secondNumber = "", symbol = "";
        bool isSuccess = false, isSuccessSecond = false;

        do
        {
            Console.WriteLine("Lutfen bir sayi giriniz.");
            firstNumber = Console.ReadLine();
            isSuccess = int.TryParse(firstNumber, out parsedFirstNumber);
        }
        while (!isSuccess);


        do
        {
            Console.WriteLine("Lutfen ikinci sayiyi giriniz.");
            secondNumber = Console.ReadLine();
            isSuccessSecond = int.TryParse(secondNumber, out parsedSecondNumber);
        }
        while (!isSuccessSecond);

        do
        {
            Console.WriteLine("Lütfen bir islem seciniz.");
            Console.WriteLine("Toplama icin 1.");
            Console.WriteLine("Cikarma icin 2.");
            Console.WriteLine("Carpma icin 3.");
            Console.WriteLine("Bolme icin 4.");
            Console.WriteLine("Ussunu almak icin 5.");
            Console.WriteLine("Karekokunu almak icin 6.");
            Console.WriteLine("Modunu almak icin 7.");

            symbol = Console.ReadLine();
        }
        while (symbol != "1"
        && symbol != "2"
        && symbol != "3"
        && symbol != "4"
        && symbol != "5"
        && symbol != "6"
        && symbol != "7");

        decimal result = 0;

        switch (symbol)
        {
            case "1":
                result = parsedFirstNumber + parsedSecondNumber;
                Console.WriteLine("Girdiginiz toplama isleminin sonucu =" + result);
                break;
            case "2":
                result = parsedFirstNumber - parsedSecondNumber;
                Console.WriteLine("Girdiginiz cikarma isleminin sonucu =" + result);
                break;
            case "3":
                result = parsedFirstNumber * parsedSecondNumber;
                Console.WriteLine("Girdiginiz carpma isleminin sonucu =" + result);
                break;
            case "4":
                result = parsedFirstNumber / parsedSecondNumber;
                Console.WriteLine("Girdiginiz bolme isleminin sonucu =" + result);
                break;
            case "5":
                result = (decimal)Math.Pow(parsedFirstNumber, parsedSecondNumber);
                Console.WriteLine("Girdiginiz ussunu alma isleminin sonucu =" + result);
                break;
            case "6":
                result = (decimal)Math.Sqrt(parsedFirstNumber);
                Console.WriteLine("Girdiginiz karekok isleminin sonucu =" + result);
                break;
            case "7":
                result = parsedFirstNumber % parsedSecondNumber;
                Console.WriteLine("Girdiginiz mod isleminin sonucu =" + result);
                break;
            default:
                Console.WriteLine("Girdiginiz islemin sonucu =" + (parsedFirstNumber + parsedSecondNumber));
                Console.WriteLine("Girdiginiz islemin sonucu =" + (parsedFirstNumber - parsedSecondNumber));
                Console.WriteLine("Girdiginiz islemin sonucu =" + (parsedFirstNumber * parsedSecondNumber));
                Console.WriteLine("Girdiginiz islemin sonucu =" + (parsedFirstNumber / parsedSecondNumber));

                break;
        }

    }
}
}
