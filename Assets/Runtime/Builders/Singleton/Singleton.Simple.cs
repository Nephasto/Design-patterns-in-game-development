namespace Nephasto.DesignPatterns
{
  /// <summary>
  /// Singleton with static constructor.
  /// </summary>
  public class Singleton
  {
    // It is executed once per app-domain, the CLR ensures that it is thread-safe.
    private static readonly Singleton instance = new Singleton();

    /// <summary>
    /// Requests the single instance.
    /// </summary>
    public static Singleton Instance => instance;

    // Explicit static constructor to tell the compiler not to mark the type as beforefieldinit.
    static Singleton() { }

    // Private constructor so no one external to this class will be able to create one, and without parameters.
    private Singleton() { }
  }
}
