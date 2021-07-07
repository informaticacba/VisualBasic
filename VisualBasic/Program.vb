Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para ense�ar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim edad = calculaEdad(1970)
        Console.WriteLine("La edad del humano es de " & edad & " a�os")
        Dim a�o = a�oNacimiento(20)
        Console.WriteLine("El a�o de nacimiento del humano es de " & a�o)
        Console.Read()
    End Sub
    Function calculaEdad(ByVal a�oNacimiento)
        Dim a�oActual = DateTime.Now.Year
        Return a�oActual - a�oNacimiento
        'Console.WriteLine("La edad del humano que nacio en " & a�oNacimiento & " es de " & edad & " a�os")
        'Console.WriteLine(a�oActual.GetType.ToString)
    End Function
    Function a�oNacimiento(ByVal edad)
        Dim a�oActual = DateTime.Now.Year
        Return a�oActual - edad
    End Function
End Module
