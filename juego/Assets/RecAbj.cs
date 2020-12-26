using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecAbj : MonoBehaviour{
    private Jugador Jugador;
    public GameObject RecArrb;

    // Start is called before the first frame update
    void Start(){
        Jugador = FindObjectOfType<Jugador>();
        
    }

    // Update is called once per frame
    void Update(){
        if(Jugador.transform.position.x - transform.position.x > 12  ){
            float yRandom = Random.Range(-4, 4);
            float RandomEspacio=Random.Range(0, 3);

            Instantiate(gameObject, new Vector2(Jugador.transform.position.x +10, -7+yRandom), transform.rotation);
            Instantiate(RecArrb, new Vector2(Jugador.transform.position.x +10, 7+yRandom+RandomEspacio), transform.rotation);

            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collicion){
        Jugador.Reinicio();
    }
}
