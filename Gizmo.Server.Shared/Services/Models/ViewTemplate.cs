namespace Gizmo.Server.Services
{
    /// <summary>
    /// CSHTML View template model.
    /// </summary>
    public sealed class ViewTemplate
    {
        #region CONSTRUCTOR
        public ViewTemplate(string viewName, bool isEmbeded)
        {
            _viewName = viewName;
            _isEmbeded = isEmbeded;
        }
        #endregion

        #region FIELDS
        private readonly string _viewName;
        private readonly bool _isEmbeded;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Razor engine compatible view name.
        /// </summary>
        public string ViewName => _viewName;

        /// <summary>
        /// Gets if view represents an embeded view template.
        /// </summary>
        public bool IsEmbeded => _isEmbeded;

        #endregion
    }
}
