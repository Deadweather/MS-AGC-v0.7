using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{

    private Transform myTransform;
    private Rigidbody rb;
    private Vector3 forwardDirection;
    public float speed;

    bool follow;
    int minRange;
    Transform target;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        target = player.GetComponent<Transform>();
        rb = this.GetComponent <Rigidbody >();


        minRange = 1;
        speed = 1.5f;       
    }


    void Update()
    {

        forwardDirection = this.transform.TransformDirection(Vector3.forward);

        //transform.Translate(Vector3.forward * speed);
    }

    void FixedUpdate()
    {
        transform.LookAt(target);
        rb.AddForce(forwardDirection * speed);
    }

    void OnCollisionEnter(Collision C)
    {
        if (C.gameObject.tag=="Player")
        {
            Destroy(C.gameObject);
            SceneManager.LoadScene("Lose");
        }
       
    }

}
