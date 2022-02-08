namespace Nephasto.DesignPatterns
{
  /// <summary>
  /// Singleton that calls its constructor on the first instance request.
  /// </summary>
  public class LazySingleton
  {
    // Static variable that references the only instance of Singleton.
    private static LazySingleton instance = null;

    /// <summary>
    /// Requests the single instance.
    /// </summary>
    /// <value>The instance.</value>
    public static LazySingleton Instance
    {
      get
      {
        // If it does not exist, it is created.
        if (instance == null)
          instance = new LazySingleton();

        return instance;
      }
    }

    // Private constructor so no one external to this class will be able to create one, and without parameters.
    private LazySingleton() { }
  }
}
