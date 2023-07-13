using System.Collections;       //necesarias para manejar unity..espacios de nombre en la biblioteca
using UnityEngine;             //necesarias para manejar unity
//using System.Collections.Generic;
using UnityEngine.SceneManagement;     //permite utilizar la clase SceneManager para gestionar la escena en unity

public class LoadingController : MonoBehaviour         //clase:LoadingController   hereda:MonoBehaviour  
                                                       //permite que el scrip se pueda ajustar a un objeto y ejecutar
{
    [SerializeField] private float loadingTime = 1f;   //declara una variable(privada-float)llamada loadingTime con un valor de 1 segundo
	[SerializeField] private string gameSceneName = "SceneUno";     //variable(privada-string) llamada gameSceneName
	                                                                   //gameSceneName es la escena que va a ir despues del tiempo de carga

    IEnumerator Start()                                   //"IEnumerator" espera el tiempo especificado en loadingTime
    {
        yield return new WaitForSeconds(loadingTime);
		SceneManager.LoadScene(gameSceneName);           //Garga la escena especificada en "gameSceneName"
  
    }
}
