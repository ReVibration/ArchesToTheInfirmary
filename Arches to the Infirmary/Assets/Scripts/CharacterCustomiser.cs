using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomiser : MonoBehaviour
{
    // INITIALISE the colour index
    int currentColourIndex = 0;
    // INITIALISE the list of materials that the player can be 
    [SerializeField] Material[] playerColours;
    // REFERENCE the ui elements to be changed 
    [SerializeField] Image currentColourImage;
    [SerializeField] Text currentColourText;


    private void Start()
    {
        //SET both of the UI elements to the correct colour using the index
        currentColourImage.color = playerColours[currentColourIndex].color;
        currentColourText.text = playerColours[currentColourIndex].name;
    }

    //NextColour: This method will cycle forward through the materails 
    public void NextColour()
    {
        // CHECK whether the index has exceeded the length of the list 
        if(currentColourIndex < playerColours.Length - 1)
        {
            // INCREASE the colour index
            currentColourIndex++;
            // SET the colour index in a project wide variable 
            PlayerPrefs.SetInt("CurrentColourIndex", currentColourIndex);
            // SET both of the UI elements to the correct colour using the index
            currentColourImage.color = playerColours[currentColourIndex].color;
            currentColourText.text = playerColours[currentColourIndex].name;
        }
    }

    //PreviousColour: This method will cycle forward through the materails
    public void PreviousColour()
    {
        // CHECK whether the index receded past 0 
        if (currentColourIndex > 0)
        {
            // DECREASE the colour index
            currentColourIndex--;
            // SET the colour index in a project wide variable
            PlayerPrefs.SetInt("CurrentColourIndex", currentColourIndex);
            // SET both of the UI elements to the correct colour using the index
            currentColourImage.color = playerColours[currentColourIndex].color;
            currentColourText.text = playerColours[currentColourIndex].name;
        }
    }
}
