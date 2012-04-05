#cs
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
#ce

#Include <String.au3>
$n1=0
$n2=0
$t=1

For $i=3 To 150000 Step 1
	If _p($i) Then
		$t+=1
		If $t=10001 Then ExitLoop
	EndIf
Next

MsgBox(0,"",$i)


Func _p($n)
	$sq=Ceiling(Sqrt($n))
	For $i=2 To $sq Step 1
		If Mod($n,$i)=0 Then
			Return 0
		EndIf
	Next
	return 1
EndFunc
