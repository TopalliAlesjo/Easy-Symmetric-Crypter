Imports Microsoft.VisualBasic.Devices

Module Module1
    Dim parola, par, par2, key As String
    Dim num, nn As Short
    Dim i As Byte
    Dim chiave As ConsoleKeyInfo
    Sub Main() ' main assemblo tutto 

        Console.Title = "Crypter Menu"
        Dim number As Byte
        Console.ForegroundColor = ConsoleColor.DarkCyan
        scrit()
        Console.Write("1) crypter symmetric key" & vbCrLf & "2) decrypter symmetric key" & vbCrLf & vbCrLf & "Inserisci l'opzione: ")
        number = Console.ReadLine()
        Console.Clear()

        Select Case number
            Case 1
                scrit()
                crypter()
            Case 2
                scrit()
                decrypter()
            Case Else
                Console.ForegroundColor = ConsoleColor.Red
                scrit()
                Console.WriteLine("Errore l'opzione non esiste!")
                returnback()
        End Select
        Console.ReadLine()
    End Sub

    Sub crypter() ' crypter a chiave simmetrica
        key = ""

        Console.Write("inserisci la frase: ")
        parola = Console.ReadLine()

        num = parola.Length

        For i = 0 To num - 1
            par = parola.Substring(i, 1) ' prende lettera
            par2 = Asc(par) ' converte in ascii
            nn = par2 + 4 ' simmetria a 4
            key += Chr(nn) ' ritorna la lettera con simmetria a 4

        Next
        Console.WriteLine($"frase cryptata : {key}")
        returnback()
    End Sub


    Sub decrypter() ' decrypter a chiave simmetrica
        key = ""

        Console.Write("inserisci la frase: ")
        parola = Console.ReadLine()

        num = parola.Length

        For i = 0 To num - 1
            par = parola.Substring(i, 1) ' prende lettera
            par2 = Asc(par) ' converte in ascii
            nn = par2 - 4 ' simmetria a -4
            key += Chr(nn) ' ritorna la lettera con simmetria a -4

        Next
        Console.WriteLine($"frase cryptata : {key}")
        returnback()
    End Sub

    Sub returnback()
        Console.Write(vbCrLf & vbCrLf & "Clicca INVIO per tornare all'inizio.")
        chiave = Console.ReadKey()
        If chiave.Key = ConsoleKey.Enter Then
            Console.Clear()
            Main()
        End If
    End Sub

    Sub scrit()
        Console.WriteLine("
█▀▀ █▀█ █▄█ █▀█ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█
█▄▄ █▀▄ ░█░ █▀▀ ░█░   █░▀░█ ██▄ █░▀█ █▄█")
    End Sub
End Module