using UnityEngine;

public interface GlobalData 
{
    public static float Speed;
    [Range(0,100)]public static float Health;  
    public static float Money;
    public static Vector3 SpawnPoint;
    public static int CurrentLevel;
}
