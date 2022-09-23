namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment provider error codes.
    /// </summary>
    public enum ProviderExceptionErrorCode
    {
        /// <summary>
        /// Provider not found.
        /// </summary>
        NotFound = 0,
        /// <summary>
        /// Provider does not have an option type associated with it.
        /// </summary>
        NoOptions = 1,
        /// <summary>
        /// The type provided is invalid or cant be loaded.
        /// </summary>
        InvalidType=2,
    }
}
