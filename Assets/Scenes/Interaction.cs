using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour{
    public void Exit(){
        Application.Quit();
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void sound_volume(float volume){
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void OpenLink(){
        Application.OpenURL("https://www.dropbox.com/s/0wsmk2o324lb8tl/Scan.png?dl=0");
    }

}
