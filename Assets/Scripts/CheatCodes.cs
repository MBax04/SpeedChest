using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCodes : MonoBehaviour
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
            FinishLevel.currentLevel = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Level 1");
            FinishLevel.currentLevel = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Level 2");
            FinishLevel.currentLevel = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Level 3");
            FinishLevel.currentLevel = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Level 4");
            FinishLevel.currentLevel = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Level 5");
            FinishLevel.currentLevel = 5;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("Finish Screen");
            FinishLevel.currentLevel = 6;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (currentLevel == 5)
            {
                SceneManager.LoadScene("Finish Screen");
                FinishLevel.currentLevel = FinishLevel.currentLevel + 1;
            }

            if (currentLevel == 4)
            {
                SceneManager.LoadScene("Level 5");
                FinishLevel.currentLevel = FinishLevel.currentLevel + 1;
            }

            if (currentLevel == 3)
            {
                SceneManager.LoadScene("Level 4");
                FinishLevel.currentLevel = FinishLevel.currentLevel + 1;
            }

            if (currentLevel == 2)
            {
                SceneManager.LoadScene("Level 3");
                FinishLevel.currentLevel = FinishLevel.currentLevel + 1;
            }

            if (currentLevel == 1)
            {
                SceneManager.LoadScene("Level 2");
                FinishLevel.currentLevel = FinishLevel.currentLevel + 1;
            }
        }
    }
}
