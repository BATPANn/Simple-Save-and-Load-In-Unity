using UnityEngine;
using UnityEngine.UI;

public class SaveYoutube : MonoBehaviour
{


    public InputField LevelIF;

    public InputField VolumeIF;

    public InputField NameIF;

    public Toggle HaveFlashLight;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveAll()
    {


        // level

        int levelint = int.Parse(LevelIF.text);

        PlayerPrefs.SetInt("Level", levelint);

        // level


        // volume

        float volumeFloat = float.Parse(VolumeIF.text);

        PlayerPrefs.SetFloat("Volume", volumeFloat);


        // volume

        // name

        string NameString = NameIF.text;

        PlayerPrefs.SetString("Name", NameString);


        // name

        // flashlight

        if(HaveFlashLight.isOn == true)
        {

            PlayerPrefs.SetInt("HaveFlashLight", 1);



        }
        else if(HaveFlashLight.isOn == false)
        {

            PlayerPrefs.SetInt("HaveFlashLight", 0);


        }

        // flashlight



    }



}
