using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuongTrai : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject No;
    public int speed = 5;    
      AudioSource audioSource;
    void Start()
    {
         animator = gameObject.GetComponent<Animator>();
           audioSource = GetComponent<AudioSource>();
         
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.right * speed *Time.deltaTime);
         
    }


      void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Va cham voi : " + col.gameObject.name);
        if (col.gameObject.name.Equals("ChuongTrai"))
        
            Destroy(col.gameObject);  
        
       else if (col.gameObject.tag.Equals("enemy"))
        {
            
            Instantiate(No, col.gameObject.transform.position, Quaternion.identity);
            

            Destroy(col.gameObject);
            audioSource.Play();
            
          

         
            
        }
         
  
    }
}
