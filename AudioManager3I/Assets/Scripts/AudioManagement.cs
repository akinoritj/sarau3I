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
    [SerializeField] private AudioClip somExplosao;
    [SerializeField] private AudioClip musicaCalice;
    [SerializeField] private AudioClip musica2;
    [SerializeField] private AudioClip musicaAmbiente;

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

    public void BotaoExplosao()
    {
        audioSource.PlayOneShot(somExplosao);
    }

    public void BotaoMusicaCalice()
    {
        audioSource.PlayOneShot(musicaCalice);
    }

    public void BotaoMusica2()
    {
        audioSource.PlayOneShot(musica2);
    }

    public void BotaoMusicaAmbiente()
    {
        audioSource.PlayOneShot(musicaAmbiente);
    }

    public void PararAudio()
    {
        audioSource.Stop();
    }
}
