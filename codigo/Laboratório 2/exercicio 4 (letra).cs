// See https://aka.ms/new-console-template for more information
 int numeroLetras (string frase, char letra){
        if (frase == "")
            return (0);
        else if (frase [0] == letra)
            return numeroLetras (frase.Substring (1), letra) + 1;
        else 
            return numeroLetras (frase.Substring (1), letra);
    }

    string frase;
    char letra;
    Console.WriteLine("Informe a frase:");
        frase = Console.ReadLine();
        
    Console.WriteLine("Informe a letra:");
        letra=char.Parse(Console.ReadLine());

    int n = numeroLetras(frase, letra);
        Console.WriteLine("A frase {0} tem {1} letras {2}", frase, n, letra);
