using UnityEngine;

public class UI_Changer : MonoBehaviour
{
    public GameObject[] ListUI;
    public GameObject CurrentUI;
    [Header("CS")]
    [SerializeField] private PlayerMovement _csPlayerMovement;
    private void Start()
    {
        CurrentUI = ListUI[0];
    }
    public void MainMenuUI()
    {
        for(int i = 0; i < ListUI.Length; i++)
            ListUI[i].SetActive(false);
        ListUI[0].SetActive(true);
        CurrentUI = ListUI[0];

        _csPlayerMovement.PlayerStop();
    }
    public void InGameUI()
    {
        for (int i = 0; i < ListUI.Length; i++)
            ListUI[i].SetActive(false);
        ListUI[1].SetActive(true);
        CurrentUI = ListUI[1];

        _csPlayerMovement.PlayerRun();
    }
}
