using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    SpriteRenderer renderer;
    AudioSource audioSource;

    public int speed = 5;
    string status = "status";
    public GameObject chuong, chuongtrai;
    public float jumb = 3f;
  
    void Start()
    {

        animator = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
              renderer.flipX = true;
             transform.Translate(Vector3.left * speed * Time.deltaTime);
             animator.SetInteger(status, 2);

        }else if(Input.GetKey(KeyCode.D)){
                renderer.flipX = false;
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                animator.SetInteger(status, 2);

        }

          if(Input.GetKey(KeyCode.S)){
              animator.SetInteger(status,3);
            
        }

         if(Input.GetKey(KeyCode.Space)){
              animator.SetInteger(status,1);
               gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2( gameObject.GetComponent<Rigidbody2D>().velocity.x, jumb);
            
        }
     
        if(Input.GetKeyDown(KeyCode.F)){
            Vector3 vector3 = transform.position;
            vector3.x = vector3.x +1;

              
          

            if(renderer.flipX == true){
                 Instantiate(chuong,transform.position, Quaternion.identity);

            }
            if(renderer.flipX == false){
                 Instantiate(chuongtrai,vector3, Quaternion.identity);

            }
            audioSource.Play();
           
        }
    }
}
