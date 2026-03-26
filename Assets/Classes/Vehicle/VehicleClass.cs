using UnityEngine;

// Abstract base class for all vehicles
public abstract class VehicleClass : MonoBehaviour
{
    // Attributes
    public Gear currentGear;
    [SerializeField] protected string colour; // Vehicle's mass
    [SerializeField] protected float mass = 1000f; // Vehicle's mass
    [SerializeField] protected float speed = 10f; // Current speed
    [SerializeField] protected float maxSpeed = 10f; // Speed Limit of Vehicle
    [SerializeField] protected float acceleration; // Gradual rate to 'maxSpeed'
    
    public bool lightsOn = false; // Current state of vehicle lights
    public bool engineOn = false; // Current state of the engine
    
    // Methods
    public void GearShiftLeft()
    {
        ;
    }

    public void GearShiftRight()
    {
        ;
    }

    public void SteerLeft()
    {
        
    }

    public void SteerRight()
    {
        
    }

    public void Accelerate()
    {
        
    }

    public void Brake()
    {
        
    }

    public void EngineSwitch()
    {
        engineOn = !engineOn;
        Debug.Log("Engine On:");
    }

    public void Light()
    {
        lightsOn = !lightsOn;
        Debug.Log("Lights On: " + lightsOn);
    }
}