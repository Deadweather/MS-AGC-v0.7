using UnityEngine;
using System.Collections;


public class DestroyEnemies: MonoBehaviour {

    PlayerScore playerscore;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerscore = player.GetComponent<PlayerScore>();

    }

    void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            playerscore.score += 30;
        }

        if (col.gameObject.tag == "Obstacles")
        {
            Destroy(this.gameObject);
        }
	}
}
