using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGameobjects : MonoBehaviour, GlobalData
{
    [SerializeField] protected int GetItem; // влияние на health bar при подборе предмета. у каждого предмета настраивается в префабе
    [SerializeField] protected Image  HealthBarImg;
    [SerializeField]protected TMP_Text MoneyText;
    [Header("CS")]
    [SerializeField] private HealthBar _csHealthBar;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            GlobalData.Money += GetItem;
            if (GlobalData.Money < 0)
                GlobalData.Money = 0;
            _csHealthBar.PickUpAny(GetItem);
            Destroy(gameObject);
        }
    }
}
