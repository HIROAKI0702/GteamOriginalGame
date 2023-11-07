using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	float elapsedTime;
	bool counter_flag = false;

	

	void Update()
	{
		//Space�L�[�Ōv���J�n�A��~��؂�ւ�
		//if (Input.GetKey(KeyCode.Space))
		//{
		//	counter_flag = !counter_flag;
		//}

		//if (counter_flag == true)
		//{
		//	elapsedTime += Time.deltaTime;
		//	Debug.Log("�v�����F " + (elapsedTime).ToString());
		//}
	}

}
public class result_time : MonoBehaviour
{

	[SerializeField]
	private int minute;
	[SerializeField]
	private float seconds;
	//�@�O��Update�̎��̕b��
	private float oldSeconds;
	//�@�^�C�}�[�\���p�e�L�X�g
	private Text timerText;

	private string _SCORE;

	void Start ()
	{
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
	}

	void Update()
	{
		seconds += Time.deltaTime;
		if (seconds >= 60f)
		{
			minute++;
			seconds = seconds - 60;
		}
		//�@�l���ς�����������e�L�X�gUI���X�V
		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
			_SCORE = timerText.text;
		}
		oldSeconds = seconds;
	}

	public string GetSCORE()
    {
		
		return _SCORE;
	}
		



}
