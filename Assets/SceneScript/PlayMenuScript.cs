using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayMenuScript : MonoBehaviour
{
    public GameObject panel;
    public void PlayMenu()
    {
        SceneManager.LoadScene(1);
    }
}
