using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public ParticleSystem explosionParticle;
   

    // Start is called before the first frame update
    void Start()
    {


    }
   
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("fire"))
        {
            int scaleBeforeCollision = (int)collision.gameObject.transform.localScale.x;
            if (scaleBeforeCollision > 2)
            {
                int nextScale = (int)scaleBeforeCollision / 2;
                for (int i = 0; i < 2; i++)
                {
                    GameObject go = Instantiate(collision.gameObject, new Vector3(Random.Range(collision.gameObject.transform.position.x - 1, collision.gameObject.transform.position.x + 1), collision.gameObject.transform.position.y, -2), Quaternion.identity);
                    go.transform.localScale = new Vector3(nextScale, nextScale, nextScale);
                }

            }


            else
            {
                soundManager.instance.playAudio();
                explosionParticle.Play();
                Instantiate(explosionParticle, collision.gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(collision.gameObject);
                soundManager.instance.Add();
            }
        }
        if (collision.gameObject.CompareTag("player"))
        {
            soundManager.instance.healthloss();
            
        }
    }


}
