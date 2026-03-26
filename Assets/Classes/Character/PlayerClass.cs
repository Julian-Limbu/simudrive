using UnityEngine;

public class PlayerClass : CharacterClass
{
    void Awake() // To make player persist
    {
        DontDestroyOnLoad(gameObject);
    }

    public void InputHandler()
    {
        // PlayerGUI Methods:
        
        if (Input.GetKey(KeyCode.Escape)) // PlayerMenuGUI()
        {
            PlayerGUI.Instance.PlayerMenuGUI();
        }


        if (Input.GetKey(KeyCode.M)) // PlayerMapGUI()
        {
            PlayerGUI.Instance.PlayerMapGUI();
        }


        if (Input.GetKey(KeyCode.U)) // PlayerUtilitiesGUI()
        {
            PlayerGUI.Instance.PlayerUtilitiesGUI();
        }





        // VehicleClass Methods:
        // .GetKeyDown - for single-action triggers
        // .GetKey - for continuous actions
        // .GetKeyUp - for actions up release


        /*if (Input.GetKeyDown(KeyCode.Q)) // GearShiftLeft()
        {
            VehicleClass.Instance.GearShiftLeft();
        }


        if (Input.GetKeyDown(KeyCode.E)) // GearShiftRight()
        {
            VehicleClass.Instance.GearShiftRight();
        }


        if (Input.GetKey(KeyCode.A)) // SteerLeft()
        {
            VehicleClass.Instance.SteerLeft();
        }


        if (Input.GetKey(KeyCode.D)) // SteerRight()
        {
            VehicleClass.Instance.SteerRight();
        }


        if (Input.GetKey(KeyCode.W)) // Accelerate()
        {
            VehicleClass.Instance.Accelerate();
        }


        if (Input.GetKey(KeyCode.S)) // Brake()
        {
            VehicleClass.Instance.Brake();
        }


        if (Input.GetKeyDown(KeyCode.V)) // EngineSwitch()
        {
            VehicleClass.Instance.EngineSwitch();
        }


        if (Input.GetKeyDown(KeyCode.L)) // LightsState()
        {
            VehicleClass.Instance.Light();
        }*/
    }

    
    public void CameraHandler()
    {
        
    }
}
