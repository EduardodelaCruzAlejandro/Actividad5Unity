using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{

    [SerializeField] float time;
    [SerializeField] GameObject prefab;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            print("Hola");
            Instantiate(prefab, Vector2.zero, Quaternion.identity);
        }
    }


  
    
}
