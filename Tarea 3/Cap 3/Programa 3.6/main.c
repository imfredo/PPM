#include <stdio.h>
#include <stdlib.h>

/* Nómina de profesores.
El programa, al recibir como datos los salarios de los profesores de una
➥universidad, obtiene la nómina y el promedio de los salarios.
I: variable de tipo entero.
SAL, NOM y PRO: variables de tipo real. */

void main(void)
{
    int I = 0;
    float SAL, NOM, PRO = 0;
    printf("Ingrese el salario del profesor:\t ");
    scanf("%f", &SAL);

    do
    {
        NOM = NOM + SAL;
        I = I + 1;
        printf("Ingrese el salario del profesor para terminar:\t ");
        scanf("%f", &SAL);
    }
    while(SAL);
    {
        PRO = NOM / I;
        printf("\nNomina: %.2f \t Promedio de salarios: %.2f", NOM, PRO);


    }

    return 0;
}
