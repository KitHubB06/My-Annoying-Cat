using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    [SerializeField] private float sleep;
    [SerializeField] private float happines;
    [SerializeField] private float hungry;
    [SerializeField] private float thirsty;
    
     
    //private float hygiene;

    public Slider sleepSlider;
    public Slider happinesSlider;
    public Slider hungrySlider;
    public Slider thirstySlider;
   // public Slider hygieneSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        sleepSlider.maxValue = 100;
        happinesSlider.maxValue = 100;
        hungrySlider.maxValue = 100;
        thirstySlider.maxValue = 100;
       // hygieneSlider.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        sleep -= 1 * Time.deltaTime;
        happines -= 1 * Time.deltaTime;
        hungry -= 1 * Time.deltaTime;
        thirsty -= 1 * Time.deltaTime;
       // hygiene -= 1 * Time.deltaTime;

        sleepSlider.value = sleep;
        happinesSlider.value = happines;
        hungrySlider.value = hungry;
        thirstySlider.value = thirsty;
        //hygieneSlider.value = hygiene;


    }
    public void AddHungry(float addToHungry)
    {
        hungry += addToHungry;

        if(hungry > 100)
        {
            hungry = 100;
        }
    }
}
