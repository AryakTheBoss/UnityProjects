using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static UnityEngine.Debug;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject explosionEffect;
    public GameObject timer;
    private bool listenForClicks;
    void Start()
    {
        listenForClicks = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timer.GetComponent<Timer>().isTimerRunning())
        {
            listenForClicks = false;
        }
    }

    private void OnMouseDown()
    {
        if (listenForClicks)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().scoreUp();
            explosionEffect.transform.position = gameObject.transform.position;
            // UnityEngine.Debug.Log(explosionEffect.transform.position);
            explosionEffect.SetActive(false);
            explosionEffect.SetActive(true);
            Destroy(gameObject);
        }
       
    }
}
