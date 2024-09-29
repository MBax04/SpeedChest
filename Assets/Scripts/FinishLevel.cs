using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public static int currentLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level 1");
            currentLevel = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            if (currentLevel == 5)
            {
                SceneManager.LoadScene("Finish Screen");
                currentLevel = currentLevel + 1;
                GameObject.Find("GlobalObject").SendMessage("Finish");
                collision.transform.position = new Vector2(-120, 9);
            }

            if (currentLevel == 4)
            {
                SceneManager.LoadScene("Level 5");
                currentLevel = currentLevel + 1;
                collision.transform.position = new Vector2(-90, -55);
            }

            if (currentLevel == 3)
            {
                SceneManager.LoadScene("Level 4");
                currentLevel = currentLevel + 1;
                collision.transform.position = new Vector2(-134, 56);
            }

            if (currentLevel == 2)
            {
                SceneManager.LoadScene("Level 3");
                currentLevel = currentLevel + 1;
                collision.transform.position = new Vector2(-134, 59);
            }

            if (currentLevel == 1)
            {
                SceneManager.LoadScene("Level 2");
                currentLevel = currentLevel + 1;
                collision.transform.position = new Vector2(-134, -39);
            }
        }
    }

}
