using System.Net;

namespace TlsClientWrapperSharp.Helpers;

public class ProxyHelper
{
    /// <summary>
    /// Converts a <see cref="WebProxy"/> object to a formatted proxy string in the format "protocol://username:password@host:port".
    /// </summary>
    /// <param name="webProxy">The <see cref="WebProxy"/> object to convert.</param>
    /// <returns>A formatted proxy string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="webProxy"/> or its address is null.</exception>
    public static string ConvertWebProxyToString(WebProxy webProxy)
    {
        if (webProxy == null)
        {
            throw new ArgumentNullException(nameof(webProxy), "The WebProxy cannot be null.");
        }

        if (webProxy.Address == null)
        {
            throw new ArgumentNullException(nameof(webProxy), "The WebProxy address cannot be null.");
        }

        var uri = webProxy.Address;
        var protocol = uri.Scheme;
        var host = uri.Host;
        var port = uri.Port;

        var username = string.Empty;
        var password = string.Empty;

        if (webProxy.Credentials is NetworkCredential credentials)
        {
            username = credentials.UserName;
            password = credentials.Password;
        }

        return string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)
            ? $"{protocol}://{host}:{port}"
            : $"{protocol}://{username}:{password}@{host}:{port}";
    }
}