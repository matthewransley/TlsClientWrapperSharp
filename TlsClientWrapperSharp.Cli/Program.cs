using TlsClientWrapperSharp.Handlers;

var tlsClientHandler = new TlsClientHandler();

var httpClient = new HttpClient(tlsClientHandler);

var responseContent = await httpClient.GetStringAsync(@"https://tls.peet.ws/api/all");

Console.WriteLine(responseContent);
