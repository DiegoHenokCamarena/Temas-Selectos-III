using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextVideo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void prevVideo() //Reproduce la escena de video anterior
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void goTo3d() //Cambia a la escena 3d (Practica 3)
    {
        SceneManager.LoadScene(sceneName:"escena3d");
    }

    public void goToVid() //Regresa al video central
    {

        SceneManager.LoadScene(sceneName: "escena2");
    }

    public void goToCarr()//Cambia a la escena del carrusel de imagenes 
    {
        SceneManager.LoadScene(sceneName: "carrusel");
    }
}
