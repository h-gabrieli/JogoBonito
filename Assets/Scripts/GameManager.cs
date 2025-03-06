using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text pointText;

    private Player cat;


    // Start is called before the first frame update
    void Start()
    {
        
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            cat = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            pointText.text = $"{cat.fruits}";
        }
    }
}
