Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer
        Dim soucetsuda As Integer
        Dim soucetlicha As Integer

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
                            If cislo Mod 2 = 0 Then
                                soucetsuda = soucetsuda + cislo
                            Else
                                soucetlicha = soucetlicha + cislo
                            End If
                            If pocetopakovani = 0 Then

                                Console.WriteLine($"Sou�et v�ech sud�ch ��sel je {soucetsuda} a sou�et v�ech lich�ch je {soucetlicha}")
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
