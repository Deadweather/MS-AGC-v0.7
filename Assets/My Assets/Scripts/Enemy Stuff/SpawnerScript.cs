using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    private int respt;
    public GameObject enemy;
    private Vector3 loc;


	// Use this for initialization
	void Start () {

        loc = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        respt = Random.Range(1, 6);

        StartCoroutine(EnemySpawn());

	}

    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds(respt);

        Instantiate(enemy, loc, transform.rotation);

        respt = Random.Range(1, 6);

        StartCoroutine(EnemySpawn());

    }

}
