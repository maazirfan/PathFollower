using UnityEngine;
using System.Collections;

public class pathFollower : MonoBehaviour {

	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;

	public	bool start;

	// Use this for initialization
	void Start () {
		start = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (start == true) {

		Vector3 dir =   path [currentPoint].position - transform.position ;
		transform.position += dir * Time.deltaTime * speed;

		if (dir.magnitude <= reachDist) {

			currentPoint++;

		}

		if(currentPoint>=path.Length)
		{
			currentPoint = 10;
		}

	}
	}

	void OnDrawGizmos()
	{
		if(path.Length > 0)
		for (int i = 0; i < path.Length; i++) 
		{
			if(path[i] !=null)
			{
				Gizmos.DrawSphere(path[i].position,reachDist);
			}
		}
	}


	public void locationChngBtn()
	{
		start = true;
	}



}
