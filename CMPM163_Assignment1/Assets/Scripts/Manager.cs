using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void OnGUI()
    {
        int xCenter = (Screen.width / 2);
        int yCenter = (Screen.height / 2);
        int width = 100;
        int height = 60;

        GUIStyle fontSize = new GUIStyle(GUI.skin.GetStyle("button"));
        fontSize.fontSize = 32;

        Scene scene = SceneManager.GetActiveScene();

        if (GUI.Button(new Rect(10, 10, width, height), "A", fontSize))
        {
            SceneManager.LoadScene("A");
        }
        if (GUI.Button(new Rect(10 * 2 + width, 10, width, height), "B", fontSize))
        {
            SceneManager.LoadScene("B");
        }
        if (GUI.Button(new Rect(10 * 3 + width * 2, 10, width, height), "C", fontSize))
        {
            SceneManager.LoadScene("C");
        }
        if (GUI.Button(new Rect(10 * 4 + width * 3, 10, width, height), "Quit", fontSize))
        {
            Application.Quit();
        }
    }
}
