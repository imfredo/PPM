#include <stdio.h>
#include <stdlib.h>

int main()
{
    double x= 0;
    double b = 0;
    printf("Ingrese el numero: ");
    scanf("%lf", &x);
    b = x;
    unsigned int cnt = 0;

     while (!(b == (x/b)))
     {
         b= 0.5* ((x/b)+b);
         cnt++;
         printf("\nValor iteracion %d", cnt);

         printf("\nRaiz de %lf es: %lf",x,b);
     }
     printf("\nRaiz de %lf es: %lf",x,b);

    return 0;
}
