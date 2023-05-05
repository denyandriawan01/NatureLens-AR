using UnityEngine;

public class backsound : MonoBehaviour {

    void Start() {
        if (GameObject.Find("backsound on") == null) {
            DontDestroyOnLoad(gameObject);
            GetComponent<AudioSource>().Play();
            gameObject.name = "backsound on";
            PlayerPrefs.SetFloat("volume", 1);
        }
    }

    void Update() {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null) {
           audioSource.volume = PlayerPrefs.GetFloat("volume");
        }
    }
}
