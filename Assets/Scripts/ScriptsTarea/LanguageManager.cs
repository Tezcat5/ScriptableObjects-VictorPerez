using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public LanguageData dutch;
    public LanguageData polish;
    public LanguageData spanish;

    public GameObject mainPanel;
    public GameObject playerPanel;
    public Text playerDescriptionText;
    public Image playerImage;

    public Sprite player1Sprite;
    public Sprite player2Sprite;
    public Sprite player3Sprite;
    public Sprite player4Sprite;

    private LanguageData currentLanguage;
    private int currentPlayerIndex = 1;

    void Start()
    {
        SetLanguage(spanish);

        playerPanel.SetActive(false);
    }

    public void SetLanguage(LanguageData language)
    {
        currentLanguage = language;

        UpdatePlayerDescription(currentPlayerIndex);
    }

    private void UpdatePlayerDescription(int playerIndex)
    {

        switch (playerIndex)
        {
            case 1:
                playerDescriptionText.text = currentLanguage.player1Description;
                break;
            case 2:
                playerDescriptionText.text = currentLanguage.player2Description;
                break;
            case 3:
                playerDescriptionText.text = currentLanguage.player3Description;
                break;
            case 4:
                playerDescriptionText.text = currentLanguage.player4Description;
                break;
        }
    }

    public void ShowPlayerInfo(int playerIndex)
    {
        mainPanel.SetActive(false);
        playerPanel.SetActive(true);

        currentPlayerIndex = playerIndex;

        switch (playerIndex)
        {
            case 1:
                playerDescriptionText.text = currentLanguage.player1Description;
                playerImage.sprite = player1Sprite;
                break;
            case 2:
                playerDescriptionText.text = currentLanguage.player2Description;
                playerImage.sprite = player2Sprite;
                break;
            case 3:
                playerDescriptionText.text = currentLanguage.player3Description;
                playerImage.sprite = player3Sprite;
                break;
            case 4:
                playerDescriptionText.text = currentLanguage.player4Description;
                playerImage.sprite = player4Sprite;
                break;
        }
    }

    public void HidePlayerInfo()
    {
        mainPanel.SetActive(true);
        playerPanel.SetActive(false);
    }
}