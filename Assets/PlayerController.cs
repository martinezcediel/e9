using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public GameObject Character;
    public float Speed = 5f;

    public bool canControl;

    // Update is called once per frame
    void Update()
    {
        if (canControl == true)
        {
            float h = Input.GetAxis("Horizontal") * Speed;

            Character.transform.Translate(h * Time.deltaTime, 0, 0);
        }
    }

}
