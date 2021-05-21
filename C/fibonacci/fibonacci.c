#include <stdio.h>

int fibonacci(valor)
{

  if ((valor == 1) || (valor == 0))
    return 1;
  else
    return (fibonacci(valor - 1) + fibonacci(valor - 2));
}

main()
{
  int numero;

  printf("Informe a quantidade de termos: ");
  scanf("%d", &numero);

  printf("a sequencia de Fibonacci de %d => ", numero);
  for (int c = 0; c <= numero; c++)
  {
    printf(" %d", fibonacci(c));
  }

  
}
