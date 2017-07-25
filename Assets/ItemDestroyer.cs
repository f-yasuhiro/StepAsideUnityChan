using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {
	// Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		// Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		// Unityちゃんが通り過ぎ、画面外に出たオブジェクトを破棄
		if((this.unitychan.transform.position.z - this.transform.position.z) > 5.0f){
			Destroy (this.gameObject);
		}
	}
}
