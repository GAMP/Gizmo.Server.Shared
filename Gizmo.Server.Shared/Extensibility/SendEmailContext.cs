using Gizmo.Server.Services;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for sending an email message composed by the system.
    /// </summary>
    public sealed class SendEmailContext
    {
        /// <summary>
        /// Gets the recipient email address.
        /// </summary>
        public required string Recipient { get; init; }

        /// <summary>
        /// Gets the recipient display name. When not set the recipient address is used.
        /// </summary>
        public string? RecipientName { get; init; }

        /// <summary>
        /// Gets the message subject.
        /// </summary>
        public required string Subject { get; init; }

        /// <summary>
        /// Gets the message html body.
        /// </summary>
        public required string HtmlBody { get; init; }

        /// <summary>
        /// Gets the optional plain text alternative of the message body.
        /// </summary>
        /// <remarks>
        /// When set, transports should deliver the message as <c>multipart/alternative</c> with both
        /// renderings so the receiving client can pick the richest one it supports.
        /// </remarks>
        public string? TextBody { get; init; }

        /// <summary>
        /// Gets the optional message attachments.
        /// </summary>
        public IReadOnlyList<MailAttachement>? Attachments { get; init; }
    }
}
