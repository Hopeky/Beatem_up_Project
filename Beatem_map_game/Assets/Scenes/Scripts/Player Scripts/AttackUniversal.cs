using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool is_Player, is_Enemy;

    public GameObject hit_FX;
    
   

    // Update is called once per frame
    void Update()
    {
        DetectedCollision();
    }

    void DetectedCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);

        if(hit.Length >0)
        {
            print("We Hit The " + hit[0].gameObject.name);

            gameObject.SetActive(false);

        } // if we have a hit

    } // detect collision







} //class
