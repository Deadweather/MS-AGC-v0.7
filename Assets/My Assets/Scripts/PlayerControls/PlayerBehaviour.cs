using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    Vector3 movement;
    private Rigidbody rigidb;

	// Use this for initialization
	void Start () {

        speed = 4;
        rigidb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float moveHorizontal = Input.GetAxisRaw ("Vertical");
        float moveVertical = Input.GetAxisRaw ("Horizontal");

        Move (moveVertical, moveHorizontal);

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);

        rigidb.AddForce(movement * speed);

	}

    void Move(float moveHorizontal, float moveVertical)
    {
        movement.Set(moveHorizontal, 0f, moveVertical);

        movement = movement.normalized * speed * Time.deltaTime;

        rigidb.MovePosition(transform.position + movement);
    }
}
