Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer

        Console.WriteLine("Zadej, kolik bude mo�n� zadat ��sel.")
        If Integer.TryParse(Console.ReadLine, pocetopakovani) Then
            If pocetopakovani > 0 Then

                If pocetopakovani = 1 Then
                    Console.WriteLine($"Zadej {pocetopakovani} cel� ��slo.")
                ElseIf 1 < pocetopakovani And pocetopakovani < 5 Then
                    Console.WriteLine($"Zadej {pocetopakovani} cel� ��sla.")
                Else
                    Console.WriteLine($"Zadej {pocetopakovani} cel�ch ��sel.")
                End If
                Do
                    pocetopakovani = pocetopakovani - 1
                    If Integer.TryParse(Console.ReadLine, cislo) Then
                        If cislo > 0 Then

                            If pocetopakovani = 0 Then
                                Exit Do
                            End If
                        Else Console.WriteLine("Zad�vej pouze kladn� ��sla.")
                        End If
                    Else Console.WriteLine("Zad�vej pouze cel� ��sla.")
                            Exit Do
                    End If


                Loop
            Else Console.WriteLine("Zad�vej pouze kladn� ��sla.")
            End If
        Else Console.WriteLine("Zad�vej pouze cel� ��sla.")
        End If



    End Sub
End Module
