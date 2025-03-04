using UnityEngine;
public class Player : MonoBehaviour
{
    public int vida = 10;

    public string nome = "";

    public float velocidade = 20.5f;

    void Andar()
    {
        Debug.Log(gameObject);
    }
    void Start()
    {
        Andar();
    }
}