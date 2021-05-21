#include <stdio.h>

int main()
{

  int numero, i, resultado = 0;

  printf("Informe um numero: ");
  scanf("%d", &numero);

  for (i = 2; i <= numero / 2; i++)
  {
    if (numero % i == 0)
    {
      resultado++;
      break;
    }
  }

  if (resultado == 0)
    printf("%d e primo\n", numero);
  else
    printf("%d não e um numero primo\n", numero);

  return 0;
}