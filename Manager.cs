using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public GameObject Ball;

    public GameObject Controller;
    void Start()
    {
        Instance = this;
    }

}
