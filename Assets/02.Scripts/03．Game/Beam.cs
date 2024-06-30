using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///Beam管理
/// </summary>
public class Beam : MonoBehaviour
{
    private float dx;
    private float dy;

    void Update()
    {
        transform.position += new Vector3(dx, dy, 0) * Time.deltaTime;
    }

    public void Setting(Vector3 pos, float speed)
    {
        dx = pos.x * speed;
        dy = pos.y * speed;
    }
}
