#cs
A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
a2 + b2 = c2

For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
#ce

$aLimit = 332
$bLimit = 449
$cLimit = 997


For $a=1 To $aLimit Step 1
	For $b=1 To $bLimit Step 1
		$c = Sqrt($a^2 + $b^2)
		If StringIsInt($c) Then
			If $a + $b + $c = 1000 Then
				MsgBox(0,"",$a*$b*$c & @CRLF & $a & "-" & $b & "-" & $c)
			EndIf
		EndIf
	Next
Next
