using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	//初速を入力値として準備します。
	public float speed = 100;

	public Rigidbody rigidbody;

	private void Start()
	{
		
		// 力を設定
		Vector3 force = new Vector3(10.0f, 10.0f, 0.0f) * speed;
		// 力を加える
		rigidbody.AddForce(force);
	}
}