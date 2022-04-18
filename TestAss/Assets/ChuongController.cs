using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuongController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public int speed = 5;
   public GameObject No;
     AudioSource audioSource;
   
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
          audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed *Time.deltaTime);
       
       
    }

    
        void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Va cham voi : " + col.gameObject.name);
        if (col.gameObject.name.Equals("Chuong"))
        Destroy(col.gameObject);  
        
       else if (col.gameObject.tag.Equals("enemy"))
        {
            
            Instantiate(No, col.gameObject.transform.position, Quaternion.identity);
            
            Destroy(col.gameObject);
            audioSource.Play();
          
          

         
            
        }
         
  
    }
}
