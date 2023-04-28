using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
	//ボールが見える可能性のあるz軸の最小値
	private float visiblePosZ = -6.5f;
	private int score = 0;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;
	//スコアを表示するテキスト
	private GameObject scoreText;

	// Start is called before the first frame update
	void Start()
	{
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");

		this.scoreText = GameObject.Find("ScoreText");
	}

	// Update is called once per frame
	void Update()
	{
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ)
		{
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text>().text = "Game Over";
		}

		//ScoreTextにスコアを表示	
		this.scoreText.GetComponent<Text>().text = score + "点";

			

	}
	//衝突時に呼ばれる関数
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.gameObject.tag);
		if (collision.gameObject.tag == "LargeStarTag")
		{
			score = score + 20;
		}
		else if(collision.gameObject.tag == "LargeCloudTag")
		{
			score = score + 30;
		}
		else if (collision.gameObject.tag == "SmallStarTag")
        {
			score = score + 5;
        }
		else if (collision.gameObject.tag == "SmallCloudTag")
        {
			score = score + 10;
        }

	}



}
