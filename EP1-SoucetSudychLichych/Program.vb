Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer



        If pocetopakovani = 1 Then
            Console.WriteLine($"Zadej {pocetopakovani} celé èíslo.")
        ElseIf 1 > pocetopakovani < 5 Then
            Console.WriteLine($"Zadej {pocetopakovani} celá èísla.")
        Else Console.WriteLine($"Zadej {pocetopakovani} celých èísel.")
        End If

        Do
            pocetopakovani = pocetopakovani - 1
            cislo = Console.ReadLine()

            If pocetopakovani = 0 Then
                Exit Do
            End If
        Loop



    End Sub
End Module
