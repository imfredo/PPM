#include <stdio.h>

#define PRECIO_GALON 192.00
#define KILOMETROS_POR_LITRO 100.00

typedef struct {
    char nombre[50];
    float distancia;
    float consumo;
    float gastos_varios;
    float total_gastos;
} Cliente;

int main() {
    Cliente clientes[10];
    int num_clientes;

    printf("Ingrese el numero de clientes (maximo 10): ");
    scanf("%d", &num_clientes);

    // Verificar que el número de clientes sea válido
    if (num_clientes < 1 || num_clientes > 10) {
        printf("Numero de clientes invalido. Saliendo del programa.\n");
        return 0;
    }

    // Ingresar los datos de los clientes
    for (int i = 0; i < num_clientes; i++) {
        printf("\nCliente %d:\n", i + 1);

        printf("Nombre: ");
        scanf("%s", clientes[i].nombre);

        printf("Distancia recorrida (km): ");
        scanf("%f", &clientes[i].distancia);

        printf("Consumo promedio de gasolina (litros/100km): ");
        scanf("%f", &clientes[i].consumo);

        printf("Gastos varios: ");
        scanf("%f", &clientes[i].gastos_varios);

        // Calcular el total de gastos
        float litros_gasolina = (clientes[i].distancia / KILOMETROS_POR_LITRO) * clientes[i].consumo;
        clientes[i].total_gastos = (litros_gasolina * PRECIO_GALON) + clientes[i].gastos_varios;
    }

    // Imprimir los resultados
    printf("\n\n--- Resultados ---\n");
    for (int i = 0; i < num_clientes; i++) {
        printf("\nCliente %d:\n", i + 1);
        printf("Nombre: %s\n", clientes[i].nombre);
        printf("Distancia recorrida (km): %.2f\n", clientes[i].distancia);
        printf("Consumo promedio de gasolina (litros/100km): %.2f\n", clientes[i].consumo);
        printf("Gastos varios: %.2f\n", clientes[i].gastos_varios);
        printf("Total de gastos: %.2f\n", clientes[i].total_gastos);


    }
    printf("\nGRACIAS POR CONFIAR EN NOSOTROS, VUELVA PRONTO\n\n");

    return 0;
}
