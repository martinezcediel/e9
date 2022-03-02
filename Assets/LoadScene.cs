using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeTo2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void ChangeTo1()
    {
        SceneManager.LoadScene("scene1");
    }
}
