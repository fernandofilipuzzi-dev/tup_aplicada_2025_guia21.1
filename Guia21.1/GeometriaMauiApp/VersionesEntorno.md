




## instalar la primera vez 


7zip
https://sourceforge.net/projects/sevenzip/

es requerido por el sdk de android


## nuget

OneSignalSDK.DotNet

SkiaSharp
MetadataExtractor            //este se puede reemplazar

CommunityToolkit.Maui.Core
CommunityToolkit.Maui.Camera

BarcodeScanner.Mobile.Maui

## Ver sdk instalados

```
PS H:\repos\...> dotnet --list-sdks
5.0.214 [C:\Program Files\dotnet\sdk]
7.0.317 [C:\Program Files\dotnet\sdk]
8.0.415 [C:\Program Files\dotnet\sdk]
9.0.305 [C:\Program Files\dotnet\sdk]
9.0.306 [C:\Program Files\dotnet\sdk]
```

## ver workloads instalados
```bash
PS H:\repos\...> dotnet workload list --verbosity detailed

Versión de carga de trabajo: 10.0.100.1

Id. de carga de trabajo instalada      Versión del manifiesto      Origen de la instalación
---------------------------------------------------------------------------------------------------------------------
android                                36.1.2/10.0.100             SDK 10.0.100, VS 17.14.36705.20, VS 18.0.11205.157
ios                                    26.1.10494/10.0.100         SDK 10.0.100, VS 17.14.36705.20, VS 18.0.11205.157
maccatalyst                            26.1.10494/10.0.100         SDK 10.0.100, VS 17.14.36705.20, VS 18.0.11205.157
maui-windows                           10.0.0/10.0.100             SDK 10.0.100, VS 17.14.36705.20, VS 18.0.11205.157

Use "dotnet workload search" para buscar cargas de trabajo adicionales para instalar.
```

```
PS H:\repos\...> dotnet workload update 


Manifiesto publicitario actualizado microsoft.net.workloads
Instalando la versión de carga de trabajo 10.0.100.1.
Downloading microsoft.net.workloads.10.0.100.msi.x64 (10.100.1)
Instalando microsoft.net.workloads.10.0.100.msi.x64 .... Done
Downloading microsoft.net.workload.emscripten.current.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.emscripten.net6.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.emscripten.net7.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.emscripten.net8.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.emscripten.net9.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.sdk.android.manifest-10.0.100.msi.x64 (36.1.2)
Downloading microsoft.net.sdk.ios.manifest-10.0.100.msi.x64 (26.1.10494)
Instalando microsoft.net.sdk.ios.manifest-10.0.100.msi.x64 .... Done
Downloading microsoft.net.sdk.maccatalyst.manifest-10.0.100.msi.x64 (26.1.10494)
Instalando microsoft.net.sdk.maccatalyst.manifest-10.0.100.msi.x64 .... Done
Downloading microsoft.net.sdk.macos.manifest-10.0.100.msi.x64 (26.1.10494)
Instalando microsoft.net.sdk.macos.manifest-10.0.100.msi.x64 .... Done
Downloading microsoft.net.sdk.maui.manifest-10.0.100.msi.x64 (10.0.0)
Downloading microsoft.net.sdk.tvos.manifest-10.0.100.msi.x64 (26.1.10494)
Instalando microsoft.net.sdk.tvos.manifest-10.0.100.msi.x64 .... Done
Downloading microsoft.net.workload.mono.toolchain.current.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.mono.toolchain.net6.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.mono.toolchain.net7.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.mono.toolchain.net8.manifest-10.0.100.msi.x64 (10.0.100)
Downloading microsoft.net.workload.mono.toolchain.net9.manifest-10.0.100.msi.x64 (10.0.100)
No hay cargas de trabajo instaladas para esta banda de características. Para actualizar las cargas de trabajo instaladas con versiones anteriores del SDK, incluya la opción --from-previous-sdk.
Escritura de registros de instalación para cargas de trabajo de Visual Studio: 'maui-windows, maccatalyst, ios, android'
Downloading Microsoft.Maui.Graphics.Win2D.WinUI.Desktop.Msi.x64 (10.0.0)
Downloading Microsoft.AspNetCore.Components.WebView.Maui.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Sdk.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Graphics.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Resizetizer.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Templates.net10.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Core.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Controls.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Controls.Build.Tasks.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Controls.Core.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Controls.Xaml.Msi.x64 (10.0.0)
Downloading Microsoft.Maui.Essentials.Msi.x64 (10.0.0)
Downloading Microsoft.MacCatalyst.Sdk.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Sdk.net10.0_26.1.Msi.x64 ..... Done
Downloading Microsoft.MacCatalyst.Sdk.net9.0_26.0.Msi.x64 (26.0.9769)
Instalando Microsoft.MacCatalyst.Sdk.net9.0_26.0.Msi.x64 ..... Done
Downloading Microsoft.MacCatalyst.Sdk.net10.0_26.0.Msi.x64 (26.0.11017)
Downloading Microsoft.MacCatalyst.Ref.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Ref.net10.0_26.1.Msi.x64 ..... Done
Downloading Microsoft.MacCatalyst.Runtime.maccatalyst.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Runtime.maccatalyst.net10.0_26.1.Msi.x64 ..... Done
Downloading Microsoft.MacCatalyst.Runtime.maccatalyst-x64.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Runtime.maccatalyst-x64.net10.0_26.1.Msi.x64 .... Done
Downloading Microsoft.MacCatalyst.Runtime.maccatalyst-arm64.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Runtime.maccatalyst-arm64.net10.0_26.1.Msi.x64 .... Done
Downloading Microsoft.MacCatalyst.Templates.Msi.x64 (26.1.10494)
Instalando Microsoft.MacCatalyst.Templates.Msi.x64 .... Done
Downloading Microsoft.NETCore.App.Runtime.Mono.maccatalyst-arm64.Msi.x64 (10.0.0)
Downloading Microsoft.NETCore.App.Runtime.Mono.maccatalyst-x64.Msi.x64 (10.0.0)
Downloading Microsoft.NET.Runtime.MonoAOTCompiler.Task.Msi.x64 (10.0.0)
Downloading Microsoft.NET.Runtime.MonoTargets.Sdk.Msi.x64 (10.0.0)
Downloading Microsoft.iOS.Sdk.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.iOS.Sdk.net10.0_26.1.Msi.x64 ....... Done
Downloading Microsoft.iOS.Sdk.net9.0_26.0.Msi.x64 (26.0.9769)
Instalando Microsoft.iOS.Sdk.net9.0_26.0.Msi.x64 ....... Done
Downloading Microsoft.iOS.Sdk.net10.0_26.0.Msi.x64 (26.0.11017)
Downloading Microsoft.iOS.Windows.Sdk.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.iOS.Windows.Sdk.net10.0_26.1.Msi.x64 ..... Done
Downloading Microsoft.iOS.Windows.Sdk.net9.0_26.0.Msi.x64 (26.0.9769)
Instalando Microsoft.iOS.Windows.Sdk.net9.0_26.0.Msi.x64 ....... Done
Downloading Microsoft.iOS.Windows.Sdk.net10.0_26.0.Msi.x64 (26.0.11017)
Downloading Microsoft.iOS.Ref.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.iOS.Ref.net10.0_26.1.Msi.x64 ..... Done
Downloading Microsoft.iOS.Runtime.ios.net10.0_26.1.Msi.x64 (26.1.10494)
Instalando Microsoft.iOS.Runtime.ios.net10.0_26.1.Msi.x64 ..... Done

```

```
PS H:\repos\...> dotnet workload update --print-rollback
{
  "microsoft.net.sdk.android": "35.0.105/9.0.100",
  "microsoft.net.sdk.ios": "26.0.9752/9.0.100",
  "microsoft.net.sdk.maccatalyst": "26.0.9752/9.0.100",
  "microsoft.net.sdk.macos": "26.0.9752/9.0.100",
  "microsoft.net.sdk.maui": "9.0.111/9.0.100",
  "microsoft.net.sdk.tvos": "26.0.9752/9.0.100",
  "microsoft.net.workload.mono.toolchain.current": "9.0.10/9.0.100",
  "microsoft.net.workload.emscripten.current": "9.0.10/9.0.100",
  "microsoft.net.workload.emscripten.net6": "9.0.10/9.0.100",
  "microsoft.net.workload.emscripten.net7": "9.0.10/9.0.100",
  "microsoft.net.workload.emscripten.net8": "9.0.10/9.0.100",
  "microsoft.net.workload.mono.toolchain.net6": "9.0.10/9.0.100",
  "microsoft.net.workload.mono.toolchain.net7": "9.0.10/9.0.100",
  "microsoft.net.workload.mono.toolchain.net8": "9.0.10/9.0.100",
  "microsoft.net.sdk.aspire": "8.2.2/8.0.100"
}
```

## ver .net sdk
```
PS H:\repos\...P> dotnet --version
9.0.306
```

```
PS H:\repos\...> dotnet workload update
```