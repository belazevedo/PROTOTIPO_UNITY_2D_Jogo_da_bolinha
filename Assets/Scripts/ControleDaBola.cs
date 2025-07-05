using UnityEngine;
// comentário de teste
public class ControleDaBola : MonoBehaviour
{

    [SerializeField] private float velocidade;
    [SerializeField] private Rigidbody2D oRigidbody2d;
    private Vector2 teclasApertadas;

    void Start()
    {
        oRigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovimentarBola();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    private void MovimentarBola()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        oRigidbody2d.linearVelocity = teclasApertadas.normalized * velocidade;
    }

    private void SairDoJogo()
    {
        Application.Quit();
    }

}
