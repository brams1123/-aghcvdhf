/* Source File Name: GameController
 * Author's Name: Ibrahim Natchee
 * Last Modified By: Ibrahim Natchee
 * Date Modified Last: October 29 2016
 * Program Description: To create and control UI
 * Revision History: October 29 2016
 
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerShooting : MonoBehaviour {

	// PUBLIC VARIABLES FOR TESTING
	public Transform FlashPoint;
	public GameObject MuzzleFlash;
	public GameObject Explosion;
    public GameObject Barrel;
	public GameObject BulletImpact;
	public Transform PlayerCam;

    
    // Use this for initialization
    void Start () {

       
    }
	
	// Update is called once per frame (for Physics)
	void FixedUpdate () {
		if (Input.GetButtonDown ("Fire1")) {
			
			Instantiate (this.MuzzleFlash, this.FlashPoint.position, Quaternion.identity);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            // need a variable to hold the location of our Raycast Hit
            RaycastHit hit;

			// if raycast hits an object then do something...
			if (Physics.Raycast (this.PlayerCam.position, this.PlayerCam.forward, out hit)) {

                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    Instantiate(this.Explosion, hit.point, Quaternion.identity);

                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    Instantiate(this.BulletImpact, hit.point, Quaternion.identity);
                }

                if (hit.transform.gameObject.CompareTag("Barrel"))
                {
                    Instantiate(this.Barrel, hit.point, Quaternion.identity);

                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    Instantiate(this.BulletImpact, hit.point, Quaternion.identity);
                }



            }

        }
	}

}
