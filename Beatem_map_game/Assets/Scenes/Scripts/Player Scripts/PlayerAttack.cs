using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Anim;


    // Start is called before the first frame update
    void Awake()
    {
        player_Anim
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttacks();
    }

    void ComboAttacks()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {

        }
    }

}
