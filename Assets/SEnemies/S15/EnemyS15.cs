using UnityEngine;
using System.Collections;

public class EnemyS15 : MonoBehaviour {

    public Transform player;
    static Animator S15;
    // Use this for initialization
    void Start()
    {

        S15 = GetComponent<Animator>();

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

            S15.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.2f);
                S15.SetBool("isRunning", true);
                S15.SetBool("isAttacking", false);
            }
            else
            {
                S15.SetBool("isAttacking", true);
                S15.SetBool("isRunning", false);
            }
        }

        else
        {
            S15.SetBool("isIdle", true);
            S15.SetBool("isRunning", false);
            S15.SetBool("isAttacking", false);
        }

    }
}
