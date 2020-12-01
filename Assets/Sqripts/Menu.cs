using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _authorsAnimator;

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChangeAutorsState()
    {
        _authorsAnimator.SetBool("IsOpen", !_authorsAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
