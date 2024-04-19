# Ejercicio Desarrollador .NET BioMakers

Este proyecto es un sistema CRUD realizado en .Net Framework 4.5 y SQL Server, diseñado para gestionar artículos, categorías, y ahora órdenes y reportes mejorados.

## Introducción

Para comenzar con este ejercicio, debes clonar el repositorio desde aquí:
[https://github.com/BioMakers-net/challenge-net-biomakers.git](https://github.com/BioMakers-net/challenge-net-biomakers.git)

## Requisitos para ejecutar la aplicación localmente

Para ejecutar y desarrollar este proyecto, asegúrate de tener instalado lo siguiente:

1. **Visual Studio IDE 2019**
   - Incluye los componentes de desarrollo de escritorio .NET durante la instalación.

2. **SQL Server 2018/2019**
   - Necesario para gestionar la base de datos. Cualquier edición compatible (Developer, Express, etc.) servirá.

3. **Microsoft SQL Server Management Studio (SSMS) o alternativa de cliente SQL**
   - Esencial para la administración de la base de datos.

4. **Sigue las instrucciones específicas del README en el repositorio de GitHub para configurar y ejecutar el proyecto.**

## Instrucciones Generales

Una vez instalado el entorno necesario:
- Clona el repositorio y crea un branch separado para trabajar.
- Puedes hostear tu branch de forma privada y proporcionar acceso a vsiless@biomakers.net y amodia@biomakers.net para revisión.

## Ejercicios Evaluados

### Ejercicio 0: Redireccionamiento de la Base de Datos

Cambia la cadena de conexión en el proyecto a una con permisos de lectura y escritura que será proporcionada por correo.

### Ejercicio 1: Reestructuración del Menú

Agrega un botón "Orders" al menú. La nueva estructura del menú debe ser:
1. Articles
2. Categories
3. Orders
4. Reports

### Ejercicio 2: Actualización del CRUD y la Tabla de Artículos

**Objetivo**: Incluir el campo "Price" en la tabla "Articles" y ajustar las operaciones CRUD para manejar este nuevo campo.

**Instrucciones**:
1. Agregar el campo "Price" a la tabla "Articles".
2. Actualizar las funciones de CRUD para permitir la inserción y actualización de precios, además de incluir estos en las lecturas.

### Ejercicio 3: Desarrollo de CRUD para Órdenes

**Objetivo**: Implementar operaciones CRUD para manejar órdenes que pueden incluir múltiples artículos.

**Instrucciones**:
1. **Campo Articles**: Permitir la selección de uno o más artículos al crear una orden.
2. **Campo Number of Articles**: Permitir especificar la cantidad de cada artículo seleccionado.

### Ejercicio 4 (OPCIONAL): Mejora de Reportes

**Objetivo**: Añadir nuevas columnas y una línea de totales al reporte existente.

**Instrucciones**:
1. Añadir columna "Price".
2. Añadir columna "Number of Articles Sold".
3. Añadir una línea de "Total" al final del reporte para sumar y mostrar el total de artículos vendidos y el total monetario de las ventas.

## Ambiente de Desarrollo

- **IDE**: Visual Studio 2019
- **Herramientas adicionales**:
  - SQL Server Management Studio
  - Cliente Git para control de versiones

## Diagrama de clases

<p align="center">
    <img src="resources/ClassDiagram.png">
</p>


## Capturas

<p align="center">
    <img src="resources/screenshots/ArticleListView.png" alt="">
</p>
<p align="center">
    <img src="resources/screenshots/ArticleCreateView.png" alt="">
</p>
<p align="center">
    <img src="resources/screenshots/ReportView.png" alt="">
</p>
Validaciones
<p align="center">
    <img src="resources/screenshots/ErrorMessage-ArticleCreateView.png">
</p>
<p align="center">
    <img src="resources/screenshots/SuccessMessage-ArticleListView.png">
</p>


## Licencia

GPL-3.0

## Referencias

- Documentación oficial de Visual Studio y SQL Server.
- Comunidades en línea como Stack Overflow para soporte técnico.

- Others
  - https://www.youtube.com/watch?v=LULI64meTUs
