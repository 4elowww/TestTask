using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Mesh[] _playerStates;
    [SerializeField] private Image HealthBarImg;
    [SerializeField] private TMP_Text MoneyText;
    [SerializeField]private MeshFilter _player;
    private void Start()
    {
        GlobalData.Health = 20;
    }
    private Color ColorBar() 
    {
        Debug.Log(_playerStates[0]);
        switch (GlobalData.Health)
        {
            case  100: 
                _player.mesh = _playerStates[4];
                return Color.blue;
            case >= 80:
                _player.mesh = _playerStates[3];
                return Color.cyan;
            case >= 60:
                _player.mesh = _playerStates[2];
                return Color.green;
            case >= 40:
                _player.mesh = _playerStates[1];
                return Color.magenta;
            case >= 20:
                _player.mesh = _playerStates[0];
                return Color.red;
            default: return Color.red;
        }
        
    }
    public void PickUpAny(int value)
    {
        GlobalData.Health += value;
        HealthBarImg.fillAmount = GlobalData.Health / 100;
        HealthBarImg.color = ColorBar();
        MoneyText.text = GlobalData.Money.ToString();
    }
}
