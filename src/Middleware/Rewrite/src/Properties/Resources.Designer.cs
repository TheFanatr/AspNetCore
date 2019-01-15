// <auto-generated />
namespace Microsoft.AspNetCore.Rewrite
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Rewrite.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Error adding a mod_rewrite rule. The change environment flag is not supported.
        /// </summary>
        internal static string Error_ChangeEnvironmentNotSupported
        {
            get { return GetString("Error_ChangeEnvironmentNotSupported"); }
        }

        /// <summary>
        /// Error adding a mod_rewrite rule. The change environment flag is not supported.
        /// </summary>
        internal static string FormatError_ChangeEnvironmentNotSupported()
        {
            return GetString("Error_ChangeEnvironmentNotSupported");
        }

        /// <summary>
        /// Could not parse integer from value '{0}'.
        /// </summary>
        internal static string Error_CouldNotParseInteger
        {
            get { return GetString("Error_CouldNotParseInteger"); }
        }

        /// <summary>
        /// Could not parse integer from value '{0}'.
        /// </summary>
        internal static string FormatError_CouldNotParseInteger(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CouldNotParseInteger"), p0);
        }

        /// <summary>
        /// Index out of range for backreference: '{0}' at string index: '{1}'
        /// </summary>
        internal static string Error_InputParserIndexOutOfRange
        {
            get { return GetString("Error_InputParserIndexOutOfRange"); }
        }

        /// <summary>
        /// Index out of range for backreference: '{0}' at string index: '{1}'
        /// </summary>
        internal static string FormatError_InputParserIndexOutOfRange(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InputParserIndexOutOfRange"), p0, p1);
        }

        /// <summary>
        /// Cannot parse '{0}' to integer at string index: '{1}'
        /// </summary>
        internal static string Error_InputParserInvalidInteger
        {
            get { return GetString("Error_InputParserInvalidInteger"); }
        }

        /// <summary>
        /// Cannot parse '{0}' to integer at string index: '{1}'
        /// </summary>
        internal static string FormatError_InputParserInvalidInteger(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InputParserInvalidInteger"), p0, p1);
        }

        /// <summary>
        /// Missing close brace for parameter at string index: '{0}'
        /// </summary>
        internal static string Error_InputParserMissingCloseBrace
        {
            get { return GetString("Error_InputParserMissingCloseBrace"); }
        }

        /// <summary>
        /// Missing close brace for parameter at string index: '{0}'
        /// </summary>
        internal static string FormatError_InputParserMissingCloseBrace(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InputParserMissingCloseBrace"), p0);
        }

        /// <summary>
        /// Missing backreference for parameter at string index: '{0}'
        /// </summary>
        internal static string Error_InputParserNoBackreference
        {
            get { return GetString("Error_InputParserNoBackreference"); }
        }

        /// <summary>
        /// Missing backreference for parameter at string index: '{0}'
        /// </summary>
        internal static string FormatError_InputParserNoBackreference(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InputParserNoBackreference"), p0);
        }

        /// <summary>
        /// Unrecognized parameter type: '{0}', terminated at string index: '{1}'
        /// </summary>
        internal static string Error_InputParserUnrecognizedParameter
        {
            get { return GetString("Error_InputParserUnrecognizedParameter"); }
        }

        /// <summary>
        /// Unrecognized parameter type: '{0}', terminated at string index: '{1}'
        /// </summary>
        internal static string FormatError_InputParserUnrecognizedParameter(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InputParserUnrecognizedParameter"), p0, p1);
        }

        /// <summary>
        /// Syntax error for integers in comparison.
        /// </summary>
        internal static string Error_IntegerMatch_FormatExceptionMessage
        {
            get { return GetString("Error_IntegerMatch_FormatExceptionMessage"); }
        }

        /// <summary>
        /// Syntax error for integers in comparison.
        /// </summary>
        internal static string FormatError_IntegerMatch_FormatExceptionMessage()
        {
            return GetString("Error_IntegerMatch_FormatExceptionMessage");
        }

        /// <summary>
        /// Error parsing the mod_rewrite rule. The cookie flag (CO) has an incorrect format '{0}'.
        /// </summary>
        internal static string Error_InvalidChangeCookieFlag
        {
            get { return GetString("Error_InvalidChangeCookieFlag"); }
        }

        /// <summary>
        /// Error parsing the mod_rewrite rule. The cookie flag (CO) has an incorrect format '{0}'.
        /// </summary>
        internal static string FormatError_InvalidChangeCookieFlag(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InvalidChangeCookieFlag"), p0);
        }

        /// <summary>
        /// Could not parse the mod_rewrite file. Message: '{0}'.  Line number '{1}'.
        /// </summary>
        internal static string Error_ModRewriteParseError
        {
            get { return GetString("Error_ModRewriteParseError"); }
        }

        /// <summary>
        /// Could not parse the mod_rewrite file. Message: '{0}'.  Line number '{1}'.
        /// </summary>
        internal static string FormatError_ModRewriteParseError(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_ModRewriteParseError"), p0, p1);
        }

        /// <summary>
        /// Could not parse the mod_rewrite file.  Line number '{0}'.
        /// </summary>
        internal static string Error_ModRewriteGeneralParseError
        {
            get { return GetString("Error_ModRewriteGeneralParseError"); }
        }

        /// <summary>
        /// Could not parse the mod_rewrite file.  Line number '{0}'.
        /// </summary>
        internal static string FormatError_ModRewriteGeneralParseError(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_ModRewriteGeneralParseError"), p0);
        }

        /// <summary>
        /// Could not parse the UrlRewrite file. Message: '{0}'. Line number '{1}': '{2}'.
        /// </summary>
        internal static string Error_UrlRewriteParseError
        {
            get { return GetString("Error_UrlRewriteParseError"); }
        }

        /// <summary>
        /// Could not parse the UrlRewrite file. Message: '{0}'. Line number '{1}': '{2}'.
        /// </summary>
        internal static string FormatError_UrlRewriteParseError(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_UrlRewriteParseError"), p0, p1, p2);
        }

        /// <summary>
        /// Rules using the '{0}' server variable are not supported
        /// </summary>
        internal static string Error_UnsupportedServerVariable
        {
            get { return GetString("Error_UnsupportedServerVariable"); }
        }

        /// <summary>
        /// Rules using the '{0}' server variable are not supported
        /// </summary>
        internal static string FormatError_UnsupportedServerVariable(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_UnsupportedServerVariable"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
