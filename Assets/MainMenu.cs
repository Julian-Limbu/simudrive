using UnityEngine;
using UnityEngine.SceneManagement; // The C# namespace in Unity used for controlling and managing game scenes

public class MainMenu : MonoBehaviour
{
    /*
    public void Scenarios() 
    {
        string[] scenarioOptions = {"Learning", "Racing", "Free Roam"}; // Selections align with these elements - contribute to the overall option; applies to the array 'vehicle' too.
        string[] vehicleOptions = {"Car", "Motorcycle"};

        string[] options = {"",""};
        int scenarioSelect = 0; // Caused by the action of pressing a button; applies to the variable 'vehicleSelect' too.
        int vehicleSelect = 0;

        // Scenarios:
        if (scenarioSelect == 1)
        {
            options[0] = "Learning";
        }
        else if (scenarioSelect == 2)
        {
            options[0] = "Racing";
        }
        else
        {
            options[0] = "Free Roam";
        }

        // Vehicles:
        if (vehicleSelect == 1)
        {
            options[1] = "Car";
        }
        else 
        {
            options[2] = "Motorcycle";
        }
        
    }
        
    }

    Settings()

    Help()

    broiiii

    */

    public void Exit()
    {
        Debug.Log("Quit: Success!");
        Application.Quit(); // Exits application
    }
}
