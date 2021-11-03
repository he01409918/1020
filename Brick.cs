using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    private void Start()
    {
        Manager.Instance.OnAddBricksList(this.gameObject);
    }

    public void OnGetHit()
    {
        Manager.Instance.OnRemoveBricksList(this.gameObject);
        Destroy(gameObject);
    }
}
