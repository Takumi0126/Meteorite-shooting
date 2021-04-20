using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、スプライトが移動する
public class RocketController : MonoBehaviour {

	public float speed = 2; // スピード：Inspectorで指定

	float vx = 0;
	float vy = 0;
	bool leftFlag = false;

	void Update () { // ずっと行う
		vx = 0;
		vy = 0;
		if(Input.GetKey("right")) { // もし、右キーが押されたら
			vx = speed; // 右に進む移動量を入れる
			leftFlag = false;
		}
		if(Input.GetKey("left")) { // もし、左キーが押されたら
			vx = -speed; // 左に進む移動量を入れる
			leftFlag = true;
		}
	}
	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		// 移動する
		this.transform.Translate(vx/50, vy/50, 0);
	}
}
