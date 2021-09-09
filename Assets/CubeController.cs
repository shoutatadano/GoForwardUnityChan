using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float deadLine = -10;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

      if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D( Collision2D Collision)
    {

        if (Collision.gameObject.tag == "CubeTag")
        {
           
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }

        if (Collision.gameObject.tag == "GroundTag")
        {
            
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
    }
}
