using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
	public GameObject player; //player represents the Player who is the ball
    private Vector3 offset; 
    void Start () {
        //we start by recovering the initial distance between the Camera and the Player
         offset = transform.position - player.transform.position;
    }
    // the difference between update and LateUpdate that it runs after all items have been updated
    void LateUpdate () {
        //The Camera will always keep the same distance from the Player
         transform.position = player.transform.position + offset;

    }


}
