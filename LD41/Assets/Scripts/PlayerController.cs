using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    private float movementSpeed = 10.0f;
    public float rotateSpeed = 6f;

    // Use this for initialization
    void Start () {
        movementSpeed = 10.0f;
        rb = GetComponent<Rigidbody2D>();
	}

    void CheckMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * movementSpeed;
        }
    }

    void CheckRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * -1);
        }
    }

	// Update is called once per frame
	void Update () {
        CheckMovement();
        CheckRotation();
    }
}
