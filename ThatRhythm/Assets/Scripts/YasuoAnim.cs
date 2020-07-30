using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YasuoAnim : MonoBehaviour
{
    private Animator anim;

    public AudioSource audioQ;

    public AudioSource audioQ2;
    public AudioSource audioQ2Voice;

    public AudioSource audioQ3;
    public AudioSource audioQ3Voice;

    public AudioSource audioAttack;
    public AudioSource audioAttack2;

    public AudioSource audioR;
    public AudioSource audioRVoice;

    private int qCounter = 0;
    private int attackCounter = 0;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            attackCounter += 1;

            if(attackCounter <= 1) {
                anim.SetBool("isAttacking", true);
                audioAttack.Play();

            }
            else {
                anim.SetBool("isAttacking2", true);
                attackCounter = 0;
                audioAttack2.Play();

            }
            // else {
            //     anim.SetBool("isAttacking", true);
            //     attackCounter = 0;
            // }
            

        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            // anim.SetBool("isUsingSpell1a", true);
            
            qCounter += 1;

            if(qCounter <= 1) {
                audioQ.Play();
                anim.SetBool("isUsingSpell1a", true);

            }
            else if(qCounter == 2) {
                audioQ2.Play();
                audioQ2Voice.Play();
                anim.SetBool("isUsingSpell1b", true);

            }
            else {
                audioQ3.Play();
                audioQ3Voice.Play();
                anim.SetBool("isUsingSpell1c", true);

                qCounter = 0;
            }
            
            Debug.Log(qCounter);

        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("isUsingSpell4", true);
            audioR.Play();
            audioRVoice.Play();
        }
        else 
        {
           
            anim.SetBool("isAttacking", false);
            anim.SetBool("isAttacking2", false);
            anim.SetBool("isUsingSpell4", false);
            anim.SetBool("isUsingSpell1a", false);
            anim.SetBool("isUsingSpell1b", false);
            anim.SetBool("isUsingSpell1c", false);

        }
    }
}
