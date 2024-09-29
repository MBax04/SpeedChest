using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovingSpikes1 : MonoBehaviour
{

    private bool buttonPressed = false;
    private bool Down = true;
    public Vector2 tempPos;
    public float speed = 20f;
    public int spikeTop = 100;
    public int spikeBottom = -100;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TilemapRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;

        
        

        if (buttonPressed == true)
        {
            if (Down == false)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
                if (tempPos.y >= spikeTop)
                {
                    Down = true;
                }
            }

            if (Down == true)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
                if (tempPos.y <= spikeBottom)
                {
                    Down = false;
                }
            }
        }
    }

    public void ButtonPressed()
    {
        buttonPressed = true;
        gameObject.GetComponent<TilemapRenderer>().enabled = true;
    }
}
