using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit") 
        {
            Debug.Log("You have bumped into someting this many times: " + counter);
            counter++;
        }

    }
    
}
