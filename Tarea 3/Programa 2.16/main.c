#include <stdio.h>
#include <stdlib.h>

/* Empresa textil.
El programa, al recibir como datos decisivos la categoría y antigüedad de
➥un empleado, determina si el mismo reúne las condiciones establecidas por
➥la empresa para ocupar un nuevo cargo en una sucursal.
CLA, CAT, ANT, RES: variables de tipo entero.
SAL: variable de tipo real. */

void main(void)
{
    int CLA, CAT, ANT, RES;
    //float SAL;
    printf("\nIngrese la clave, categoria y antiguedad del trabajador:");
    scanf("%d %d %d", &CLA, &CAT, &ANT);

    switch(CAT)
    {
        case 3:
        case 4: if(ANT >= 5)
        {
            RES = 1;

        }
        else
        {
            RES = 0;
            printf("\nEl trabajador con clave: %d no reune las condiciones para el puesto",CLA);
            break;
        }
        case 2: if(ANT >= 7)
        {
            RES = 1;
        }
        else
        {
            RES = 0;
            break;
            default: RES = 0;
            break;
        }
        if(RES)
        {
            printf("\nEl trabajador con clave: %d reune las condiciones para el puesto",CLA);

        }
        else
        {
            printf("\nEl trabajador con clave: %d no reune las condiciones para el puesto",CLA);
        }
    }
    return 0;
}
