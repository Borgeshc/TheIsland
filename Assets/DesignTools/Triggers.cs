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

    //TriggeredEffect Variables
    //PlayAnimation Variables
    [HideInInspector, Header("Set Animation Variables"), Tooltip("The Animator that is on the object.")]
    public Animator animatorController;
    [HideInInspector, Tooltip("The name(s) of the Animation Clip(s) you want to play.")]
    public string animationClips;

    void Update()
    {
        switch(type)
        {
            case TriggerType.None:
                break;
            case TriggerType.OnTriggerEnter:
                onTriggerEnter = true;
                break;
            case TriggerType.OnTriggerExit:
                onTriggerExit = true;
                break;
            case TriggerType.OnTriggerStay:
                onTriggerStay = true;
                break;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(onTriggerEnter)
        {
            //The effect enum goes in here
            switch (effect)
            {
                case TriggeredEffect.None:
                    break;
                case TriggeredEffect.PlayAnimation:
                    PlayAnimation();
                    break;
                case TriggeredEffect.Collectables:
                    break;
                case TriggeredEffect.TakeDamage:
                    break;
                case TriggeredEffect.Died:
                    break;
                case TriggeredEffect.LoadNextLevel:
                    break;
                case TriggeredEffect.LoseScreen:
                    break;
                case TriggeredEffect.WinScreen:
                    break;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(onTriggerExit)
        {
            //The effect enum goes in here
            switch (effect)
            {
                case TriggeredEffect.None:
                    break;
                case TriggeredEffect.PlayAnimation:
                    PlayAnimation();
                    break;
                case TriggeredEffect.Collectables:
                    break;
                case TriggeredEffect.TakeDamage:
                    break;
                case TriggeredEffect.Died:
                    break;
                case TriggeredEffect.LoadNextLevel:
                    break;
                case TriggeredEffect.LoseScreen:
                    break;
                case TriggeredEffect.WinScreen:
                    break;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(onTriggerStay)
        {
            //The effect enum goes in here
            switch (effect)
            {
                case TriggeredEffect.None:
                    break;
                case TriggeredEffect.PlayAnimation:
                    PlayAnimation();
                    break;
                case TriggeredEffect.Collectables:
                    break;
                case TriggeredEffect.TakeDamage:
                    break;
                case TriggeredEffect.Died:
                    break;
                case TriggeredEffect.LoadNextLevel:
                    break;
                case TriggeredEffect.LoseScreen:
                    break;
                case TriggeredEffect.WinScreen:
                    break;
            }
        }
    }

    void PlayAnimation()
    {

    }
}