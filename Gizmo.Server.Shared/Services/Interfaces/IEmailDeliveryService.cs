namespace Gizmo.Server.Services
{
    /// <summary>
    /// Email delivery service.
    /// </summary>
    public interface IEmailDeliveryService
    {
        /// <summary>
        /// Gets if service can currently dispatch messages.
        /// </summary>
        bool CanDispatch { get; }

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="html">Html body to include in mail.</param>
        /// <param name="mailSender">Address of the sender.</param>
        /// <param name="senderName">Name of the sender.</param>
        /// <param name="recipient">Address of the recipient.</param>
        /// <param name="recipientName">Name of the recipient.</param>
        /// <param name="subject">Subject of the mail.</param>
        /// <param name="attachments">List of MailAttachment to attach to mail.</param>
        /// <param name="cancellationToken">CancellationToken</param>
        Task SendMailAsync(string html, string mailSender, string senderName, string recipient, string recipientName, string subject, List<MailAttachement> attachments, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="html">Html body to include in mail.</param>
        /// <param name="recipient">Address of the recipient.</param>
        /// <param name="recipientName">Name of the recipient.</param>
        /// <param name="subject">Subject of the mail.</param>
        /// <param name="attachments">List of MailAttachment to attach to mail.</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <remarks>
        /// The sender and reply-to address will be supplied automatically based on current business configuration.
        /// </remarks>
        Task SendMailAsync(string html, string recipient, string recipientName, string subject, List<MailAttachement> attachments, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a mail described by the specified context.
        /// </summary>
        /// <param name="context">The context containing recipient and message information.</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <remarks>
        /// The sender and reply-to address will be supplied automatically based on current business configuration.
        /// </remarks>
        Task SendMailAsync(Gizmo.Server.Extensibility.SendEmailContext context, CancellationToken cancellationToken = default);
    }
}
