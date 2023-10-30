using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	float elapsedTime;
	bool counter_flag = false;

	

	void Update()
	{
		//Spaceキーで計測開始、停止を切り替え
		if (Input.GetKey(KeyCode.Space))
		{
			counter_flag = !counter_flag;
		}

		if (counter_flag == true)
		{
			elapsedTime += Time.deltaTime;
			Debug.Log("計測中： " + (elapsedTime).ToString());
		}
	}

}
public class keikajikann : MonoBehaviour
{

	[SerializeField]
	private int minute;
	[SerializeField]
	private float seconds;
	//　前のUpdateの時の秒数
	private float oldSeconds;
	//　タイマー表示用テキスト
	private Text timerText;

	private int _SCORE;

	void Start()
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
		//　値が変わった時だけテキストUIを更新
		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
			_SCORE = (int)seconds;
		}
		oldSeconds = seconds;
	}

	public int GetSCORE()
    {
		
		return _SCORE;
	}
		



}
