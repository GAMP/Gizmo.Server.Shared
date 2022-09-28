namespace Gizmo.Server.Services
{
    /// <summary>
    /// Mail Attachement.
    /// </summary>
    public sealed class MailAttachement
    {
        #region PROPERTIES
        
        /// <summary>
        /// Name of the attached file.
        /// </summary>
        public string FileName { get; init; } = string.Empty;

        /// <summary>
        /// Buffer of the attached file.
        /// </summary>
        public byte[] Data { get; set; } = Array.Empty<byte>();

        #endregion
    }
}