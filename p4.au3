#cs
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.

Find the largest palindrome made from the product of two 3-digit numbers.
#ce

#Include <String.au3>
$t=0
For $i=999 To 900 Step -1
	For $j=999 To 900 Step -1
		$t = $i*$j
		If _StringReverse(String($t)) = String($t) Then
			MsgBox(0,"",$t&" -- "&$i&" -- "&$j)
			ClipPut($t)
			Exit
		EndIf
	Next
Next
