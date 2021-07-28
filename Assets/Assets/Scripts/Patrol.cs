using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	public Transform[] patrolPoints;

	[HideInInspector]
	public int currentPoints = 0;

	public float moveSpeed = 50;
	

	// Use this for initialization
	void Start () {

		transform.position = patrolPoints[0].position;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position == patrolPoints[currentPoints].position)
		{
			currentPoints++;
		}

		if (currentPoints >= patrolPoints.Length)
		{
			currentPoints = 0;
		}

		transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoints].position, moveSpeed);
	}
}
