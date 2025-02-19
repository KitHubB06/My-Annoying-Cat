using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    private int money;
    [SerializeField] TMP_Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        
        if (money == 0)
        {
            money = 100;
            PlayerPrefs.SetInt("Money", money);
            money = PlayerPrefs.GetInt("Money");
        }
        moneyText.text = "" + money;
    }

    public void SubtractMoney(int subMoney)
    {
        money -= subMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = "" + money;


    }
    public int GetMoney()
    {
        return money;
    }

}
