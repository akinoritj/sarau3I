using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip somChoque;
    [SerializeField] private AudioClip somExplosao;
    [SerializeField] private AudioClip somChicote;
    [SerializeField] private AudioClip somAfogamento;
    [SerializeField] private AudioClip somEspancamento;
    [SerializeField] private AudioClip somAfogamento2;
    [SerializeField] private AudioClip musicaRuaAugusta;
    [SerializeField] private AudioClip musicaCalice;
    [SerializeField] private AudioClip musicaPaixao;
    [SerializeField] private AudioClip musicaHoje;
    [SerializeField] private AudioClip musicaBanhodeLua;

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

    public void BotaoMscHoje()
    {
        audioSource.PlayOneShot(musicaHoje);
    }

    public void BotaoChicote()
    {
        audioSource.PlayOneShot(somChicote);
    }

    public void BotaoAfogamento()
    {
        audioSource.PlayOneShot(somAfogamento);
    }

    public void BotaoEspancamento()
    {
        audioSource.PlayOneShot(somEspancamento);
    }

    public void BotaoAfogamento2()
    {
        audioSource.PlayOneShot(somAfogamento2);
    }

    public void BotaoRuaAugusta()
    {
        audioSource.PlayOneShot(musicaRuaAugusta);
    }

    public void BotaoExplosao()
    {
        audioSource.PlayOneShot(somExplosao);
    }

    public void BotaoMusicaCalice()
    {
        audioSource.PlayOneShot(musicaCalice);
    }

    public void BotaoPaixao()
    {
        audioSource.PlayOneShot(musicaPaixao);
    }

    public void BotaoMusicaBanhoDeLua()
    {
        audioSource.PlayOneShot(musicaBanhodeLua);
    }

    public void PararAudio()
    {
        audioSource.Stop();
    }

    public void Sair()
    {
        Application.Quit();
    }
}
