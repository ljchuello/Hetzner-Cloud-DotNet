# Welcome to Hetzner Cloud DotNet

![Hetzner Cloud DotNet](https://raw.githubusercontent.com/ljchuello/Hetzner-Cloud-DotNet/master/icon_128.png)

![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=security_rating) ![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=bugs) ![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=vulnerabilities) ![](https://img.shields.io/nuget/v/HetznerCloudApiDotNet) ![](https://img.shields.io/nuget/dt/HetznerCloudApiDotNet) ![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=reliability_rating) ![](https://img.shields.io/github/languages/code-size/ljchuello/Hetzner-Cloud-DotNet) ![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=ncloc) ![](https://img.shields.io/github/languages/top/ljchuello/Hetzner-Cloud-DotNet) ![](https://sonarcloud.io/api/project_badges/measure?project=ljchuello_Hetzner-Cloud-DotNet&metric=sqale_rating) ![](https://img.shields.io/github/contributors/ljchuello/Hetzner-Cloud-DotNet) ![](https://img.shields.io/github/last-commit/ljchuello/Hetzner-Cloud-DotNet)

This library allows you to manage all the services offered by Hetzner Cloud, with this library you can manage and automate the creation of servers until the implementation of applications that allow you to scale horizontally.

## Compatibility

This library is developed in .NET Standard 2.1 and is compatible with all .NET and .NET Core implementations (**.NET Framework is not supported**), it can also be used in Console projects, Web API, Class Library and even with Blazor WASM .

| .NET implementation        	| Version support         	|
|----------------------------	|-------------------------	|
| .NET and .NET Core         	| 3.0, 3.1, 5.0, 6.0, 7.0 	|
| .NET Framework             	| N/A                     	|

## Installation

To install you must go to Nuget package manager and search for "HetznerCloudApiDotNet" and then install.



### [NuGet Package](https://www.nuget.org/packages/HetznerCloudApiDotNet/)

    PM> Install-Package HetznerCloudApiDotNet

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

## Implemented functionality

:heavy_check_mark: - Available on API, implemented\
:x: - Available on API, not implemented\
:heavy_minus_sign:  - Not available on API

|  | Get one | Get all | Create | Update | Delete | Actions |
|--|:--:|:--:|:--:|:--:|:--:|:--:|
| Certificates | :x: | :x: | :x: | :x: | :x: | :x: |
| Datacenters | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Firewalls | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| Floating IPs | :x: | :x: | :x: | :x: | :x: | :x: |
| Images | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| ISOs | :x: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Load Balancers | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| Locations | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Primary IPs | :x: | :x: | :x: | :x: | :x: | :x: |
| Networks | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| Placement Groups | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| Pricing | :heavy_minus_sign: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Servers | :x: | :x: | :x: | :x: | :x: | :x: |
| Server Types | :x: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| SSH Keys | :x: | :x: | :x: | :x: | :x: | :heavy_minus_sign: |
| Volumes | :x: | :x: | :x: | :x: | :x: | :x: |

To have the complete list of the functionalities implemented in this library [consult the Wiki](https://github.com/ljchuello/Hetzner-Cloud-DotNet/wiki)

---

> Made with ❤️ in LATAM for the 🌎
