using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat_script : MonoBehaviour
{
    public blob_movement movement;
    public Transform blob_right, blob_left;
    public GameObject right_melee_obj, left_melee_obj;
    public Animator anmtr;
    public LayerMask hittableLayers;
    public float MeleeRange = 0.5f;

    public void MeleeAttack()
    {
        Collider2D[] hitObjects;
        if (movement.getDirRight())
        {
            anmtr.SetBool("Attacking_Right", true);
            Instantiate(right_melee_obj, blob_right);

            hitObjects = Physics2D.OverlapCircleAll(blob_right.position, MeleeRange, hittableLayers);

        }
        else
        {
            anmtr.SetBool("Attacking_Left", true);
            Instantiate(left_melee_obj, blob_left);

            hitObjects = Physics2D.OverlapCircleAll(blob_left.position, MeleeRange, hittableLayers);

        }

        foreach (Collider2D obj in hitObjects)
        {
            Debug.Log("We hit " + obj.name);
            if (obj.name == "Log") obj.GetComponent<Log_logic>().Hit(10);
            else Debug.Log("Enemy!");
        }
    }

    void OnDrawGizmosSelected()
    {
        if (movement.getDirRight())
        {
            if (blob_right == null) return;
            Gizmos.DrawWireSphere(blob_right.position, MeleeRange);
        }
        else
        {
            if (blob_left == null) return;
            Gizmos.DrawWireSphere(blob_left.position, MeleeRange);
        }
    }
}
