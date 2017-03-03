using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
    public GameObject ballPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/* 按下鼠标右键            */
        if (Input.GetMouseButtonDown(1))
        {
			//实例化小球
            Instantiate(this.ballPrefab);
        }
	}
}
