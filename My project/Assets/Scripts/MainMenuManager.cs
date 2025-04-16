using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject settingsPanel;
    public GameObject howToPlayPanel;
    public GameObject savesPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Start()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);
        if (howToPlayPanel != null)
            howToPlayPanel.SetActive(false);
        if (savesPanel != null)
            savesPanel.SetActive(false);
    }

    public void OpenSettings() => settingsPanel.SetActive(true);
    public void CloseSettings() => settingsPanel.SetActive(false);

    public void OpenSaves() => savesPanel.SetActive(true);
    public void CloseSaves() => savesPanel.SetActive(false);

    public void OpenHowToPlay() => howToPlayPanel.SetActive(true);
    public void CloseHowToPlay() => howToPlayPanel.SetActive(false);

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
