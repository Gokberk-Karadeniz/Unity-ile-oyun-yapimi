using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gezgin : MonoBehaviour
{
    public void OyunaGit()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void MenuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    public void YenidenBasla()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }
}
