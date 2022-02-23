using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void ChangeTo2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void ChangeTo1()
    {
        SceneManager.LoadScene("scene1");
    }
}
