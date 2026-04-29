using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private GameObject _keyBoardHelpPanel;
    [SerializeField] private GameObject _optionHelpPanel;

    [Header("UI Buttons")]
    [SerializeField] private Button _btnGameStart;
    [SerializeField] private Button _btnGameEnd;
    [SerializeField] private Button _btnKey;
    [SerializeField] private Button _btnOption;

    private void Start()
    {
        InitializeUI();
    }

    private void InitializeUI()
    {
        // 시작 시 설명창+옵션창 비활성화
        if (_keyBoardHelpPanel != null) _keyBoardHelpPanel.SetActive(false);
        if (_optionHelpPanel != null) _optionHelpPanel.SetActive(false);

        // 각 버튼 클릭시 그에 맞게 연결
        if (_btnGameStart != null) _btnGameStart.onClick.AddListener(OnGameStartClicked);
        if (_btnGameEnd != null) _btnGameEnd.onClick.AddListener(OnGameEndClicked);
        if (_btnKey != null) _btnKey.onClick.AddListener(OnKeyClicked);
        if (_btnOption != null) _btnOption.onClick.AddListener(OnOptionClicked);
    }

    private void OnGameStartClicked()
    {
        Debug.Log("로딩 씬으로 이동");
        // 일단 로딩 씬의 이름은 LoadingScene으로 대체함
        // 나중에 File -> Build Settings에 해당 씬이 등록할 것
        SceneManager.LoadScene("LoadingScene"); 
    }

    private void OnGameEndClicked()
    {
        Debug.Log("게임 종료");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void OnKeyClicked()
    {
        // KeyBoardHelp 패널 활성화, 다른 패널이 열려있다면 닫기
        _keyBoardHelpPanel.SetActive(true);
        _optionHelpPanel.SetActive(false);
    }

    private void OnOptionClicked()
    {
        // OptionHelp 패널 활성화, 다른 패널이 열려있다면 닫기
        _optionHelpPanel.SetActive(true);
        _keyBoardHelpPanel.SetActive(false);
    }
}