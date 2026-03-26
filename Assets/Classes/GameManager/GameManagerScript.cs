using UnityEngine; // A library, you import them, e.g. 'Systems'
using UnityEngine.SceneManagement; // The C# namespace in Unity used for controlling and managing game scenes

public class GameManagerScript : MonoBehaviour 
{
    // Other Attributes
    public static GameManagerScript Instance; // Declares 'Instance' to hold a reference to an object with "GameManagerScript" 

    // Built-in methods

    void Awake()
    {
        if (Instance == null) // Checking if the object already exists
        {
            Instance = this; // 'this' is the current object that the script belongs too
            DontDestroyOnLoad(gameObject); // Allows for it to persist through scenes
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    // SceneManager - Attributes
    public Scenario scenarioChoice;
    public Vehicle vehicleChoice;

    // SceneManager - Methods
    
    public void SwitchScene() // Switch scenes
    {
        if (scenarioChoice == Scenario.Learning)
        {
            SceneManager.LoadScene(1);
        }
        else if (scenarioChoice == Scenario.Racing)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }





    // Spawn & Set Vehicle
    public CharacterClass player;
    public GameObject carPrefab; // Currently only vehicle made so this is only to be used.


    public void SetCharacter() // To set 'currentVehicle' in "CharacterClass" as 'vehicleChoice' in "GameManagerScript", then assign it to the player
    {
        Debug.Log("SetCharacter() called");

        if (player != null) return;
        GameObject vehicleObj = null; // 'null' gives variable value to prevent compile errors.

        if (vehicleChoice == Vehicle.Car)
        {
            vehicleObj = Instantiate(carPrefab); // Built-in method to instantiate the vehicle, i.e. Car
        }

        if (vehicleChoice == Vehicle.Motorcycle)
        {
            Debug.Log("No prefab for motorcycle yet...");
            return;
        }

        if (vehicleObj != null)
        {
            player.currentVehicle = vehicleObj.GetComponent<VehicleClass>();
        }
    }



    


}