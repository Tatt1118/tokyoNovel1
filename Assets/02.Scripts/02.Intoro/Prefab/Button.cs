using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject kuusou;
    public GameObject kieru;

    public void OnClick()
    {
        Destroy(GameObject.Find("EventSystem").gameObject);
        kuusou.SetActive(true);
        kieru.SetActive(false);
    }

}
