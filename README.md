
# Welcome to Hetzner Cloud DotNet

![Hetzner Cloud DotNet](https://raw.githubusercontent.com/ljchuello/Hetzner-Cloud-DotNet/master/icon_128.png)

This library allows you to manage all the services offered by Hetzner Cloud, with this library you can manage and automate the creation of servers until the implementation of applications that allow you to scale horizontally.

![Nuget](https://img.shields.io/nuget/v/HetznerCloudApiDotNet?style=for-the-badge) ![Download](https://img.shields.io/nuget/dt/HetznerCloudApiDotNet?style=for-the-badge) ![Files](https://img.shields.io/github/directory-file-count/ljchuello/Hetzner-Cloud-DotNet?style=for-the-badge) ![Size](https://img.shields.io/github/repo-size/ljchuello/Hetzner-Cloud-DotNet?style=for-the-badge) ![Languahe](https://img.shields.io/github/languages/top/ljchuello/Hetzner-Cloud-DotNet?style=for-the-badge) ![Last](https://img.shields.io/github/last-commit/ljchuello/Hetzner-Cloud-DotNet?style=for-the-badge) ![Contributors](https://img.shields.io/github/contributors/ljchuello/Hetzner-Cloud-DotNet?style=for-the-badge)

## Compatibility

This library is developed in .NET Standard 2.1 and is compatible with all .NET and .NET Core implementations (**.NET Framework is not supported**), it can also be used in Console projects, Web API, Class Library and even with Blazor WASM .

| .NET implementation        	| Version support         	|
|----------------------------	|-------------------------	|
| .NET and .NET Core         	| 3.0, 3.1, 5.0, 6.0, 7.0 	|
| .NET Framework             	| N/A                     	|

## Installation

To install you must go to Nuget package manager and search for "HetznerCloudApiDotNet" and then install.

### NuGet-CLI
PM> Install-Package [HetznerCloudApiDotNet ](https://www.nuget.org/packages/HetznerCloudApiDotNet/)

## Usage

```csharp
// Set token
HetznerDotNet.ApiCore.ApiToken = "UltraPrivateSecretKeyHetzner";

// Get SSH
HetznerDotNet.Api.SshKey sshKey = await HetznerDotNet.Api.SshKey.Get(123456789);

// Get location
HetznerDotNet.Api.Location location = await HetznerDotNet.Api.Location.Get(3);

// Get Ubuntu image
HetznerDotNet.Api.Image image = await HetznerDotNet.Api.Image.Get(67794396);

// Create Server
await HetznerDotNet.Api.Server.Create("Server Test", new List<long> { sshKey.Id }, location.Id, image.Id, 15);
```

### Implemented functionality
To have the complete list of the functionalities implemented in this library [consult the Wiki](https://github.com/ljchuello/Hetzner-Cloud-DotNet/wiki)

---

> Made with ❤️ in LATAM for the 🌎
