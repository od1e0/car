using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continuescript : MonoBehaviour
{
    public GameObject panel;

    public void Continue()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
        
    }
}
