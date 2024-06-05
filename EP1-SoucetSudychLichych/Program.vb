Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer


        If Integer.TryParse(Console.ReadLine, pocetopakovani) Then
                If pocetopakovani = 1 Then
                    Console.WriteLine($"Zadej {pocetopakovani} celé èíslo.")
                ElseIf 1 > pocetopakovani < 5 Then
                    Console.WriteLine($"Zadej {pocetopakovani} celá èísla.")
                Else Console.WriteLine($"Zadej {pocetopakovani} celých èísel.")
                End If
                Do
                    pocetopakovani = pocetopakovani - 1
                If Integer.TryParse(Console.ReadLine, cislo) Then

                    If pocetopakovani = 0 Then
                        Exit Do
                    End If
                Else Console.WriteLine("Zadávej pouze celá èísla")
                End If
            Loop
            Else Console.WriteLine("Zadávej pouze celá èísla")
            End If



    End Sub
End Module
