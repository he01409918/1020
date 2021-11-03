using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public GameObject Ball;

    public GameObject Controller;

    public List<GameObject> Bricks = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
    }

    public void OnAddBricksList(GameObject obj)
    {
        Bricks.Add(obj);
    }
    public void OnRemoveBricksList(GameObject obj)
    {
        Bricks.Remove(obj);
        if (Bricks.Count == 0)
        {
            Debug.LogError("1");
        }
    }

}
