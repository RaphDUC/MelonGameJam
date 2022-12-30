using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class SettingsScript : MonoBehaviour
{
    [SerializeField]
    private Dropdown resolutionDropdown;

    [SerializeField]
    private Dropdown qualityDropdown;

    [SerializeField]
    private Slider volumeSlider;

    [SerializeField]
    private Toggle fullscreenToggle;

    float currentVolume;
    Resolution[] resolutions;

    // Start is called before the first frame update
    void Start()
    {

        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " +
                     resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width
                  && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }


        resolutionDropdown.AddOptions(options);
        qualityDropdown.ClearOptions();
        qualityDropdown.AddOptions(new List<string>(QualitySettings.names));
        
        resolutionDropdown.RefreshShownValue();
        qualityDropdown.RefreshShownValue();

        LoadSettings(currentResolutionIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,
                  resolution.height, Screen.fullScreen);
        PlayerPrefs.SetInt("ResolutionPreference", resolutionIndex);
    }

    public void SetVolume(float volume)
    {
        currentVolume = volume;
        PlayerPrefs.SetFloat("Volume", currentVolume);
        AudioListener.volume = volume;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("Fullscreen", isFullscreen ? 1 : 0);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("QualityLevel", qualityIndex);
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("ResolutionPreference"))
            resolutionDropdown.value =
                         PlayerPrefs.GetInt("ResolutionPreference");
        else
            resolutionDropdown.value = currentResolutionIndex;

        if (PlayerPrefs.HasKey("Volume"))
            volumeSlider.value =
                        PlayerPrefs.GetFloat("Volume", 1);
        else
            volumeSlider.value =
                        PlayerPrefs.GetFloat("Volume",1) ;

        if (PlayerPrefs.HasKey("QualityLevel"))
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityLevel"));


        SetVolume(volumeSlider.value);
        
        qualityDropdown.value = QualitySettings.GetQualityLevel();

        Screen.fullScreen = PlayerPrefs.GetInt("Fullscreen",1)==1;
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public static float ConvertToDecibels(float percentage)
    {
        return (1 - percentage) * (-80);
    }
}
