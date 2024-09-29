using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    public float speed = 20f;
    private bool buttonPressed = false;
    public Vector2 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        
        if (tempPos.x <= -208)
        {
            buttonPressed = false;
        }

        if (buttonPressed == true)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

    public void MoveGround()
    {
        buttonPressed = true;
    }
    
}
