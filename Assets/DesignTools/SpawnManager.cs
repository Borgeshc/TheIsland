using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    //Waves will spawn units in waves.
    //OneTimeSpawn will spawn a selected amount of units once.
    //SurviveForTime will continue to spawn units until time runs out.

    public enum Status { None, Waves, OneTimeSpawn, SurviveForTime };

    [Header("Object Adjustment Variables")]
    [HideInInspector]
    public Status state;

    void Update()
    {
        switch(state)
        {
            case Status.None:
                print("No spawning state has been selected.");
                break;
            case Status.Waves:
                //Logic
                break;
            case Status.OneTimeSpawn:
                //Logic
                break;
            case Status.SurviveForTime:
                //Logic
                break;
        }
    }

}
//Still need to set up the vairables and the logic.