using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    Animator myAnimator;

    const string JumpPadAnim = "JumpPadTrigger";

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myAnimator.SetTrigger(JumpPadAnim);
        }
    }
    
}
