Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para ense�ar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("�Humano cual es tu nombre?")
        Dim nombre = Console.ReadLine()
        Console.WriteLine("�" & nombre & " en que a�o naciste?")
        Dim a�oNacimiento = Integer.Parse(Console.ReadLine())
        Dim edad = DateTime.Now.Year - a�oNacimiento
        Console.WriteLine("�Humano cuanto dinero ganas?")
        Dim sueldo = Single.Parse(Console.ReadLine())
        Console.WriteLine("Pobre " & nombre & " a tus " & edad & " a�os solo ganas " & sueldo & " pesitos")
    End Sub
End Module
