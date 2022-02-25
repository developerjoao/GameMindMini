using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    Rigidbody playerRB;
    public float moveSpeed = 5f;
    public float turnSpeed = 5f;

    float xInput;
    float yInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimento usando transform position
        transform.position = transform.position + new Vector3 (
            Input.GetAxis("Horizontal")* moveSpeed * Time.deltaTime,
            0,
            Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime
        );

        //Movimento usando velocity
        /*
        playerRB.velocity = new Vector3(
			Mathf.Lerp(0, Input.GetAxis("Horizontal")* moveSpeed, 0.8f),
			playerRB.velocity.y,
			Mathf.Lerp(0, Input.GetAxis("Vertical")* moveSpeed, 0.8f)
		);*/
    }
}
