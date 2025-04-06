using UnityEngine;
using UnityEngine.UI;

public class LoadYoutube : MonoBehaviour
{


    public Text LevelText;

    public Text VolumeText;

    public Text NameText;

    public Text HaveFlashLightText;



    void Start()
    {

        // Level

        LevelText.text = "Level : " + PlayerPrefs.GetInt("Level");

        // Level

        // Volume

        VolumeText.text = "Volume : " + PlayerPrefs.GetFloat("Volume");

        // Volume

        // Name

        NameText.text = "Your name is : " + PlayerPrefs.GetString("Name");

        // Name

        // haveflashlight

        if(PlayerPrefs.GetInt("HaveFlashLight") == 1)
        {


            HaveFlashLightText.text = "Have FlashLight : Yes";


        }
        else if(PlayerPrefs.GetInt("HaveFlashLight") == 0)
        {


            HaveFlashLightText.text = "Have FlashLight : NO";

        }


        // haveflashlight



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
