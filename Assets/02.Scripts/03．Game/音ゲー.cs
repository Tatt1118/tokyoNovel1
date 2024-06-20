using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 音ゲー : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    Rigidbody2D rb;
    public int speed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.down.normalized * -speed;

    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            OnShot();
            Debug.Log("OK");
        }

    }


    public void OnShot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        Debug.Log("dasu");
    }
}
