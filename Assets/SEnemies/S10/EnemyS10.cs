using UnityEngine;
using System.Collections;

public class EnemyS10 : MonoBehaviour {

    public Transform player;
    static Animator S10;
    // Use this for initialization
    void Start()
    {

        S10 = GetComponent<Animator>();

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

            S10.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.2f);
                S10.SetBool("isRunning", true);
                S10.SetBool("isAttacking", false);
            }
            else
            {
                S10.SetBool("isAttacking", true);
                S10.SetBool("isRunning", false);
            }
        }

        else
        {
            S10.SetBool("isIdle", true);
            S10.SetBool("isRunning", false);
            S10.SetBool("isAttacking", false);
        }

    }
}
