using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Animator myAnimator;

    const string ButtonAnim = "ButtonTrigger";

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myAnimator.SetTrigger(ButtonAnim);
            //Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Moving Ground").SendMessage("MoveGround");
            GameObject.Find("Door").SendMessage("ButtonPressed");
            GameObject.Find("moving zone").SendMessage("ButtonPressed");
            GameObject.Find("moving zone2").SendMessage("ButtonPressed");
        }
    }
}
