using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        print("Cambiando de Escena a: " + nombre);
        SceneManager.LoadScene(nombre);
    }
}
