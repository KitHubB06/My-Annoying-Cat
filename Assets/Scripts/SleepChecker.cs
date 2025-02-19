using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SleepChecker : MonoBehaviour
{
    private bool isSleep;
    [SerializeField] private float maxSleepTime = 10;
    private Cat cat;
    // Start is called before the first frame update

    private void Start()
    {
        isSleep = Convert.ToBoolean(PlayerPrefs.GetInt("isSleep"));

        if(isSleep)
        {
            CheckSleep();
        }
        
    }
    public void GoSleep()
    {
        isSleep = true;

        string sleepTime = DateTime.UtcNow.ToString();
        Debug.Log(sleepTime);
        PlayerPrefs.SetInt("isSleep", isSleep ? 1 : 0);
        PlayerPrefs.SetString("SleepTime", sleepTime);

    }

    public void ResetSleep()
    {
        isSleep = false;
        PlayerPrefs.SetInt("isSleep", isSleep ? 1 : 0);
        Debug.Log("НЕ СИГМАЄ");
    }


    private void CheckSleep()
    {
        string sleepTime = PlayerPrefs.GetString("SleepTime");
        DateTime lastSleepTime = DateTime.Parse(sleepTime);
        TimeSpan timePassed = DateTime.UtcNow - lastSleepTime;
        Debug.Log(timePassed.TotalSeconds);

        if (timePassed.TotalSeconds > maxSleepTime)
        {
            Debug.Log("Кот на кондициях");
        }
    }
}