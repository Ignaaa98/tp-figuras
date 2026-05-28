# Trabajo Practico Especial - Intro a C# / .NET - Mono

Proyecto basado en el ejemplo `ExMetodosVirtuales`.

## Compilacion en Ubuntu con Mono

```bash
sudo apt update
sudo apt install mono-complete
cd ExMetodosVirtuales
xbuild ExMetodosVirtuales.csproj
bin/Debug/ExMetodosVirtuales.exe
```

## Modificaciones realizadas

- Las figuras se dibujan con colores aleatorios.
- Cada figura usa un color distinto en cada ejecucion del boton.
- Los colores se generan con un contraste minimo para distinguirse del fondo blanco.
- Las figuras se muestran con tamanos proporcionalmente crecientes de izquierda a derecha.
- Se agregaron dos nuevas figuras al modelo:
  - Triangulo isosceles.
  - Triangulo equilatero.

