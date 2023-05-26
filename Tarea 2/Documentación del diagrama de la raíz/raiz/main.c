#include <stdio.h>
#include <stdlib.h>

int main()
{
    float x = 0;
    float b = 0;

    printf("Ingrese el Numero\n");
    scanf("%f",&x);
    b = x;

    while(!b == (x/b))
    {
        b = 0.5 * ((x/b)+b);
    }
    printf("Raiz de %f es: %f", x, b);

    return 0;

}
