Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer

        Console.WriteLine("Zadej, kolik bude možné zadat èísel.")
        If Integer.TryParse(Console.ReadLine, pocetopakovani) Then
            If pocetopakovani > 0 Then

                If pocetopakovani = 1 Then
                    Console.WriteLine($"Zadej {pocetopakovani} celé èíslo.")
                ElseIf 1 < pocetopakovani And pocetopakovani < 5 Then
                    Console.WriteLine($"Zadej {pocetopakovani} celá èísla.")
                Else
                    Console.WriteLine($"Zadej {pocetopakovani} celých èísel.")
                End If
                Do
                    pocetopakovani = pocetopakovani - 1
                    If Integer.TryParse(Console.ReadLine, cislo) Then
                        If cislo > 0 Then

                            If pocetopakovani = 0 Then
                                Exit Do
                            End If
                        Else Console.WriteLine("Zadávej pouze kladná èísla.")
                        End If
                    Else Console.WriteLine("Zadávej pouze celá èísla.")
                            Exit Do
                    End If


                Loop
            Else Console.WriteLine("Zadávej pouze kladná èísla.")
            End If
        Else Console.WriteLine("Zadávej pouze celá èísla.")
        End If



    End Sub
End Module
