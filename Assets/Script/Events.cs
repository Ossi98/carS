using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using mapchosen = Mapchosen;

public class Events : MonoBehaviour
{
	public SceneSwitcher sceneSwitcher;

    public int map = 0;
    public void ReplayGame(){
    	SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }

    public void QuitGame(){
    	//Application.Quit(); 
        SceneManager.LoadScene(0);

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void SelectMap()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        if(EventSystem.current.currentSelectedGameObject.name == "Map1"){

        	mapchosen.map = 3;


        }
        else{
        	mapchosen.map = 2;
        	
        }


        sceneSwitcher.OpenScene(0);

            }

}
