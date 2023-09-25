using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPrinter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        enabled = false; // Deshabilita la función update para que no se ejecute cada frame
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("Objeto"); // Obtiene todos los objetos con la etiqueta "Objeto" de la escena
        foreach (GameObject objeto in objetos) {
            print(objeto.name); // Enseña por consola el nombre de cada objeto
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
