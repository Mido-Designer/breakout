using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Gm : MonoBehaviour {

    public void GameOver() {

        SceneManager.LoadScene(2);
    
    }

    public void uWin() {

        print("UWIN");
    
    }

    public void NewGame() {

        SceneManager.LoadScene(1);
    
    }

    public void quit() {

        Application.Quit();
    
    }

    public void loadscene(int num)
    {

        SceneManager.LoadScene(num);

    }

     
}
