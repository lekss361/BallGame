using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _authors;
    private const string SampleScene = "SampleScene";
    private const string IsOpen = "IsOpen";

    public void Play()
    {
        SceneManager.LoadScene(SampleScene);
    }

    public void ToggleAutors()
    {
        _authors.SetBool(IsOpen, !_authors.GetBool(IsOpen));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
