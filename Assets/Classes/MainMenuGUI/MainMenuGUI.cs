using UnityEngine;

public class MainMenuGUI : MonoBehaviour
{
    // 1MainMenu - Methods
    public void Exit()
    {
        Debug.Log("Quit: Success!");
        Application.Quit(); // Exits application
    }




    // 2Scenarios & 3VehicleOptions - Attributes
    public Scenario scenarioChoice;
    public Vehicle vehicleChoice;

    // 2Scenarios & 3VehicleOptions - Methods
    public void SelectLearning()
    {
        scenarioChoice = Scenario.Learning;
        Debug.Log("Scenario: " + scenarioChoice);
    }

    public void SelectRacing()
    {
        scenarioChoice = Scenario.Racing;
        Debug.Log("Scenario: " + scenarioChoice);
    }

    public void SelectFreeRoam()
    {
        scenarioChoice = Scenario.FreeRoam;
        Debug.Log("Scenario: " + scenarioChoice);
    }

    public void SelectCar()
    {
        vehicleChoice = Vehicle.Car;
        Debug.Log("Vehicle: " + vehicleChoice);
    }

    public void SelectMotorcycle()
    {
        vehicleChoice = Vehicle.Motorcycle;
        Debug.Log("Vehicle: " + vehicleChoice);
    }

    public void SetStates()
    {
        // Send selected values to GameManager
        GameManagerScript.Instance.scenarioChoice = scenarioChoice;
        GameManagerScript.Instance.vehicleChoice = vehicleChoice;

        Debug.Log("Scenario, Vehicle: " + scenarioChoice + ", " + vehicleChoice);

        // Then load the correct scene
        GameManagerScript.Instance.SwitchScene();
    }





    // 2Settings - Attributes
    public bool lowDetailMode = false;
    public float audioVolume;


    // 2Settings - Methods
    public void ToggleLDM() // To enable/disable Low Detail Mode, to have proper functionality...
    {
        lowDetailMode = !lowDetailMode;
        Debug.Log(lowDetailMode);
    }

    public void ScrollAudioVolume(float value) // Stores value from slider into 'audioVolume'
    {
        audioVolume = Mathf.RoundToInt(value);
        Debug.Log("Volume: " + audioVolume);
    }
}

/*
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
*/
