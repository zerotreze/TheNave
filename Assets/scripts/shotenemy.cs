using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotenemy : MonoBehaviour
{
  //  public GameObject impactoDoLaserDoInimigo;

    public float velocidadeDoLaser;
    public float velocidadeDoLaserr;
    public int danoParaDar;
   
  
   void Start()
    {
        
       
    Destroy(this.gameObject, 8f);
    
        
    }
    
    void Update()
    {
       // Destroy(this.gameObject, 5f);
        MovimentarLaser();
    }


    
    // void Update()
    // {
    //     Destroy(this.gameObject, 0.92f);
    //     MovimentarLaser();
    // }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.left * velocidadeDoLaser * Time.deltaTime);
        transform.Translate(Vector3.right * velocidadeDoLaserr * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<playy>().Hiit();
            other.gameObject.GetComponent<vidaDoJogador>().MachucarJogador(danoParaDar);
           // Instantiate(impactoDoLaserDoInimigo, transform.position, transform.rotation);
            Destroy(this.gameObject);

          
            
        }
        if (other.gameObject.CompareTag("escudo"))
        {
         
           Destroy(this.gameObject);
        
            
        }
        
    }
    
    
}