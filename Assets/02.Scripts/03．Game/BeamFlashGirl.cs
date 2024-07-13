using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;



public class BeamFlashGirl : MonoBehaviour
{

    [SerializeField] GameObject moonPos;
    [SerializeField] BeamManager beamPrefb;



    void Beam(Vector3 pos)
    {

        BeamManager beam = Instantiate(beamPrefb, transform.position, Quaternion.identity);

        beam.BeamPos(pos);


    }

    private async UniTask BeamShot()
    {


    }






}
