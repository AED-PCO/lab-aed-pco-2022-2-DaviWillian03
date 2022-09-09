Console.WriteLine("Informe o número");
int primo= int.Parse(Console.ReadLine());
int resultado= ehprimo(primo);
if(resultado==0)
    Console.WriteLine("O número é primo");        
else
    Console.WriteLine("O número não é primo");

int ehprimo(int primo){
    int aux=0;
    for(int i=2; i<primo; i++){
        if(primo%i == 0)
            aux++;
}
    return aux;
}
    for(int i=1; i<1000; i++){
    int b=0;
    for(int j=1; j<i; j++){
        int a=0;
        a = divisor(i,j);
        if(a>0)
            b=soma(b,a);
    }
    if(b==i)
        Console.WriteLine(b);
}

int soma(int x, int y){
    return (x+y);
}

int divisor( int n, int p){
    if(n%p==0)
        return p;
    else
        return 0;
}
