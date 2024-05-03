using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public MainStorycs mainStorycs;


    void Start()
    {
        mainStorycs.NaninovelInitial();
    }


}
