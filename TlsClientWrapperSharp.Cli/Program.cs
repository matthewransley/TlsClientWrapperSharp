using TlsClientWrapperSharp.Handlers;

var tlsClientHandler = new TlsClientHandler();

var httpClient = new HttpClient(tlsClientHandler);

httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-GB,en;q=0.9");

var responseContent = await httpClient.GetStringAsync(@"https://tls.browserleaks.com/tls");

Console.WriteLine(responseContent);
