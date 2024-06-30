using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Beam beamPrefb;
    [SerializeField] GameObject moonPos;
    [SerializeField] GameObject beamPos;

    void Start()
    {
        StartCoroutine(PlayerBeam(3));
    }

    public void GoBeam(Vector3 pos, float speed)
    {

        Beam beam = Instantiate(beamPrefb, beamPos.transform.position, transform.rotation);
        beam.Setting(pos, speed);

    }

    IEnumerator PlayerBeam(float speed)
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            if (moonPos != null)
            {
                Vector3 targetPos = moonPos.transform.position;
                GoBeam(targetPos, speed);
            }
        }
    }
}
