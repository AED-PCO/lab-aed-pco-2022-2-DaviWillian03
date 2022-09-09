//exercicio fatorial

    int n, res=0;
    Console.WriteLine("Insira um numero inteiro:");
        n = int.Parse(Console.ReadLine());

    int fatorial (int n){
        if(n==2)
            return(2);
    int auxiliar = 0;
        auxiliar=n*fatorial (n-1);
            return (auxiliar);
    }

    res = fatorial(n);
    Console.WriteLine("O fatorial de {0} é {1}", n, res);

        }

    }

}