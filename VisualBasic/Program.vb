Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para ense�ar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        calculaEdad(1970)
        Console.Read()
    End Sub
    Sub calculaEdad(ByVal a�oNacimiento)
        Dim a�oActual = DateTime.Now.Year
        Dim edad = a�oActual - a�oNacimiento
        Console.WriteLine("La edad del humano que nacio en " & a�oNacimiento & " es de " & edad & " a�os")
        'Console.WriteLine(a�oActual.GetType.ToString)
    End Sub
End Module
