using UnityEngine;

public class ScriptInfo : MonoBehaviour {
    public GameObject objek;

    public void WhenButtonClicked() {
        if (objek.activeSelf) {
            objek.SetActive(false);
        } else {
            objek.SetActive(true);
        }
    }
}
