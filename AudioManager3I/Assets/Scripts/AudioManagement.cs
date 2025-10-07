using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip somChoque;
    [SerializeField] private AudioClip somGrito;
    [SerializeField] private AudioClip somChicote;
    [SerializeField] private AudioClip somAfogamento;
    [SerializeField] private AudioClip somMurro;
    [SerializeField] private AudioClip somTapa;
    [SerializeField] private AudioClip somMarteloTribunal;
    void Start()
    {

    }

    void Update()
    {

    }

    public void BotaoChoque()
    {
        audioSource.PlayOneShot(somChoque);
    }

    public void BotaoGrito()
    {
        audioSource.PlayOneShot(somGrito);
    }

    public void BotaoChicote()
    {
        audioSource.PlayOneShot(somChicote);
    }

    public void BotaoAfogamento()
    {
        audioSource.PlayOneShot(somAfogamento);
    }

    public void BotaoMurro()
    {
        audioSource.PlayOneShot(somMurro);
    }

    public void BotaoTapa()
    {
        audioSource.PlayOneShot(somTapa);
    }

    public void BotaoMarteloTribunal()
    {
        audioSource.PlayOneShot(somMarteloTribunal);
    }
}
