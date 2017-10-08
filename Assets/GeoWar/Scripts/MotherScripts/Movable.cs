using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MinMaxRange
{
    public float minX, maxX, minY, maxY;
}

public class Movable : MonoBehaviour
{
    [SerializeField]
    private MinMaxRange limits;
    [Tooltip("Speed of the GameObject")]
    [SerializeField]
    private float speed = 4.5f;
    [Tooltip("Rotation of the GameObject")]
    [SerializeField]
    private float rotationSpeed = 65;

    protected Vector3 dir;

    public void Advance()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, limits.minX, limits.maxX),
            Mathf.Clamp(transform.position.y, limits.minY, limits.maxY),
            0.0f
        );
    }

    public void Advance(float speed)
    {
        transform.Translate(dir * speed * Time.deltaTime);
        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, limits.minX, limits.maxX),
            Mathf.Clamp(transform.position.y, limits.minY, limits.maxY),
            0.0f
        );
    }

    public void Rotate(float value)
    {
        transform.Rotate(new Vector3(0, 0, value * rotationSpeed * Time.deltaTime));
        dir = new Vector3(Mathf.Cos(Mathf.PI * (transform.rotation.z / 180)), Mathf.Sin(Mathf.PI * (transform.rotation.z / 180)), 0);
    }
}
