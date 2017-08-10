using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        // 画面外に出たら破棄する
        if  (transform.position.z < GameObject.Find("Main Camera").transform.position.z)
            {
            Destroy(gameObject);
        }
    }
}
