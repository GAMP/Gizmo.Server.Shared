namespace Gizmo.Server.Services
{
    /// <summary>
    /// Email delivery service.
    /// </summary>
    public interface IEmailDeliveryService
    {
        #region PROPERTIES

        /// <summary>
        /// Gets if service can currently dispatch messages.
        /// </summary>
        bool CanDispatch { get; }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="html">Html body to include in mail.</param>
        /// <param name="mailSender">Address of the sender.</param>
        /// <param name="senderName">Name of the sender.</param>
        /// <param name="recepient">Address of the recipient.</param>
        /// <param name="recepientName">Name of the recipient.</param>
        /// <param name="subject">Subject of the mail.</param>
        /// <param name="attachements">List of MailAttachement to attach to mail.</param>
        /// <param name="ct">CancellationToken</param>
        Task SendMailAsync(string html, string mailSender, string senderName, string recepient, string recepientName, string subject, List<MailAttachement> attachements, CancellationToken ct = default);

        #endregion
    }
}
