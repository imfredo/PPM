#include <stdio.h>
#include <stdlib.h>

/* Asistentes.
El programa, al recibir como datos la matrícula, la carrera, el semestre
➥y el promedio de un alumno de una universidad privada, determina si
➥éste puede ser asistente de su carrera.
MAT, CAR y SEM: variables de tipo entero.
PRO: variable de tipo real. */

void main(void)
{
    int MAT, CAR, SEM;
    float PRO;

//Ingresar la matricula
    printf("Ingrese la matricula: ");
    scanf("%d", &MAT);

//Ingresar la carrera
    printf("Ingrese la carrera (1-Industrial, 2-Telematica, 3-Computacion, 4-Mecanica): ");
    scanf("%d", &CAR);

//Ingresar el semestre
    printf("Ingrese el semestre: ");
    scanf("%d", &SEM);

//Ingresar el promedio
    printf("Ingrese el promedio: ");
    scanf("%f",&PRO);

    switch(CAR)
    {
        case 1: if(SEM >= 6 && PRO >= 8.5)
        {
            printf("\nSu matricula es:%d \nSu carrera es:%d \nSu promedio es: %5.2f", MAT, CAR, PRO);
            break;
        }
        case 2: if(SEM >= 5 && PRO >= 9.0)
        {
            printf("\n%d %d %5.2f", MAT, CAR, PRO);
            break;
        }
        case 3: if(SEM >= 6 && PRO >= 8.8)
        {
            printf("\n%d %d %5.2f", MAT, CAR, PRO);
            break;
        }
        case 4: if(SEM >= 7 && PRO >= 9.0)
        {
            printf("\n%d %d %5.2f", MAT, CAR, PRO);
            break;
            default: printf("\n Error en la carrera");
            break;
        }



    }

    return 0;
}

