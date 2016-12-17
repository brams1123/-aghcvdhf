using UnityEngine;
using System.Collections;

public class EnemyS1 : MonoBehaviour {

    public Transform player;
    static Animator S1;
    // Use this for initialization
    void Start()
    {

        S1 = GetComponent<Animator>();

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

            S1.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.2f);
                S1.SetBool("isRunning", true);
                S1.SetBool("isAttacking", false);
            }
            else
            {
                S1.SetBool("isAttacking", true);
                S1.SetBool("isRunning", false);
            }
        }

        else
        {
            S1.SetBool("isIdle", true);
            S1.SetBool("isRunning", false);
            S1.SetBool("isAttacking", false);
        }

    }
}
