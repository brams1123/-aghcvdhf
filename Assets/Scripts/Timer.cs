using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float myCoolTimer = 15;
    public Text timerText;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        myCoolTimer -= Time.deltaTime;
        timerText.text = myCoolTimer.ToString("f0");

        if (myCoolTimer <= 0)
        {
            Application.LoadLevel(5);
        }

		
	}
}
