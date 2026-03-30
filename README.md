Proyecto NutriBalance:

Integrantes:
- Emanuel Carrillo Soto
- Kevin Zamora Soto

Aplicación de escritorio desarrollada en C# con Windows Forms que permite a los usuarios gestionar su alimentación diaria, calcular metas nutricionales y llevar un control de su progreso.

##  Descripción

NutriBalance es un sistema orientado a la gestión nutricional personalizada. Permite registrar usuarios, definir objetivos alimenticios, registrar alimentos consumidos y evaluar el cumplimiento de metas diarias y mensuales.

El sistema fue desarrollado aplicando buenas prácticas de programación, arquitectura MVC y principios SOLID.

## Arquitectura

El proyecto está estructurado bajo el patrón MVC (Modelo - Vista - Controlador):

- **Model**  
  Contiene entidades, interfaces y lógica de persistencia (JSON)

- **Controller**  
  Contiene la lógica de negocio (validaciones, cálculos, procesamiento)

- **View**  
  Interfaz gráfica desarrollada con Windows Forms

##  Tecnologías utilizadas

- C#
- .NET 10
- Windows Forms
- JSON (persistencia de datos)
- Visual Studio
- SonarLint (calidad de código)
- Azure DevOps (gestión del proyecto)


##  Funcionalidades principales

- Registro e inicio de sesión de usuarios
- Cálculo de IMC
- Cálculo de calorías objetivo
- Registro de alimentos
- Creación de menú diario
- Resumen diario de consumo
- Histórico mensual
- Validación de metas nutricionales
