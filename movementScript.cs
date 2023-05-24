using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody playerbody;
    float timer;
    public float force = 3;
    public bool trigger = false;
    public float cooldown = 5;

    void Start()
    {
        timer = 0;
        trigger = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer>cooldown&&trigger){
            playerbody.AddForce(transform.forward*force,ForceMode.Impulse);
            timer = 0;
        }
    }

    public void Activate(bool t){
        trigger = t;
    }
}
