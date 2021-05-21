#include <stdio.h>

int fatorial(valor)
{

  if ((valor == 1) || (valor == 0))
    return 1;
  else
    return fatorial(valor - 1) * valor;
}

main()
{
  int numero;

  printf("Informe o valor: ");
  scanf("%d", &numero);

  printf("O fatorial de %d! => %d \n",numero,fatorial (numero));
}

