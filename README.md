# dotnet-8-itypeinfo-issue

Demonstrates the issue whereas a .NET8-based custom user control cannot be inserted into VBA forms.

Contains a WinForms Control Library built with .Net Framework 4.8 and its exact replica (with all GUIDs and ProgIds preserved) built with .NET 8. Type Library from the first project is also injected into the second one via \<ComHostTypeLibrary\> directive.

## How to use

1. Run Visual Studio *as administrator*.
2. Open and build the `DotNetFramework\TinoTestWindowsFormsControlLibrary` project.
3. Open VBA editor in Word or Excel:

     <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/c1d86893-f6e7-45a6-936f-293bc61cfe61"/>

4. At this point the `TinoTestWindowsFormsControlLibrary.TinoTestUserControl` custom control should become available. Insert it onto a form:

    <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/16d0622f-f02c-4c5c-ae6e-30cd2020960f"/>
    <br>
    <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/ecc1fe97-c22f-46a6-80e0-44c06e40959b"/>
   
6. Observe the .Net Framework-based control working:

    <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/fb18ad51-ae65-46a1-9511-fd78659e57a1"/>

7. Open and build the `DotNET\TinoTestWindowsFormsControlLibrary` project.
8. Manually put the full path to .NET-based control's shim file into the `InprocServer32` Registry Key:

   ![image](https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/5143dcdd-24a8-4c1a-b84c-7ab7310bebe4)
    
10. Restart Word/Excel and reopen its VBA editor.
11. Place the control onto a form again.
12. Observe that now the .NET-based control is successfully instantiated:

       <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/03419d20-d88a-481b-b333-62857e88e47e"/>

    but then the editor fails with `0x80131165 TypeLib not registered` error:

       <img width="500px" src="https://github.com/scale-tone/dotnet-8-itypeinfo-issue/assets/5447190/a1a28849-8d19-4de5-8a8f-43e1743e1400"/>

       
