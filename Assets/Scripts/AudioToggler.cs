using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggler : MonoBehaviour
{
    public bool IsOn;

    public void Start()
    {
        IsOn = true;
    }

    public void OnOffSounds()
    {
        if(!IsOn)
        {
            AudioListener.volume = 1f;
            IsOn = true;
        }else if (IsOn)
        {
            AudioListener.volume = 0f;
            IsOn = false;
        }

    }

}
