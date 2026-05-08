using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

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

    [Header("Close Buttons")]
    [SerializeField] private Button _btnCloseKeyBoard;
    [SerializeField] private Button _btnCloseOption;


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

        // 설명창 닫기 위한 추가부분 : X버튼 클릭시 설명창+옵션창 닫기
        if (_btnCloseKeyBoard != null) _btnCloseKeyBoard.onClick.AddListener(OnCloseKeyBoardClicked);
        if (_btnCloseOption != null) _btnCloseOption.onClick.AddListener(OnCloseOptionClicked);
    }

    private void OnGameStartClicked()
    {
        Debug.Log("GameStart 클릭됨 -> TitleScene으로 이동");
        
        // 💡 이 부분을 다시 SceneLoadManager를 호출하도록 수정!
        SceneLoadManager.Instance.LoadScene(SceneNames.Title);
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

    // 추가:창 닫기
    private void OnCloseKeyBoardClicked()
    {
        _keyBoardHelpPanel.SetActive(false); // 패널 비활성화
    }

    private void OnCloseOptionClicked()
    {
        _optionHelpPanel.SetActive(false); // 패널 비활성화
    }
}