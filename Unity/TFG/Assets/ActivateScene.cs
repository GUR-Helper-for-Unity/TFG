using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateScene : MonoBehaviour
{
    void Start()
    {
        SceneManager.activeSceneChanged += EscenaCambiada;
    }

    private void EscenaCambiada(Scene escenaAnterior, Scene escenaNueva)
    {
        if (escenaNueva.name == gameObject.scene.name)
        {
            ActivarObjetos();
        }
    }

    private void ActivarObjetos()
    {
        // Itera a través de todos los GameObjects en la escena
        foreach (GameObject objeto in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            // Activa o desactiva el GameObject según el parámetro
            objeto.SetActive(true);
        }
    }
}
