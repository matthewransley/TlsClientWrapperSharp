using TlsClientWrapperSharp.Handlers;

var tlsClientHandler = new TlsClientHandler();

var httpClient = new HttpClient(tlsClientHandler);

var responseContent = await httpClient.GetStringAsync(@"https://tls.browserleaks.com/tls");

Console.WriteLine(responseContent);
