using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;

    public const int WING = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("Index", WING);
    }
}
 