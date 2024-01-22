using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Gun Gun;

    void Update()
    {
        int childCount = gameObject.transform.childCount;
        if(childCount == 0)
        {
            // Debug.Log("All enemies killed!");
            nextlevel();
        }
        if(Gun.count == 0 && childCount != 0)
        {
            // Debug.Log("Game Over!");
            GameOver();
        }
    }
    void Start()
    {
        // Ensure the canvas is initially inactive
        gameOverCanvas.SetActive(false);
    }

    public void GameOver()
    {
        // Show the game over canvas
        gameOverCanvas.SetActive(true);
    }

    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}