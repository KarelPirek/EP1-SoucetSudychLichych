Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocetopakovani As Integer
        Dim soucetsuda As Integer
        Dim soucetlicha As Integer
        Dim pocetsudych, pocetlichych As Integer
        Do
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
                                If cislo Mod 2 = 0 Then
                                    soucetsuda = soucetsuda + cislo
                                    pocetsudych = pocetsudych + 1
                                Else
                                    soucetlicha = soucetlicha + cislo
                                    pocetlichych = pocetlichych + 1
                                End If
                                If pocetopakovani = 0 Then

                                    Console.WriteLine($"Souèet všech sudých èísel je {soucetsuda} a souèet všech lichých je {soucetlicha}")
                                    Console.WriteLine($"Poèet zadaných sudých èísel je {pocetsudych} a poèet lichých je {pocetlichych}")
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
            Console.ReadKey()
        Loop

    End Sub
End Module
