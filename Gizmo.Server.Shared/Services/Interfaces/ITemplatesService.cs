#nullable enable

namespace Gizmo.Server.Services
{
    /// <summary>
    /// Templates service.
    /// </summary>
    public interface ITemplatesService
    {
        #region FUNCTIONS
        
        /// <summary>
        /// Gets title template.
        /// </summary>
        /// <param name="titleTemplate">Title template type.</param>
        /// <returns>Title template.</returns>
        string GetTitleTemplate(TitleTemplate titleTemplate);

        /// <summary>
        /// Gets HTML rendered view template contents.
        /// </summary>
        /// <param name="template">Template type.</param>
        /// <param name="model">Template model.</param>
        /// <returns>Rendered HTML template string.</returns>
        Task<string> GetRenderedViewTemplateAsync(ViewTemplates template, object? model = default);

        /// <summary>
        /// Gets text template contents.
        /// </summary>
        /// <param name="template">Template type.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Text template contents.</returns>
        Task<string> GetTextTemplateAsync(TextTemplates template, CancellationToken cancellationToken = default); 

        #endregion
    }
}
