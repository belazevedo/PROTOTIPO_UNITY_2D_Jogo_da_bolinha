using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarDeFase : MonoBehaviour
{

    [SerializeField] int proximaFase;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        proximaFase = SceneManager.GetActiveScene().buildIndex + 1;

        if (proximaFase < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(proximaFase);
        }

        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
