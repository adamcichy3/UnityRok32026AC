using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumesettings : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    public AudioMixer mainmixer;

  
    

    public void setmusicVolume()
    {
        float volume = musicSlider.value;
        mainmixer.SetFloat("Musicvolume", Mathf.Log10(volume)*20);
    }



    public void setsfxVolume()
    {
        float volume = sfxSlider.value;
        mainmixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
    }
}
