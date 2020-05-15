using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
  private float gameTimer = 0f;
  public Text timerText;
  public void Update(){
    gameTimer += Time.deltaTime;

    int seconds= (int)(gameTimer % 60);
    int minutes= (int)(gameTimer / 60)% 60;
    int hours= (int)(gameTimer/ 3600)% 24;

    string timerStr= string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
    timerText.text=timerStr;
    print(timerStr);
  }
}
