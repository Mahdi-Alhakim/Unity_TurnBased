using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log_logic : MonoBehaviour
{

    public Animator anmtr;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(int dmg)
    {
        //Stuff that happens when the collider collides with something
        anmtr.SetTrigger("Hit");
        if (health - dmg > 0)
            health -= dmg;
        else
        {
            health = 0;
            Destroy(gameObject);
        }

    }
}
