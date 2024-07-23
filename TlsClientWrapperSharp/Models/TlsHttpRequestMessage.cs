using System.Net;

namespace TlsClientWrapperSharp.Models;

public class TlsHttpRequestMessage : HttpRequestMessage
{
    //We create our own Headers and request message, because default HttpRequestMessage performs validation on the headers object, and TryAddWithoutValidation doesn't work when using a custom HttpClientHandler (Nice one microsoft!)
    public Dictionary<string, string> Headers { get; set; }
}