using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour
{

    // Use this for initialization
    public int numberOfTests = 12;

    private int testNumber;
    private bool startedTimer = false;
    private float timer = 0.0f;
    private Avatar[] arrayOfAvatars;
    private float[] arrayOfShootingTimes;
    private Vector3[] arrayOfSpawningLocations = {new Vector3(2f, 2f, 2f), new Vector3(2f, 2f, 2f), new Vector3(2f, 2f, 2f) }; //Change locations

    void Start()
    {

        arrayOfAvatars = new Avatar[numberOfTests];
        arrayOfShootingTimes = new float[numberOfTests];

        EventManager.revealedObject += StartTimer; // turned to camera and revealed object

        EventManager.pressedShoot += StopTimerByShot;
        //To write : EventManager.outOfZone = StopTimerByLeavingZone;

        // for (int i = 0;  i < numberOfTests; i++) {
        //      StartTest(arrayOfAvatars[i],i);
        //       }

    }
    void Update()
    {
        if (startedTimer)
        {
            timer += Time.deltaTime;
        }
    }


    public void StartTimer()
    {
        // make Coroutine that updates
        startedTimer = true;
    }

    public void StopTimerByShot()
    {
        startedTimer = false;
        // avatarRace = GetAvatarRace; ??
        arrayOfShootingTimes[testNumber] = timer;
    }

    public void StopTimerByLeavingZone()
    {
        startedTimer = false;
    }

    private void StartTest(Avatar avatar,int indexOfAvatar)
    {
        testNumber = indexOfAvatar;
        //instansiate in random place choosen between 3 places;
    }

}
