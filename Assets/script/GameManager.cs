using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Question questionScript;
    // Start is called before the first frame update
    void Start()
    {
        questionScript.GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnFinished()
    {
        GameObject question = GameObject.FindGameObjectWithTag("question");
        Destroy(question);
        StartCoroutine(DelayCoroutine(3f));
    }

    IEnumerator DelayCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        MiniGames.Instance.StartMiniGames();
    }
    
    /*void DestroyQuestion(GameObject gameObject)
    {
        Destroy(gameObject);
    }*/


}
