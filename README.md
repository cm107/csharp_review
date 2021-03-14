# C# Review Notes
This is a collection of the test scripts and notes that I took while going through [Sololearn's C# Course](https://www.sololearn.com/learning/1080).

## Getting Your System Setup For C# Programming
Install .net SDK
```bash=
wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-5.0  
sudo apt-get install -y dotnet-runtime-5.0
```

Then install mono-complete.
```bash=
sudo apt install mono-complete
```

Make sure that dotnet is working.

Make sure that dotnet working, and also that it is in your PATH.

![](https://i.imgur.com/8J4AjgF.png)
![](https://i.imgur.com/9xAcRW8.png)

If it isn't, add it to your ```~/.bashrc```.
```bash
# Dotnet
export PATH="/usr/share/dotnet:$PATH"
```

Install the C# Extension in Visual Studio Code.

![](https://i.imgur.com/bSinJ35.png)

Open VS Code, go to menu File - Preferences - Settings - Extension - C# configuration
look for "Omnisharp: Use Global Mono", and set it to "never".

![](https://i.imgur.com/t90ZTbE.png)

Restart OmniSharp.

## Making A New Project
Create a new console application using dotnet.
```bash
dotnet new console -o myapp
```

Open the project <b><u>folder</u><b> in VS Code.
```bash
cd myapp
code .
```

Edit the code.
Press Ctrl+` to open the terminal.
Then run the application.
```bash
dotnet run
```

Note that VS Code requires that the project folder be opened in order for Intellisense to work.