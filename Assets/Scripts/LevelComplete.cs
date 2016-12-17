using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel(2);
        }

    }
}
