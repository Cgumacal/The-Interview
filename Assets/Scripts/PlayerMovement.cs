using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //bool to check if the UI is active 
    public static bool UIActive;

    //raycast to check if you run into anything and for interaction 
    RaycastHit2D hit;
   
    //vector3's for movement
    Vector3 pos;
    Vector3 prevpos;
    Vector3 lookDirection;

    public float move;//must match the unit pixels/100


    public int movementSpeed;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        lookDirection = new Vector3(0, 0, 0);
	}

    // Update is called once per frame
    void Update(){
        if (!UIActive)
        {
            PlayerControl();
        }
    }

    void PlayerControl()
    {
        //figure out how to do raycast 
        if (Input.GetKey(KeyCode.D) && transform.position == pos)
        {
            lookDirection = new Vector3(1,0,0);
            if (!Physics2D.Raycast(transform.position, lookDirection, move))
            {
                prevpos = transform.position;
                pos += new Vector3(move, 0, 0);
            }

        }
        else if (Input.GetKey(KeyCode.A) && transform.position == pos)
        {
            lookDirection = new Vector3(-1, 0, 0);
            if (Physics2D.Raycast(transform.position, lookDirection, move) == false)
            {
                prevpos = transform.position;
                pos += new Vector3(-move, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S) && transform.position == pos)
        {
            lookDirection = new Vector3(0, -1, 0);
            if (Physics2D.Raycast(transform.position, lookDirection, move) == false)
            {
                prevpos = transform.position;
                pos += new Vector3(0, -move, 0);
            }
        }
        else if (Input.GetKey(KeyCode.W) && transform.position == pos)
        {
            lookDirection = new Vector3(0, 1, 0);
            if (Physics2D.Raycast(transform.position, lookDirection, move) == false)
            {
                prevpos = transform.position;
                pos += new Vector3(0, move, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Interact(lookDirection);
        }

        //Debug.DrawRay(transform.position, new Vector3(1, 0, 0));
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * movementSpeed);
    }

    void Interact(Vector3 direction)
    {
        if (hit = Physics2D.Raycast(transform.position, direction, move))
        {
            if (hit.transform.GetComponent<OpenDialogue>())
            {
                hit.transform.GetComponent<OpenDialogue>().Run();
            }
        }
    }
}
