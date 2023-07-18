using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public List<GameObject> questions = new List<GameObject>();
    int index=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateQuestion()
    {
        Debug.Log(index);
        GameObject question = Instantiate(questions[index], new Vector3(0, 1.5f, 0), Quaternion.identity);
        index++;

    }
}
