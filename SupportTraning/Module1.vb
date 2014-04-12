Module Module1

    Sub Main()

        For index = 1 To 100
            If index Mod 3 = 0 And index Mod 5 = 0 Then
                Console.WriteLine("SupportTraining")
            ElseIf index Mod 3 = 0 Then
                Console.WriteLine("Support")
            ElseIf index Mod 5 = 0 Then
                Console.WriteLine("Training")
            Else
                Console.WriteLine(index)
            End If

        Next

    End Sub

End Module
