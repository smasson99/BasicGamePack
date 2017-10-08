using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    #region:serializedRegion
    [Tooltip("The background of the game")]
    [SerializeField]
    private GameObject background;

    [Tooltip("The star to generate")]
    [SerializeField]
    private GameObject starPrefab;

    [Tooltip("The number of stars to generate")]
    [SerializeField]
    private int nbStars = 200;
    #endregion

    private int capacity;
    private GameObject[] tabStars;
    public GameObject[] TabStars
    {
        get
        {
            return tabStars;
        }
        set
        {
            tabStars = value;
        }
    }
    public MinMaxRange limits;

    private void Start()
    {
        capacity = nbStars;
        tabStars = new GameObject[capacity];

        for (int i = 0; i < capacity; ++i)
        {
            tabStars[i] = starPrefab;
            GameObject pref = Instantiate(tabStars[i]);
            Canvas myCanvas = Camera.main.GetComponentInChildren<Canvas>();
            float x = Random.Range(limits.minX, limits.maxX);
            float y = Random.Range(limits.minY, limits.maxY);
            pref.transform.position = new Vector3(x, y, 0);
        }
    }
}
