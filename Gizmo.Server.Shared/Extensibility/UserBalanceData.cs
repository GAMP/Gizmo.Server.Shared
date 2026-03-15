namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents a user's calculated balance state.
    /// </summary>
    /// <remarks>
    /// This is a mutable data object that flows through the balance calculation pipeline.
    /// The host creates instances during balance calculation, and
    /// <see cref="IUserBalanceHandler.HandlePostBalanceAsync"/> implementations may modify
    /// property values to adjust the final balances.
    /// <para>
    /// Computed properties (<see cref="Balance"/>, <see cref="TimeProductBalance"/>,
    /// <see cref="UsageBalance"/>, <see cref="TotalOutstanding"/>) are derived from the
    /// mutable properties and reflect changes automatically.
    /// </para>
    /// </remarks>
    public sealed class UserBalanceData
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the total user deposits.
        /// </summary>
        public decimal Deposits { get; set; }

        /// <summary>
        /// Gets or sets the total user points.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Gets or sets the outstanding amount on invoices.
        /// </summary>
        public decimal OnInvoices { get; set; }

        /// <summary>
        /// Gets or sets the outstanding amount on invoiced usage sessions.
        /// </summary>
        public decimal OnInvoicedUsage { get; set; }

        /// <summary>
        /// Gets or sets the outstanding amount on current active usage.
        /// </summary>
        public decimal OnActiveUsage { get; set; }

        /// <summary>
        /// Gets or sets the total time from time product purchases (in seconds).
        /// </summary>
        public double TimeProduct { get; set; }

        /// <summary>
        /// Gets or sets the total time from fixed time purchases (in seconds).
        /// </summary>
        public double TimeFixed { get; set; }

        /// <summary>
        /// Gets or sets the total available time based on deposits (in seconds).
        /// A <see langword="null"/> value indicates unlimited time.
        /// </summary>
        public double? AvailableTime { get; set; }

        /// <summary>
        /// Gets or sets the total available time including credit limit (in seconds).
        /// A <see langword="null"/> value indicates unlimited time.
        /// </summary>
        public double? AvailableCreditedTime { get; set; }

        /// <summary>
        /// Gets the available balance (deposits minus all outstanding amounts).
        /// </summary>
        public decimal Balance => Deposits - OnInvoicedUsage - OnActiveUsage - OnInvoices;

        /// <summary>
        /// Gets the total time product balance (time product + fixed time).
        /// </summary>
        public double TimeProductBalance => TimeProduct + TimeFixed;

        /// <summary>
        /// Gets the total usage balance (invoiced + active usage).
        /// </summary>
        public decimal UsageBalance => OnInvoicedUsage + OnActiveUsage;

        /// <summary>
        /// Gets the total outstanding amount (invoices + active usage).
        /// </summary>
        public decimal TotalOutstanding => OnInvoices + OnActiveUsage;
    }
}
