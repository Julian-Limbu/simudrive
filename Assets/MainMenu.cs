using UnityEngine;
using UnityEngine.SceneManagement; // The C# namespace in Unity used for controlling and managing game scenes

public class MainMenu : MonoBehaviour
{
    public Scenario scenarioChoice;
    public Vehicle vehicleChoice;

    public void Exit()
    {
        Debug.Log("Quit: Success!");
        Application.Quit(); // Exits application
    }
}

public enum Scenario // Choices of scenarios
{
    Learning,
    Racing,
    FreeRoam,
}

public enum Vehicle // Choices of vehicles
{
    Car,
    Motorycycle,
}