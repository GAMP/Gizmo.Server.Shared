﻿namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment provider error codes.
    /// </summary>
    public enum ProviderExceptionErrorCode
    {
        /// <summary>
        /// Payment provider not found.
        /// </summary>
        NotFound = 0,
        /// <summary>
        /// Payment provider does not have an option type associated with it.
        /// </summary>
        NoOptions = 1,
    }
}
