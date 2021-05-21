#include <stdio.h>
#include <conio.h>


void main()
{
  double dolar;
  double reais = 3.85;

  printf("Digite o valor: ", 162);
  scanf("%lf",&dolar);

  printf("Resultado, R$ %.2lf", dolar*reais);
  
}