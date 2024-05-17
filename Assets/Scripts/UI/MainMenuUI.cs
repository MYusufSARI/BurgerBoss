using UnityEngine.UI;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void OnEnable()
    {
        playButton.onClick.AddListener(() =>
        {
            LoadGameScene();
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

    private void OnDisable()
    {
        playButton.onClick.RemoveListener(LoadGameScene);

        quitButton.onClick.RemoveListener(Application.Quit);
    }

    private void LoadGameScene()
    {
        // Load the game scene
        Loader.Load(Loader.Scene.GameScene);
    }
}
