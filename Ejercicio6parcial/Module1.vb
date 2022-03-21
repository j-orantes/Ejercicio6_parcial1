Module Module1

	Sub Main()
		Console.WriteLine("CALCULAR LA LONGITUD DE LA CIRCUNFERENCIA Y EL ÁREA DEL CÍRCULO DE RADIO DADO.")
		console.write("Hola Jairo soy Luis y estoy probando cosas nuevas :v")
		Console.WriteLine()
		Dim radio As Decimal
		Dim opcion As Integer = 0
		Dim p As Double = 3.1416
		While opcion <= 2
			Console.Write("¿Qué desea calcular? | LONGITUD = 1 | ÁREA = 2 | Salir = 3 | : ")
			opcion = Console.ReadLine()
			Select Case opcion
				Case 1
					Console.Write("Ingrese el radio: ")
					radio = Console.ReadLine
					Console.WriteLine("La logitud de la circunferencia es: {0}", Longtd(p, radio))
				Case 2
					Console.Write("Ingrese el radio: ")
					radio = Console.ReadLine
					Area(p, radio)
				Case Else
			End Select
		End While

	End Sub

	Function Longtd(p As Decimal, radio As Decimal) As Decimal
		Return ((2 * p) * radio)
	End Function

	Sub Area(p As Decimal, radio As Decimal)
		Dim resultado As Decimal
		resultado = (p * (radio * radio))
		Console.WriteLine("El área de la circunferencia es: {0}", resultado)
		Console.ReadLine()
	End Sub

End Module
