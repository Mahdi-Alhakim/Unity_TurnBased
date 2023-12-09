using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    /*void OnCollisionEnter2D(Collision2D other)
    {
        //Stuff that happens when the collider collides with something

        print(other.gameObject.tag);
        if (other.otherCollider.gameObject.tag == "Log")
        {
            other.otherCollider.GetComponent<Animator>().SetTrigger("Hit");
        }
    }*/
}
