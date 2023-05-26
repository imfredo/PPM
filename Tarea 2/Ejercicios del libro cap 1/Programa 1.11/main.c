#include <stdio.h>
#include <math.h>
/* Perímetro del triángulo.
El programa, al recibir las coordenadas de los puntos P1, P2 y P3 que
➥corresponden a los vértices de un triángulo, calcula su perímetro.
X1, Y1, X2, Y2, X3, Y3, LA1, LA2, LA3 y PER: variables de tipo real.*/

void main (void)
{
    float X1, Y1, X2, Y2, X3, Y3, LA1, LA2, LA3, PER;
    printf("Ingrese la coordenada del punto 1: ");
    scanf("%f %f", &X1,&Y1);
    printf("Ingrese la coordenada del punto 2: ");
    scanf(" %f %f", &X2,&Y2);
    printf("Ingrese la coordenada del punto 3: ");
    scanf(" %f %f", &X3,&Y3);
    LA1 = (pow(X1-X2, 2) + (Y1-Y2, 2));
    LA2 = (pow(X2-X3, 2) + (Y2-Y3, 2));
    LA3 = (pow(X1-X3, 2) + (Y1-Y3, 2));
    PER = (LA1 + LA2 + LA3);
    printf("\nEl perimetro del triangulo es: %6.3f", PER);
}

