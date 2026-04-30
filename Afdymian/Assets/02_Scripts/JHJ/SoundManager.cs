using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Mixer")]
    [SerializeField] private AudioMixer _mainAudioMixer;

    [Header("UI Sliders")]
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _bgmSlider;
    [SerializeField] private Slider _seSlider;

    private void Start()
    {
        InitializeSliders();
    }

    private void InitializeSliders()
    {
        // 코드에서 블륨 슬라이더 직접 연결함.
        if (_masterSlider != null)
        {
            _masterSlider.onValueChanged.AddListener(SetMasterVolume);
        }

        if (_bgmSlider != null)
        {
            _bgmSlider.onValueChanged.AddListener(SetBGMVolume);
        }

        if (_seSlider != null)
        {
            _seSlider.onValueChanged.AddListener(SetSEVolume);
        }
    }

    // 오디오 믹서 블륨 조절하기(원하시면 따로 수정해도 괜찮아요.)
    private void SetMasterVolume(float volume)
    {
        _mainAudioMixer.SetFloat("MasterVol", Mathf.Log10(volume) * 20);
    }

    private void SetBGMVolume(float volume)
    {
        _mainAudioMixer.SetFloat("BGMVol", Mathf.Log10(volume) * 20);
    }

    private void SetSEVolume(float volume)
    {
        _mainAudioMixer.SetFloat("SEVol", Mathf.Log10(volume) * 20);
    }
}