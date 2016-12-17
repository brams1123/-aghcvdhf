using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Button playLevel;

    // Use this for initialization
    void Start()
    {

        playLevel = playLevel.GetComponent<Button>();

    }

    // Update is called once per frame
    public void PlayLevelAgain()
    {
        Application.LoadLevel(2);
    }
}
