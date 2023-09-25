# Introducción a Unity
## Práctica 1 - Interfaces Inteligentes

En este repositorio se encuentra el primer proyecto en Unity de la asignatura de Interfaces Inteligentes, en él, se debía crear una escena con prefabs del paquete Starter Assets FPS de Unity y prefabs extra de otros paquetes a elegir por el desarrollador.

En la carpeta Packages se puede encontrar una lista de los paquetes importados además del script asignado en la carpeta Scripts

El script pedido debe comentar por consola el nombre de cada objeto en la escena. Dicho script ha sido asociado al objeto Terrain de la escena y por tanto cada vez que se ejecuta el proyecto se cargan las siguientes líneas de código:

```c# 
enabled = false; // Deshabilita la función update para que no se ejecute cada frame
GameObject[] objetos = GameObject.FindGameObjectsWithTag("Objeto"); // Obtiene todos los objetos con la etiqueta "Objeto" de la escena

foreach (GameObject objeto in objetos) {
    print(objeto.name); // Enseña por consola el nombre de cada objeto
}
```

Para que lo anterior funcionase, los objetos de la escena fueron atribuídos la etiqueta "Objeto"

GIF con la ejecución del proyecto y resultado por consola.

![ejecución](img/ejecucion.gif)