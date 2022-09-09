// See https://aka.ms/new-console-template for more information
static void Atividade6()
    {
        Console.WriteLine("\nRetirar as Vogais de uma Frase ou palavra mostrando somente suas consoantes");

        string frase;
        Console.WriteLine("\nDigite a frase desejada: ");
        RetiraVogal(Console.ReadLine());
    }

    static string RetiraVogal(string frase)
    {
        if(frase.Length == 0)
        {
            return "";
        }
        
        char[] cont = frase.ToCharArray();

        if (cont[cont.Length-1]=='a'|| cont[cont.Length - 1] == 'e' || cont[cont.Length - 1] == 'i' || cont[cont.Length - 1] == 'o'|| cont[cont.Length - 1] == 'u')
        {
            Array.Resize(ref cont, cont.Length-1);
        }
        else
        {
            Console.WriteLine(cont[cont.Length-1]);
            Array.Resize(ref cont, cont.Length-1);
        }
        
        frase = new string(cont);
        return RetiraVogal(frase);
    }
