using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private Text _textCoin;
    private int _quantityCoin;

    public void AddCoins(int number)
    {
        _quantityCoin += number;
        _textCoin.text = _quantityCoin.ToString();
    }
}
