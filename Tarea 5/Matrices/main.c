#include<stdio.h>

/* Este programa permite sumar, restar, multiplicar y dividir matrices cuadradas bidimensionales */


void main(void)
{
    /* Declaración de variables de la variables segun sus tipos  */
    float a1, a2, a3, a4;               //La primera matriz
    float b1, b2, b3, b4;               //La segunda matriz
    float suma1, suma2, suma3, suma4;         //La matriz suma
    float resta1, resta2, resta3, resta4;       //La matriz diferencia */
    float multiplicacion1, multiplicacion2, multiplicacion3, multiplicacion4; //La matriz multiplicacion
    float division1, division2, division3, division4; //La division de la matriz

    /* Ingresos de datos para que iran a la memoria*/

    printf("Programa de cálculo matricial");

    printf("\n\nEscriba la primera matriz por filas: ");
    scanf("%f %f %f %f", &a1, &a2, &a3, &a4);

    printf("\n\nEscriba la segunda matriz por filas: ");
    scanf("%f %f %f %f", &b1, &b2, &b3, &b4);

    /* Procesos para el calculo de las diferentes operaciones  */


    /*Suma*/

    suma1 = a1 + b1;
    suma2 = a2 + b2;
    suma3 = a3 + b3;
    suma4 = a4 + b4;

    /*Resta*/

    resta1 = a1 - b1;
    resta2 = a2 - b2;
    resta3 = a3 - b3;
    resta4 = a4 - b4;

    /*Multiplicacion*/

    multiplicacion1 = a1*b1 + a2*b3;
    multiplicacion2 = a1*b2 + a2*b4;
    multiplicacion3 = a3*b1 + a4*b2;
    multiplicacion4 = a3*b3 + a4*b4;

    /*Division*/

    division1 = a1 / b1;
    division2 = a2 / b2;
    division3 = a3 / b3;
    division4 = a4 / b4;

    /* Impresion de resultados */

    printf("\n\nLa matriz suma :\n\n");
    printf("(suma1 = %f suma2 = %f)\n(suma3 = %f suma4 = %f)",
           suma1, suma2, suma3, suma4);

    printf("\n\nLa matriz resta :\n\n");
    printf("(resta1 = %f resta2 = %f)\n(resta3 = %f resta4 = %f)",
           resta1, resta2, resta3, resta4);

    printf("\n\nLa matriz multiplicacion :\n\n");
    printf("(multiplicacion1 = %f multiplicacion2 = %f)\n(multiplicacion3 = %f multiplicacion4 = %f)",
           multiplicacion1, multiplicacion2, multiplicacion3, multiplicacion4);


    printf("\n\nLa matriz division :\n\n");
    printf("(division1 = %f division2 = %f)\n(division3 = %f division4 = %f)",
           division1,division2, division3, division4);

    printf("\n\nTerminacion normal del programa.\n");
}
