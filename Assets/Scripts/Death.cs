using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       if(collision.gameObject.tag == "Player")
        {
            if (FinishLevel.currentLevel == 1)
            {
                collision.transform.position = new Vector2(-134, -39);
            }

            if (FinishLevel.currentLevel == 2)
            {
                collision.transform.position = new Vector2(-134, -39);
            }

            if (FinishLevel.currentLevel == 3)
            {
                collision.transform.position = new Vector2(-134, 59);
            }

            if (FinishLevel.currentLevel == 4)
            {
                collision.transform.position = new Vector2(-134, 56);
                GameObject.Find("Jump Orb1").SendMessage("Died");
                GameObject.Find("Jump Orb2").SendMessage("Died");
                GameObject.Find("Jump Orb3").SendMessage("Died");
                GameObject.Find("Jump Orb4").SendMessage("Died");
            }
                if (FinishLevel.currentLevel == 5)
            {
                collision.transform.position = new Vector2(-90, -55);
                SceneManager.LoadScene("Level 5");
            }

            if (FinishLevel.currentLevel == 6)
            {
                collision.transform.position = new Vector2(-120, 9);
            }
        }
    }
}
