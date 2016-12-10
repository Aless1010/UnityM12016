using UnityEngine;
using System.Collections;

public class destroybullet : MonoBehaviour {

    public float dtime;

	// Use this for initialization
	void Start () {
        Destroy(gameObject,dtime);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
