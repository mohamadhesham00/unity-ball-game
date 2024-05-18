using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
	public float speed;
    public Text countText;
    private Rigidbody rb;
    private int count;
    public MenuController menuController;
    private AudioSource pop;
    // Start is called before the first frame update
    void Start()
    {
        //// Get the current active scene
        //Scene currentScene = SceneManager.GetActiveScene();

        //// Print the name of the current scene to the console
        //Debug.Log("Current scene name: " + currentScene.name);
        rb = GetComponent<Rigidbody>();  
        count = 0;
        speed = 8;
        SetCountText ();
        pop = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }
    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Gift")) {

            other.gameObject.SetActive (false) ;
            count++;
            pop.Play();    
            SetCountText ();
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            menuController.LoseGame();
            gameObject.SetActive(false);
        }
    }
    void SetCountText (){
        countText.text = "Count: " + count.ToString ();
        if (count >= 8)
        {
            menuController.WinGame();
            gameObject.SetActive(false);
        }
    }
    

}
