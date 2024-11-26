Imports System
Imports CarLibrary

Module Program
    Sub Main(args As String())
        Console.WriteLine(" Visual basic Car Client.")
        Dim myMiniVan as new MiniVan()
        myMiniVan.TurboBoost()

        Dim mySportsCar as new SportsCar()
        mySportsCar.TurboBoost()

        Dim myPerformanceCar As New PerformanceCar()
        myPerformanceCar.TurboBoost()
    End Sub
End Module
