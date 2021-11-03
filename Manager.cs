using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public GameObject Ball;

    public GameObject Controller;

    public List<GameObject> Bricks = new List<GameObject>();

    public GameObject GameOverText;

    public Text TimeText;

    public float GameTime;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        UpdateGameTime();
    }

    public void UpdateGameTime()
    {
        GameTime -= Time.deltaTime;
        TimeText.text = GameTime.ToString("0");
        GameTime = Mathf.Clamp(GameTime, 0, GameTime);
        if (GameTime <= 0)
        {
            DisplayGameOverText();
        }
    }

    public void OnAddBricksList(GameObject obj)
    {
        Bricks.Add(obj);
    }
    public void OnRemoveBricksList(GameObject obj)
    {
        Bricks.Remove(obj);
    }

    public void DisplayGameOverText()
    {
        GameOverText.SetActive(true);
    }

}
