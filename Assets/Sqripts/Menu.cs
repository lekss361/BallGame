using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _authors;

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToggleAutorsState()
    {
        _authors.SetBool("IsOpen", !_authors.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
