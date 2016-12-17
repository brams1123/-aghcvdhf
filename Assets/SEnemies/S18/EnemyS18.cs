using UnityEngine;
using System.Collections;

public class EnemyS18 : MonoBehaviour {

    public Transform player;
    static Animator S18;
    // Use this for initialization
    void Start()
    {

        S18 = GetComponent<Animator>();

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

            S18.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.2f);
                S18.SetBool("isRunning", true);
                S18.SetBool("isAttacking", false);
            }
            else
            {
                S18.SetBool("isAttacking", true);
                S18.SetBool("isRunning", false);
            }
        }

        else
        {
            S18.SetBool("isIdle", true);
            S18.SetBool("isRunning", false);
            S18.SetBool("isAttacking", false);
        }

    }
}
