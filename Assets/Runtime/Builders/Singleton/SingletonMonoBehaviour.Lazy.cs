using UnityEngine;

namespace Nephasto.DesignPatterns
{
  /// <summary>
  /// Singleton that calls its constructor on the first instance request.
  /// </summary>
  public class SingletonMonoBehaviour : MonoBehaviour
  {
    // Static variable that references the only instance of Singleton.
    private static SingletonMonoBehaviour instance;

    /// <summary>
    /// Requests the single instance.
    /// </summary>
    public static SingletonMonoBehaviour Instance
    {
      get
      {
        if (instance == null)
        {
          // We look for all instances.
          SingletonMonoBehaviour[] singletons = GameObject.FindObjectsOfType<SingletonMonoBehaviour>();
          if (singletons.Length == 0)
          {
            // It does not exist yet, the value is created and assigned.
            GameObject gameObject = new GameObject(nameof(SingletonMonoBehaviour));
            instance = gameObject.AddComponent<SingletonMonoBehaviour>();
          }
          else
          {
            // Already exists, we assign the first one.
            instance = singletons[0];

            // There should not be more than one.
            if (singletons.Length > 1)
              Debug.LogError($"Found {singletons.Length} instances of '{nameof(SingletonMonoBehaviour)}' in scene '{singletons[0].gameObject.scene.name}'.");
          }
        }

        return instance;
      }
    }

    // This function is called when the MonoBehaviour will be destroyed.
    private void OnDestroy()
    {
      instance = null;
    }
  }
}
