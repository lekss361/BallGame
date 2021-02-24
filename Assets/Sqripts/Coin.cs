using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private Text _coinsText;
    private int _coins;

    public void Add(int coins)
    {
        _coins += coins;
        _coinsText.text = _coins.ToString();
    }
}
