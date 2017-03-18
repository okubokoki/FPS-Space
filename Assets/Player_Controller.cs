using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    [SerializeField] GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.C))
        {
            Vector3 pos = Player.transform.position;
            pos.y = 5;
            Player.transform.position = pos;
        }
	}
}
