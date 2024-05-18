using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //we apply a rotation to the Target cube
     transform.Rotate (new Vector3 (30, 60, 90) * Time.deltaTime) ;

    }
}
