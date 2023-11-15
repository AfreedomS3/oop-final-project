using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI figureNameText;

    [SerializeField]
    private Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        var session = GameManager.Instance.sessionData;
        figureNameText.text = "Figure: " + session.figureName;

        backButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        GameManager.Instance.GameOver();
    }
}
