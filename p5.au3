#cs
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
#ce

$t=0
For $i=660 To 100000000000000 Step 220
	If Mod($i,13)=0 And Mod($i,14)=0 And Mod($i,16)=0 And Mod($i,17)=0 And Mod($i,18)=0 And Mod($i,19)=0 Then
		ExitLoop
	EndIf
Next
MsgBox(0,"",$i)
