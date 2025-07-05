using UnityEngine;

public class Sons : MonoBehaviour
{

    [SerializeField] private AudioSource somDaChave;

    public static Sons instance;

    void Awake()
    {

        DontDestroyOnLoad(this.gameObject);

        if (instance != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            instance = this;
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        somDaChave = GameObject.Find("Som da Chave").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TocarSomDaChave()
    {
        somDaChave.Play();
    }
}

