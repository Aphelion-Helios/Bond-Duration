' PV of Bond using Loop

Function PVBmloop(cpr, r, T, Face, m)

	

	coup = Face * cpr / m

	Price = 0

	

	For i = 1 To m * T

    	Price = coup * (1 + r / m) ^ (-i) + Price

	Next i

        	

	PVBmloop = Price + Face * (1 + r / m) ^ (-m * T)

	

End Function

 

' Duration

Function PVBmDur(cpr, r, T, Face, m)

	

	coup = Face * cpr / m

	Price = Face * (1 + r / m) ^ (-m * T)

	Dur = Face * T * (1 + r / m) ^ (-m * T)

	

	For i = 1 To m * T

    	Price = coup * (1 + r / m) ^ (-i) + Price

	Next i

   	

	For i = 1 To m * T

    	Dur = coup * (i / m) * (1 + r / m) ^ (-i) + Dur

 

	Next i

  

	PVBmDur = Dur / Price

 

End Function