using System.Reflection;
using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    public sealed class ExceptionHelper
    {
        private static readonly Type GENERIC_EXCEPTION_TYPE = typeof(ErrorCodeExceptionBase<>);

        /// <summary>
        /// Gets exception type based on exception code.
        /// </summary>
        /// <param name="exceptionCode">Exception code.</param>
        /// <returns>Type, null if exception is not mapped to the error code.</returns>
        /// <remarks>
        /// Exception error codes defined with <see cref="ExceptionFilterCodeAttribute"/> on the exception classes.
        /// </remarks>
        public static Type? GetType(int exceptionCode)
        {
            var exceptionTypes = AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(assembly =>
               {
                   try
                   {
                       return assembly.GetTypes()
                       .Where(t => t.IsAbstract == false && IsErrorCodeExceptionType(t));
                   }
                   catch (ReflectionTypeLoadException)
                   {
                       //catch type load exceptions
                       //this will happen if one of the types in assembly cant be loaded

                       return Enumerable.Empty<Type>();
                   }
               }).ToArray();

            return exceptionTypes.Where(exceptionType => (int?)exceptionType.GetCustomAttribute<ExceptionFilterCodeAttribute>()?.ErrorCode == exceptionCode)
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets exception code from exception type.
        /// </summary>
        /// <param name="exceptionType">Exception type.</param>
        /// <returns>Exception code, null if type does not have <see cref="ExceptionFilterCodeAttribute"/> applied to it.</returns>
        public static ExceptionCode? GetExceptionCode(Type exceptionType) 
        {
            var codeAttribute =  exceptionType.GetCustomAttribute<ExceptionFilterCodeAttribute>();
            return codeAttribute?.ErrorCode;
        }

        /// <summary>
        /// Gets error code type.
        /// </summary>
        /// <param name="exceptionType">Exception type.</param>
        /// <returns>Error code object (enum) <see cref="Type"/> , null if exception is not base of <see cref="ErrorCodeExceptionBase{TErrorCode}"/>.</returns>
        public static Type? ErrorCodeType(Type exceptionType) 
        {
            //in order to obtain error code type we must ensure that exception is of ErrorCodeExceptionBase
            if (!IsErrorCodeExceptionType(exceptionType))
                return null;

            return exceptionType.GetRuntimeProperty(nameof(ErrorCodeExceptionBase<Enum>.ErrorCode)).PropertyType;
        }

        /// <summary>
        /// Checks if type is of <see cref="ErrorCodeExceptionBase{TErrorCode}"/>.
        /// </summary>
        /// <param name="exceptionType">Type to check.</param>
        /// <returns>True or false.</returns>
        public static bool IsErrorCodeExceptionType(Type exceptionType) 
        {
            return IsSubclassOfRawGeneric(GENERIC_EXCEPTION_TYPE, exceptionType);
        }

        static bool IsSubclassOfRawGeneric(Type generic, Type? toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }
    }
}
