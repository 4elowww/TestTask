using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStates : MonoBehaviour, GlobalData
{
    [SerializeField] private Transform _player;
    public void Win(int CurrentLevel)
    {
        SceneManager.LoadScene(CurrentLevel + 1);
    }
    public void Lose(int CurrentLevel)
    {
        if (GlobalData.SpawnPoint != null)
            _player.position = GlobalData.SpawnPoint;
        else
            SceneManager.LoadScene(CurrentLevel);
    }
}
