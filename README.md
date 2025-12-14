# Gestión de Artículos – Gaming Zone

Aplicación web desarrollada en **ASP.NET Core MVC con Framework .NET 9**, cuyo objetivo es permitir el registro y visualización de artículos de una tienda de videojuegos, aplicando el patrón MVC, validaciones de datos y almacenamiento temporal en memoria.

---

## Información General

* **Proyecto:** Gestión de Artículos – Gaming Zone
* **Tecnología:** ASP.NET Core MVC
* **Framework:** .NET 9
* **IDE:** Visual Studio 2022
* **Almacenamiento:** Lista en memoria (sin base de datos)
* **Control de versiones:** Git / GitHub

---

## Objetivo General

Desarrollar una aplicación web que permita **registrar artículos** de una tienda de videojuegos y **visualizarlos en un listado**, aplicando:

* Patrón MVC
* Validaciones con DataAnnotations
* Separación de responsabilidades
* Almacenamiento temporal en memoria

---

## Funcionalidades Principales

* Registro de artículos mediante formulario
* Validaciones en cliente y servidor
* Listado de artículos en una tabla
* Validación de código interno único
* Mensajes de error y confirmación
* Navegación entre vistas

---

## Estructura del Proyecto

```
GamingZoneApp
│
├── Controllers
│   └── ArticuloController.cs
│
├── Models
│   └── Articulo.cs
│
├── Data
│   └── ArticuloRepository.cs
│
├── Views
│   └── Articulo
│       ├── Index.cshtml
│       └── Crear.cshtml
│
├── wwwroot
├── Program.cs
└── README.md
```

---

## Modelo Artículo

El sistema gestiona los siguientes datos:

* **Artículo** (obligatorio, mínimo 3 caracteres)
* **Proveedor** (obligatorio, mínimo 3 caracteres)
* **Categoría** (Play Station, XBox, Nintendo, PC, Otro)
* **Año de lanzamiento** (entre 1970 y el año actual)
* **Número de artículos** (entero mayor a 0)
* **Código interno** (formato ART-###, único)
* **Disponible** (Sí / No)

---

## Reglas de Validación

* Campos obligatorios usando `[Required]`
* Longitud mínima con `[StringLength]`
* Rangos numéricos con `[Range]`
* Formato del código interno con `[RegularExpression]`
* Validación manual para evitar códigos duplicados
* Validación para impedir años futuros

## Observaciones

* La aplicación **no utiliza base de datos**, cumpliendo el requisito de almacenamiento en memoria.
* El proyecto está desarrollado con **.NET 9**, siguiendo el modelo de hosting minimal.
* Diseñado con fines **académicos y demostrativos**.

Proyecto desarrollado conforme a los requisitos del caso "Gestión de Artículos – Gaming Zone".
