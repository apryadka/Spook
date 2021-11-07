using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

}
