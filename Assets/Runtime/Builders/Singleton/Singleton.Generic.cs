using System;

namespace Nephasto.DesignPatterns
{
  /// <summary>
  /// Singleton with static constructor.
  /// </summary>
  public class Singleton<T> where T : class, new()
  {
    /// <summary>
    /// Requests the single instance.
    /// </summary>
    public static T Instance => instance.Value;

    //
    private static readonly Lazy<T> instance = new Lazy<T>(() => new T());

    // Private constructor so no one external to this class will be able to create one, and without parameters.
    private Singleton() { }
  }
}
