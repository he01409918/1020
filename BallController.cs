using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool isStart;

    private void Update()
    {
        if (isStart  == false)
        {
            GameObject Controller = Manager.Instance.Controller;
            Vector3 offset = new Vector3(0, 2f, 0);
            transform.position = Controller.transform.position + offset;
        }
    }
}
