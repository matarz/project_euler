#cs
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
#ce


$t=0
for $i=1 To 999 Step 1
	if Mod($i,3)=0 Or Mod($i,5)=0 Then
		$t+=$i
	EndIf
Next
MsgBox(0,"",$t)
