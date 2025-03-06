
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField]private float speed;
    
    private Rigidbody2D rb;

    public AudioClip collectAudio;

    public AudioClip collectAudio2;

    public int fruits = 0;


    void Start()
    {
       rb = gameObject.GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        Moviment();
    }

    public void Moviment()
    {
        float horizontalmoviment = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalmoviment * speed, rb.velocity.y);
        if(horizontalmoviment < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Verifica se é "Fruta" <-><-> "Fruta2"
        if(collision.gameObject.CompareTag("Fruta"))
        {
            fruits++; 
            Destroy(collision.gameObject);
            GerenciadorAudio.musica.PlayA(collectAudio);

        }else if(collision.gameObject.CompareTag("Fruta2"))
        {
            fruits++; // Aumenta o contador -> frutas
            Destroy(collision.gameObject);  // Destroi a fruta coletada
            GerenciadorAudio.musica.PlayA(collectAudio2); // Som "Fruta2"
        }
    }

}