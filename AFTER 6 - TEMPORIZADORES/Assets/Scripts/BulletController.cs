using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float speedBullet = 2f;
    public  float timeBullet =  10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        timeBullet -= Time.deltaTime;
        Debug.Log(timeBullet);
        if(timeBullet > 0){
            MoveBullet(Vector3.forward);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }


    private void MoveBullet(Vector3 direction)
    {
        transform.Translate(speedBullet * Time.deltaTime * direction);
    }

}
