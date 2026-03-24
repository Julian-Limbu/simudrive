using UnityEngine;
using UnityEngine.SceneManagement; // The C# namespace in Unity used for controlling and managing game scenes

public class MainMenuGUI : MonoBehaviour
{
    // 2Scenarios - Attributes
    public Scenario scenarioChoice;
    public Vehicle vehicleChoice;

    // 2Settings - Attributes
    public bool lowDetailMode = false;





    // 1MainMenu - Methods
    public void Exit()
    {
        Debug.Log("Quit: Success!");
        Application.Quit(); // Exits application
    }





    // 2Scenarios - Methods
    public void AssignScenario(Scenario chosenScenario) // Assigns chosen scenario to scenarioChoice
    {
        scenarioChoice = chosenScenario;
        Debug.Log("Scenario: " + scenarioChoice);
    }

    public void AssignVehicle(Vehicle chosenVehicle) // Assigns chosen vehicle to vehicleChoice
    {
        vehicleChoice = chosenVehicle;
        Debug.Log("Vehicle: " + chosenVehicle);
    }





    // 2Settings - Methods
    public void ToggleLDM() // To have functionality in the future...
    {
        lowDetailMode = !lowDetailMode;
        Debug.Log(lowDetailMode);
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
