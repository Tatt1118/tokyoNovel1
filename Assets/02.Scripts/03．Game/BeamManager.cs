using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

/// <summary>
/// Beam�̔���A�Ǘ�����X�N���v�g
/// </summary> <summary>
///
/// </summary>
public class BeamManager : MonoBehaviour
{

    private float dx;
    private float dy;
    private float speed = 0.5f;

    void Update()
    {
        transform.position += new Vector3(dx, dy, 0) * Time.deltaTime;
    }

    public void BeamPos(Vector3 beamPos)
    {

        dx = beamPos.x;
        dy = beamPos.y;

    }


}

