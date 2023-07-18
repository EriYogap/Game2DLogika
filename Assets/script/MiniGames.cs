using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MiniGames : MonoBehaviour
{
    bool isRunning;
    GameManager gameManager;
    public Text timeText;
    float time = 2;
    public Question questionScript;
    public static MiniGames Instance;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        isRunning = false;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isRunning)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timeText.text = Mathf.RoundToInt(time).ToString();
            }
            else
            {
                isRunning = true;
                gameManager.OnFinished();
            }
        }

      
    }

    public void StartMiniGames()
    {
        Debug.Log("test");
        questionScript.GenerateQuestion();
        time = 20;
        isRunning = false;

    }

}
