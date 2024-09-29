using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScript : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            startTime = Time.time;
            finished = false;
            timerText.color = Color.white;
        }

        if (finished)
            return;
        float t = Time.time - startTime;

        //string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString("f3");


        //timerText.text = minutes + ":" + seconds;

        float minutes = Mathf.FloorToInt(t / 60);
        float seconds = (t % 60);
        //float milliseconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00.000}", minutes, seconds);


    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.red;
    }

    public static GlobalScript Instance;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
