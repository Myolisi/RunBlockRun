using UnityEngine;
using System.Collections;

public class DestroyPrefabClones : MonoBehaviour {
	public float timeToDestroy = 5f;

	//will destroy pefabs after they are instatiated

	// Use this for initialization
	void Start () {

		Destroy(gameObject, timeToDestroy);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
