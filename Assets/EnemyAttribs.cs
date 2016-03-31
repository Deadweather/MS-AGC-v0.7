using UnityEngine;
using System.Collections;

public class EnemyAttribs : MonoBehaviour {

    [SerializeField]
    private int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollision(Collision col)
    {
        if (col.gameObject.name == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
