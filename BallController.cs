using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public bool isStart;

    public float speed;

    private Vector3 lastVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        OnStartBall();

        SpeedController();
    }


    /// <summary>
    /// 未開始前
    /// </summary>
    public void OnStartBall()
    {
        if (!isStart)
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

    /// <summary>
    /// 球速計算
    /// </summary>
    public void SpeedController()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0);
        if (collision.gameObject.CompareTag("Brick"))
        {
            collision.gameObject.GetComponent<Brick>().OnGetHit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GameOverTrigger"))
        {
            Debug.LogError("球掉下去了");
            Manager.Instance.DisplayGameOverText();
        }

    }
}
