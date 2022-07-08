Module Helper

    'Issue is that on Windows 11, Enviroment.UserName gives a false name, time to update it to correct path. - LaocheXe July 8th 2022
    'Public SaveGameDir As String = $"C:\Users\{Environment.UserName}\appdata\locallow\Red Dot Games\Car Mechanic Simulator 2018"
    Public SaveGameDir As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Red Dot Games\Car Mechanic Simulator 2018"
    Public GlobalData As String = "GlobalData.dat"

End Module
