using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public OpenMainMenu other;

    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] private AudioClip _compressClip, _uncompressClip;
    [SerializeField] private AudioSource _source;
    //Henter lyder og bilder for a trykke pa knappen

    // void Start () 
    // {
    //     openInventory.MethodFromOpenInventory();
    // }

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        _source.PlayOneShot(_compressClip);
    }
    //Funksjon for lyd og bilde når man trykker på knappen

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
        _source.PlayOneShot(_uncompressClip);
    }
    //Funksjon på når man er ferdig med å trykke på knappen

    public Animator transition; 
    // Henter animasjonen

    public void IWasClicked()
    {
        Debug.Log("Clicked!");
        other.MethodFromOpenMainMenu();
        // LoadNextLevel();
    }
    //Kaller på denne funksjonen på selve knappen

    // public void LoadNextLevel()
    // {
    //     StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    // }
    // //Funksjon for overgangen mellom scener

    // IEnumerator LoadLevel(int levelIndex)
    // {
    //     transition.SetTrigger("Start");

    //     yield return new WaitForSeconds(1);

    //     SceneManager.LoadScene(levelIndex);
    // }

}
