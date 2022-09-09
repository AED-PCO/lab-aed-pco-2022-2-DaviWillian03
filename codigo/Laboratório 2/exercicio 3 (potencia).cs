// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite dois números inteiros, sendo que o primeiro será elevado ao segundo:");
                int numA = int.Parse(Console.ReadLine());
                Console.WriteLine("^");
                int numB = int.Parse(Console.ReadLine());

                static int exp(int num1, int num2){
                    if(num2 == 1){
                        return num1;
                    }
                    else{
                        int aux = num1 * exp(num1, (num2 - 1));
                        return aux;
                    }
                }

                Console.WriteLine($"{numA} ^ {numB} = {exp(numA, numB)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
