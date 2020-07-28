using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YasuoAnim : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isAttacking", true);
        }
          else if(Input.GetKey(KeyCode.Q))
        {
            anim.SetBool("isUsingSpell1a", true);
        }
        else if(Input.GetKey(KeyCode.R))
        {
            anim.SetBool("isUsingSpell4", true);
        }
        else 
        {
            anim.SetBool("isAttacking", false);
            anim.SetBool("isUsingSpell4", false);
            anim.SetBool("isUsingSpell1a", false);

        }
    }
}
