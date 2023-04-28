using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
	//�{�[����������\���̂���z���̍ŏ��l
	private float visiblePosZ = -6.5f;
	private int score = 0;

	//�Q�[���I�[�o��\������e�L�X�g
	private GameObject gameoverText;
	//�X�R�A��\������e�L�X�g
	private GameObject scoreText;

	// Start is called before the first frame update
	void Start()
	{
		//�V�[������GameOverText�I�u�W�F�N�g���擾
		this.gameoverText = GameObject.Find("GameOverText");

		this.scoreText = GameObject.Find("ScoreText");
	}

	// Update is called once per frame
	void Update()
	{
		//�{�[������ʊO�ɏo���ꍇ
		if (this.transform.position.z < this.visiblePosZ)
		{
			//GameoverText�ɃQ�[���I�[�o��\��
			this.gameoverText.GetComponent<Text>().text = "Game Over";
		}

		//ScoreText�ɃX�R�A��\��	
		this.scoreText.GetComponent<Text>().text = score + "�_";

			

	}
	//�Փˎ��ɌĂ΂��֐�
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
