# TlsClientWrapperSharp

TlsClientWrapperSharp is a .NET library designed to provide a custom HttpClientHandler that leverages a TLS client DLL to send HTTP requests. This library is particularly useful for scenarios where mimicking various browsers and devices is required.

## Features

- Custom HttpClientHandler implementation.
- Supports various TLS client identifiers for mimicking different browsers and devices.
- Proxy support for HTTP requests.
- Easy integration with existing .NET applications.

## Installation

To use TlsClientWrapperSharp, you need to clone the repository and add it to your project:
```bash
    git clone https://github.com/matthewransley/TlsClientWrapperSharp.git
```

Then, add the cloned project to your solution and reference it in your application.

## Usage

Here is an example of how to use TlsClientWrapperSharp to send an HTTP GET request using the custom TLS client handler:
```csharp
    using TlsClientWrapperSharp.Handlers;

    var tlsClientHandler = new TlsClientHandler
    {
        TlsClientIdentifier = "chrome_124" // Set the desired TLS client identifier
    };

    var httpClient = new HttpClient(tlsClientHandler);

    var responseContent = await httpClient.GetStringAsync(@"https://tls.peet.ws/api/all");

    Console.WriteLine(responseContent);
```
## TlsClientHandler

The `TlsClientHandler` class is the core of TlsClientWrapperSharp, providing a custom HttpClientHandler that uses a TLS client DLL to handle HTTP requests.

### Properties

- `Proxy`: Gets or sets the proxy for the HTTP requests.
- `SessionId`: Gets or sets the session ID for the requests.
- `TlsClientIdentifier`: Gets or sets the TLS client identifier.

### Methods

- `SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)`: Sends an HTTP request asynchronously using the custom TLS client.

### Available TlsClientIdentifiers

The library supports various TLS client identifiers to mimic different browsers and devices. Here are the available identifiers:

- Chrome: `chrome_103`, `chrome_104`, `chrome_105`, `chrome_106`, `chrome_107`, `chrome_108`, `chrome_109`, `chrome_110`, `chrome_111`, `chrome_112`, `chrome_116_PSK`, `chrome_116_PSK_PQ`, `chrome_117`, `chrome_120`, `chrome_124`
- Safari: `safari_15_6_1`, `safari_16_0`, `safari_ipad_15_6`, `safari_ios_15_5`, `safari_ios_15_6`, `safari_ios_16_0`, `safari_ios_17_0`
- Firefox: `firefox_102`, `firefox_104`, `firefox_105`, `firefox_106`, `firefox_108`, `firefox_110`, `firefox_117`, `firefox_120`, `firefox_123`
- Opera: `opera_89`, `opera_90`, `opera_91`
- Zalando: `zalando_android_mobile`, `zalando_ios_mobile`
- Nike: `nike_ios_mobile`, `nike_android_mobile`
- Cloudflare: `cloudscraper`
- MMS: `mms_ios`, `mms_ios_2`, `mms_ios_3`
- Mesh: `mesh_ios`, `mesh_ios_2`, `mesh_android`, `mesh_android_2`
- Confirmed: `confirmed_ios`, `confirmed_android`
- Okhttp: `okhttp4_android_7`, `okhttp4_android_8`, `okhttp4_android_9`, `okhttp4_android_10`, `okhttp4_android_11`, `okhttp4_android_12`, `okhttp4_android_13`

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue to discuss any changes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.

## Contact

For questions or support, please open an issue on GitHub.
