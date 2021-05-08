using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();   
    }

    // Update is called once per frame
    void Update()
    {  
        MovePlayer();   
    }

    void PrintInstructions()
    {
        Debug.Log("Use arrow keys to move the purple ball.");
        Debug.Log("Don't touch anything!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
