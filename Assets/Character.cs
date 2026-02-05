using UnityEngine;

public enum Control
{
    
}

public class PlayerClass : MonoBehaviour
{
    
    public static PlayerClass instance; // This is the player.

    void Awake()
    {
        // Check if there is already a player.
        if (instance != null)
        {
            // if not not this one then delete this
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            // Set this as the player
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
