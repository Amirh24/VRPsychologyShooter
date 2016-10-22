using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour
{
    public delegate void UnityEventHandler();
    public static event UnityEventHandler pressedShoot;
    public static event UnityEventHandler revealedObject;


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Shoot"))
        {
            if (pressedShoot != null)
                pressedShoot();
        }
    }

    public void AvatarTurnedToParticipant()
    {
        if (revealedObject != null)
            revealedObject();
    }
}