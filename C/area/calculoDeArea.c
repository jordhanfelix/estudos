#include <stdio.h>


void main()
{
  double comprimento;
  double altura;

  printf("Informe o Comprimento: ", 162);
  scanf("%lf",&comprimento);

  printf("Informe o Altura: ", 162);
  scanf("%lf",&altura);

  printf("Area do Retangulo: %.2lf", comprimento * altura);
  printf("\n");
  printf("O Perimetro: %.2lf", ((2*comprimento) + (2*altura)));
  
}