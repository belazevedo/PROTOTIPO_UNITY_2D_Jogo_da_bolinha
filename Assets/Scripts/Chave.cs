using UnityEngine;

public class Chave : MonoBehaviour
{

    [SerializeField] private GameObject portaParaAbrir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        portaParaAbrir = GameObject.Find("Porta Trancada");
    }


    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        FindAnyObjectByType<Sons>().TocarSomDaChave();

        Debug.Log("Você coletou a chave.\nA porta está aberta!");
        
        Destroy(this.gameObject);

        Destroy(portaParaAbrir);
    }
    
}
