using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReturnToMain : MonoBehaviour {

    public Button nextLevel;
    // Use this for initialization
    void Start () {

        nextLevel = nextLevel.GetComponent<Button>();

    }

    // Update is called once per frame
    public void NextLevel()
    {
        Application.LoadLevel(0);
    }
}
