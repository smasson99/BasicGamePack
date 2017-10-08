using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Movable
{
    [Header("Key Configuration")]
    [Tooltip("Key used to move LEFT")]
    [SerializeField]
    private string leftKey = "a";
    [Tooltip("Key used to move the GameObject RIGHT")]
    [SerializeField]
    private string rightKey = "d";
    [Tooltip("Key used to move the GameObject UP")]
    [SerializeField]
    private string upKey = "w";


    private void Start()
    {
        dir = new Vector3(Mathf.Cos(transform.rotation.z), Mathf.Sin(transform.rotation.z), 0);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        RotateIfKeyPressed(1, leftKey);
        RotateIfKeyPressed(-1, rightKey);
        MoveIfKeyPressed(upKey);

        Advance(0.7f);
    }

    private void MoveIfKeyPressed(string keyCode)
    {
        if (Input.GetKey(keyCode))
        {
            Advance();
        }
    }

    private void RotateIfKeyPressed(float value, string keyCode)
    {
        if (Input.GetKey((keyCode)))
        {
            Rotate(value);
        }
    }
}
