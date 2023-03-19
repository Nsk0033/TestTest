using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour {
    public float angle;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, angle * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}

