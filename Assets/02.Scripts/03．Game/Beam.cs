using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///
/// </summary>
public class Beam : MonoBehaviour
{
    [SerializeField, Header("弾の速度")]
    private float speed;

    private float dx;
    private float dy;

    void Start()
    {
    }


    public void Setting()
    {

        transform.position += new Vector3(0, 1.0f, 0);

    }
}
