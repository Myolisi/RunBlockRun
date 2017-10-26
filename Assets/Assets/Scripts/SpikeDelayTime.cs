using UnityEngine;
using System.Collections;
using System;

public class SpikeDelayTime : MonoBehaviour {

    //public Animator anim;
	// Use this for initialization
	void Start () {


        


    }
    // Update is called once per frame
    void Update () {

        StartCoroutine("stopSpike");

    }

    IEnumerator stopSpike()
    {
        while (true)
        {
            GetComponent<Animator>().Play(1);
            yield return new WaitForSeconds(3f);
        }
        
    }
}
