#cs
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
#ce

$n1=0
$n2=0

For $i=1 To 100 Step 1
	$n1+= $i^2
	$n2+= $i
Next
$t=($n2^2) - $n1
ClipPut($t)
MsgBox(0,"",$t)
