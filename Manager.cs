using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public GameObject Ball;
    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        
    }
}
