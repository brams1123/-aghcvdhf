using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Complete : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel(3);
        }

    }
}
