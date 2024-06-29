using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 特定の座標に向かってビームを出す
/// </summary>
public class CharaManager : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private Beam beamPrefb;

    [SerializeField, Header("弾を発射する時間")]
    private float shootTime;

    [SerializeField, Header("座標位置")]
    private GameObject moonPos;

    void Update()
    {
        Beam();
    }



    public void Beam()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(beamPrefb, transform.position, transform.rotation);
            beamPrefb.Setting();

        }
fdsafsaffdsafdsafdasfkjdfkldsajflkdajsflkjdsaklfjdskalfjkdslajffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff