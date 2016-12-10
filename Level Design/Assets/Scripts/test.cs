using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    Transform t;
    public Vector3 deplacement = new Vector3(1, 0, 0);

    // Use this for initialization
    void Start () {

        t = GetComponent<Transform>();
        if(t == null) Debug.Log("Pas de Transform !!");
    }
	
	// Update is called once per frame
	void Update () {
      t.position = t.position + deplacement * Time.deltaTime;
      t.position = new Vector3(t.position.x,Mathf.Sin(Time.time),t.position.z);
    }
}
