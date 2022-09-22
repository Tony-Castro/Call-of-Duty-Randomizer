Public Class Form1

    Dim rnd As New Random
    Dim intArray(0 To 54) As String

    Dim intArray2(0 To 5) As String

    Dim intArray3(0 To 12) As String
    Dim intarray4(0 To 9) As String
    Dim intArray5(0 To 5) As String
    Dim intArray6(0 To 5) As String
    Dim intArray7(0 To 5) As String
    Dim intArray8(0 To 3) As String


    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sniper Rifles'
        intArray8(0) = "	Dragunov	"
        intArray8(1) = "	HDR	"
        intArray8(2) = "	AX-50	"
        intArray8(3) = "	Rytec AMR	"


        'Marksman Rifles'
        intArray7(0) = "	EBR-14	"
        intArray7(1) = "	MK2 Carbine	"
        intArray7(2) = "	Kar98k	"
        intArray7(3) = "	Crossbow	"
        intArray7(4) = "	SKS	"
        intArray7(5) = "	SP-R 208	"


        'LMGS'
        intArray6(0) = "	PKM	"
        intArray6(1) = "	SA87	"
        intArray6(2) = "	M91	"
        intArray6(3) = "	MG34	"
        intArray6(4) = "	Holger-26	"
        intArray6(5) = "	Bruen Mk9	"


        'Shotguns'
        intArray5(0) = "	Model 680	"
        intArray5(1) = "	R9-0 Shotgun	"
        intArray5(2) = "	725	"
        intArray5(3) = "	Origin 12 Shotgun	"
        intArray5(4) = "	VLK Rogue	"
        intArray5(5) = "	JAK-12	"

        'SMGS'
        intarray4(0) = "	AUG	"
        intarray4(1) = "	P90	"
        intarray4(2) = "	MP5	"
        intarray4(3) = "	UZI	"
        intarray4(4) = "	PP19	"
        intarray4(5) = "	MP7	"
        intarray4(6) = "	STRIKER 45	"
        intarray4(7) = "	FENNEC	"
        intarray4(8) = "	ISO	"
        intarray4(9) = "	CX-9	"

        'Assault Rifles'
        intArray3(0) = "Kilo 141"
        intArray3(1) = "FAL"
        intArray3(2) = "M4A1"
        intArray3(3) = "FR 5.56"
        intArray3(4) = "Oden"
        intArray3(5) = "M13"
        intArray3(6) = "FN Scar 17"
        intArray3(7) = "AK 47"
        intArray3(8) = "RAM 7"
        intArray3(9) = "Grau 5.56"
        intArray3(10) = "CR-56 AMAX"
        intArray3(11) = "AN-94"
        intArray3(12) = "AS VAL"


        'weapon types'
        intArray2(0) = "Assault Rifles"
        intArray2(1) = "SMGS"
        intArray2(2) = "Shotguns"
        intArray2(3) = "LMGS"
        intArray2(4) = "Marksman Rifles"
        intArray2(5) = "Sniper Rifles"

        ' all weapons'
        intArray(0) = "	Kilo 141"
        intArray(1) = "	FAL"
        intArray(2) = "	M4A1"
        intArray(3) = "	FR 5.56	"
        intArray(4) = "	Oden"
        intArray(5) = "	M13	"
        intArray(6) = "	FN Scar 17	"
        intArray(7) = "	AK 47	"
        intArray(8) = "	RAM 7	"
        intArray(9) = "	Grau 5.56	"
        intArray(10) = "CR-56 AMAX	"
        intArray(11) = "AN-94	"
        intArray(12) = "AS VAL	"
        intArray(13) = "AUG	"
        intArray(14) = "P90	"
        intArray(15) = "MP5	"
        intArray(16) = "UZI	"
        intArray(17) = "PP19	"
        intArray(18) = "MP7	"
        intArray(19) = "STRIKER 45	"
        intArray(20) = "FENNEC	"
        intArray(21) = "ISO	"
        intArray(22) = "CX-9	"
        intArray(23) = "Model 680	"
        intArray(24) = "R9-0 Shotgun	"
        intArray(25) = "725	"
        intArray(26) = "Origin 12 Shotgun	"
        intArray(27) = "VLK Rogue	"
        intArray(28) = "JAK-12	"
        intArray(29) = "PKM	"
        intArray(30) = "SA87	"
        intArray(31) = "M91	"
        intArray(32) = "MG34	"
        intArray(33) = "Holger-26	"
        intArray(34) = "Bruen Mk9	"
        intArray(35) = "EBR-14	"
        intArray(36) = "MK2 Carbine	"
        intArray(37) = "Kar98k	"
        intArray(38) = "Crossbow	"
        intArray(39) = "SKS	"
        intArray(40) = "SP-R 208	"
        intArray(41) = "Dragunov	"
        intArray(42) = "HDR	"
        intArray(43) = "AX-50	"
        intArray(44) = "Rytec AMR	"
        intArray(45) = "Riot Shield	"
        ' inserting different array variables, from 46, X
        intArray(46) = "Muzzle"
        intArray(47) = "Barrel"
        intArray(48) = "Laser"
        intArray(49) = "Optic"
        intArray(50) = "Stock"
        intArray(51) = "Underbarrel"
        intArray(52) = "Magazine"
        intArray(53) = "Rear Grip"
        intArray(54) = "Perk"

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = intArray(rnd.Next(0, 46))
        Label2.Text = intArray(rnd.Next(0, 46))
        Label4.Text = intArray(rnd.Next(46, 49))
        Label5.Text = intArray(rnd.Next(49, 51))
        Label6.Text = intArray(rnd.Next(51, 53))
        Label7.Text = intArray(rnd.Next(53, 55))
        Label9.Text = intArray(rnd.Next(46, 49))
        Label10.Text = intArray(rnd.Next(49, 51))
        Label11.Text = intArray(rnd.Next(51, 53))
        Label12.Text = intArray(rnd.Next(53, 55))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label13.Text = intArray2(rnd.Next(0, 6))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label14.Text = intArray3(rnd.Next(0, 13))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label15.Text = intarray4(rnd.Next(0, 10))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label16.Text = intArray5(rnd.Next(0, 6))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label17.Text = intArray6(rnd.Next(0, 6))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label18.Text = intArray7(rnd.Next(0, 6))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label19.Text = intArray8(rnd.Next(0, 4))
    End Sub
End Class
