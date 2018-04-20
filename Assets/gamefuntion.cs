using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamefuntion : MonoBehaviour {
    public Text ScoreText; //宣告一個ScoreText的text

    public int Score = 0; // 宣告一整數 Score
    int timecount = 10;

    public Text showTime;
    public Text win;
    public static gamefuntion Instance; // 設定Instance，讓其他程式能讀取GameFunction
                                         // Use this for initialization
    void Start () {
        Instance = this;
        InvokeRepeating("timer", 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
		if(Score>=30)
        {
            win.text = "You Win";
        }
        if(timecount==0)
        {
            Time.timeScale = 0;
            win.text = "You Lose";
        }
	}
    public void AddScore()

    {

        Score += 10; //分數+10

        ScoreText.text = "Score: " + Score; // 更改ScoreText的內容

    }
    void timer()
    {

        timecount -= 1;

        showTime.text = "Time:"+timecount;

        if (timecount == 0)
        {

            showTime.text = "time\nup";

            CancelInvoke("timer");

        }

    }


}
