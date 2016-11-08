using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour
{
    public enum TriggerType { None, OnTriggerEnter, OnTriggerExit, OnTriggerStay };
    public enum TriggeredEffect { None, PlayAnimation, Collectables, TakeDamage, Died, LoadNextLevel, LoseScreen, WinScreen };

    [HideInInspector, Header("Choose Trigger Type")]
    public TriggerType type;
    [HideInInspector, Header("Choose Trigger Effect")]
    public TriggeredEffect effect;
    
    private bool onTriggerEnter;
    private bool onTriggerExit;
    private bool onTriggerStay;
    
    void OnTriggerEnter(Collider other)
    {
        if(onTriggerEnter)
        {
            //The effect enum goes in here
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(onTriggerExit)
        {
            //The effect enum goes in here
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(onTriggerStay)
        {
            //The effect enum goes in here
        }
    }
}