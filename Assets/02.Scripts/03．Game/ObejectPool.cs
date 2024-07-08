using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObejectPool : MonoBehaviour
{

    [SerializeField] GameObject prefabObj;
    [SerializeField] GameObject beamPos;
     List<GameObject> pool;

    public void CreatePool(int maxCount)
    {
        pool = new List<GameObject>();
        for (int i = 0;i < maxCount; i++)
        {
            GameObject go = Instantiate(prefabObj);
            go.SetActive(false);
            pool.Add(go);
        }
    }

    public GameObject GetObj(Vector2 position)
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if (pool[i].activeSelf==false)
            {
                GameObject go = pool[i];
                go.transform.position = position;
                go.SetActive(true);
                return go;
            }
        }
        
        GameObject newgo = Instantiate(prefabObj, position,Quaternion.identity);
        newgo.SetActive(false);
        pool.Add(newgo);
        return newgo;

    }
}
