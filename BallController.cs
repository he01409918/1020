using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public bool isStart;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isStart  == false)
        {
            GameObject Controller = Manager.Instance.Controller;
            Vector3 offset = new Vector3(0, 0.8f, 0);
            transform.position = Controller.transform.position + offset;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);
                isStart = true;
            }
        }
    }

}
