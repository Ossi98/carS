using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using mapchosen = Mapchosen;

public class SceneSwitcher : MonoBehaviour
{


    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }



    public void play(){
        Debug.Log(mapchosen.map);    
        if (mapchosen.map != 0){

                OpenScene(mapchosen.map);
        }
    }


    public void quitgame(){
        Application.Quit(); 
    }

    void update(){
        if(Input.GetKey("escape")){
            Application.Quit();
        }
    }

}
