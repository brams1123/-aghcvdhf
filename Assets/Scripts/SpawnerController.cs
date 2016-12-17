using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] spawnObject;
    public GameObject[] spawnClone;

    void Start()
    {
        spawnEnemy();
    }

    void spawnEnemy()
    {
        spawnClone[0] = Instantiate(spawnObject[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[1] = Instantiate(spawnObject[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[2] = Instantiate(spawnObject[2], spawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[3] = Instantiate(spawnObject[3], spawnLocations[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[4] = Instantiate(spawnObject[4], spawnLocations[4].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[5] = Instantiate(spawnObject[5], spawnLocations[5].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[6] = Instantiate(spawnObject[6], spawnLocations[6].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[7] = Instantiate(spawnObject[7], spawnLocations[7].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        spawnClone[8] = Instantiate(spawnObject[8], spawnLocations[8].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
