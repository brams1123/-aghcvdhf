using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Transform player;
    static Animator Enemy;
    // Use this for initialization
    void Start()
    {

        Enemy = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(player.position, this.transform.position) < 12)
        {
            Vector3 direction = player.position - this.transform.position;
            //float angle = Vector3.Angle(direction, this.transform.forward);
            // if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 30)
            // {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);

            Enemy.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.2f);
                Enemy.SetBool("isRunning", true);
                Enemy.SetBool("isAttacking", false);
            }
            else
            {
                Enemy.SetBool("isAttacking", true);
                Enemy.SetBool("isRunning", false);
            }
        }

        else
        {
            Enemy.SetBool("isIdle", true);
            Enemy.SetBool("isRunning", false);
            Enemy.SetBool("isAttacking", false);
        }

    }
    //  }
}

