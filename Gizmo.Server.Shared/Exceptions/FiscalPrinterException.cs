﻿using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Fiscal printer exception exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.FiscalPrinter)]
    public class FiscalPrinterException : ErrorCodeExceptionBase<FiscalPrinterExceptionErrorCode>
    {
        #region CONSTRUCTOR

        public FiscalPrinterException(string message, FiscalPrinterExceptionErrorCode errorCode, int? pritnerOrDrieverErrorCode) : base(message, errorCode)
        {
            PrinterOrDriverErrorCode = pritnerOrDrieverErrorCode;
        }

        public FiscalPrinterException(string message, FiscalPrinterExceptionErrorCode errorCode) : base(message, errorCode)
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public FiscalPrinterException(FiscalPrinterExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected FiscalPrinterException(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                PrinterOrDriverErrorCode = (int?)info.GetValue(nameof(PrinterOrDriverErrorCode), typeof(int?));
            }
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets optional printer or driver error code.
        /// </summary>
        public int? PrinterOrDriverErrorCode
        {
            get; set;
        }

        #endregion

        #region OVERRIDES

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue(nameof(PrinterOrDriverErrorCode), PrinterOrDriverErrorCode);
            }
        }

        #endregion
    }
}
