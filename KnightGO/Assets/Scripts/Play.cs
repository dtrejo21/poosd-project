using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void onPlayButton(){
        SceneManager.LoadScene("TestScene");
    }

    public void OnQuitButton (){
        Application.Quit();
    }
    
}
