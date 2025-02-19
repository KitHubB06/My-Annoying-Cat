using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public GameObject Kitchen;
    public GameObject Bedroom;
    public GameObject BAthroom;
    public GameObject Playroom;
    private GameObject currentRoom;
    [SerializeField]  private SleepChecker sleepChecker;
    // Start is called before the first frame update
    void Start()
    {
        currentRoom = Playroom;
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        BAthroom.SetActive(false);
        Playroom.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToKitchen()
    {
        currentRoom.SetActive(false);
        currentRoom = Kitchen;
        currentRoom.SetActive(true);
        sleepChecker.ResetSleep();


    }
    public void GoToBedroom()
    {
        currentRoom.SetActive(false);
        currentRoom = Bedroom;
        currentRoom.SetActive(true);
        sleepChecker.ResetSleep();

    }
    public void GoToBAthroom()
    {
        currentRoom.SetActive(false);
        currentRoom = BAthroom;
        currentRoom.SetActive(true);
        sleepChecker.ResetSleep();



    }
    public void GoToPlayroom()
    {
        currentRoom.SetActive(false);
        currentRoom = Playroom;
        currentRoom.SetActive(true);
        sleepChecker.ResetSleep();



    }
}
