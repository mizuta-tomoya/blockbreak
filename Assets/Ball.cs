using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myRigid;
    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigid=this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward+transform.right)*speed,ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (myManager.isGameClear == false)
        {
            if (collision.gameObject.tag == "Finish")
            {
                Destroy(this.gameObject);
                myManager.GameOver();
            }
        }
        
    }
}
