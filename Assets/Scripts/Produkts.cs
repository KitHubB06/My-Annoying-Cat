using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produkts : MonoBehaviour
{
    [SerializeField] int countFood;
    [SerializeField] float addToHungry;
    [SerializeField] private string foodName;
    [SerializeField] private Cat cat;
    // Start is called before the first frame update
    void Start()
    {
        countFood = PlayerPrefs.GetInt(foodName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddToHungry()
    {
        if (countFood > 0)
        {
            cat.AddHungry(addToHungry);
        }
    }
}
