using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

    [SerializeField]private Camera sourceCam;
    [SerializeField]private Vector3 lookTarget;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = sourceCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            lookTarget = hit.point;
            transform.LookAt(lookTarget);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }

    }
}
