using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScript : MonoBehaviour
{
    public GameObject panel;

    public void Reload()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        panel.SetActive(false);
    }
}
