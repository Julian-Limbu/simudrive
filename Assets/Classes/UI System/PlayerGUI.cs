using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    public static PlayerGUI Instance;
    public bool menuGUIActive = false;
    public bool mapGUIActive = false;
    public bool utilitiesGUIActive = false;

    // Methods
    public void PlayerMenuGUI()
    {
        menuGUIActive = !menuGUIActive;
    }

    public void PlayerMapGUI()
    {
        mapGUIActive = !mapGUIActive;
    }

    public void PlayerUtilitiesGUI()
    {
        utilitiesGUIActive = !utilitiesGUIActive;
    }
}
