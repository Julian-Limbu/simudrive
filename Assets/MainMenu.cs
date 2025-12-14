using UnityEngine;
using UnityEngine.SceneManagement; // The C# namespace in Unity used for controlling and managing game scenes

public class MainMenu : MonoBehaviour
{
    /*
    Scenarios()

    Settings()

    Help()

    */

    public void Exit()
    {
        Debug.Log("Quit: Success!");
        Application.Quit(); // Exits application
    }
}
