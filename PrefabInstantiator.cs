using UnityEngine;

public class PrefabInstantiator
{
        
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void InitializePrefabs()
    {
        GameObject[] prefabs = Resources.LoadAll<GameObject>("InitializePrefabs");
        foreach (GameObject prefab in prefabs)
        {
            Instantiate(prefab);
        }
    }

}