'Jaden Torres'
'Assignment P3'
'Sources: Assignment A5'


Imports System.Runtime.InteropServices.Marshalling
Imports Microsoft.VisualBasic.Devices

Public Class Form1


    Dim strInput As String 'gather input'
    Dim intInput As Integer 'gather input into int'
    Dim CheesePrice As Decimal = 49.99 'price of cheese'
    Dim PinwheelPrice As Decimal = 59.99 ' price of pinwheel'
    Dim VeggiePrice As Decimal = 29.99 'price of veggie' 
    Dim SausagePrice As Decimal = 49.99 'price of sausage'
    Dim FruitPrice As Decimal = 29.99 'price of fruit'
    Dim CTool As Decimal 'used to calculate cheese cater'
    Dim PTool As Decimal 'used to calculate pinwheel cater'
    Dim VTool As Decimal 'used to calculate veggie cater'
    Dim STool As Decimal 'used to calculate sausage cater'
    Dim FTool As Decimal 'used to calculate fruit cater'
    Dim temp As Decimal 'temp for intInput'
    Dim Wtemp As Decimal 'temp used for while loop'
    Dim discount As Decimal 'discount percentage after while loop'
    Dim subanswer As Decimal 'subanswer calculated from cater calculation'
    Dim payoption As Decimal 'option chosen from pre pay or in person'
    Dim item As String 'Item name of the cater type'
    Dim proc As Decimal 'This tells which button has been checked.'
    Dim counter As Decimal = 1 'not needed anymore'
    Dim finalanswer As Decimal 'final answer to be submitted to toString()'

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Loads form'
        Input.ResetText() 'resets loyalty input'
        Answer.ResetText() 'resets answer'
        Ignore.PerformClick() 'clicks ignore button'
        Ignore.Hide() 'hides ignore button'
        Ignore2.PerformClick() 'clicks ignore 2 button'
        Ignore2.Hide() 'hides ignore2 button'

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click 'what happens when calculate button is pressed'
        strInput = Input.Text 'sets strInput as the input text'
        If Integer.TryParse(strInput, intInput) = False Then 'If the input is numeric'
            MsgBox("error: Please input a whole number")
            Input.ResetText()
            Answer.ResetText()
        Else
            temp = 0 'temp is reset'
            temp = intInput 'temp used as another variable to hold the input '
            If temp < 10 Then 'check if the loyalty points is less that 10, the initial trigger for automatic 5% off'
                MsgBox("Insignificant loyalty points. Proceeding with checkout.")
            End If
            Compute() 'calls compute sub class'
        End If
    End Sub

    Private Sub Compute() 'This computes and sends the answer'
        discount = 0 'resets discount'
        Wtemp = 0 'resets Wtemp'
        If temp >= 10 Then 'checks again if the loyalty points is less that 10, the actual trigger for automatic 5% off'
            discount = 0
            Wtemp = 0
            Wtemp = Math.Round(temp / 10) 'divides temp by 10'
            While Wtemp > 0
                discount = discount + 0.05 'subtracts Wtemp by one until all rewards points divided by ten is added up'
                Wtemp = Wtemp - 1
            End While
        End If

        If proc = 1 Then 'if option is cheese'
            subanswer = 0
            CTool = 0
            CTool = Math.Round(CheesePrice * discount, 2)
            subanswer = CheesePrice - CTool
        Else
            If proc = 2 Then 'if option is pinwheel'
                subanswer = 0
                PTool = 0
                PTool = Math.Round(PinwheelPrice * discount, 2)
                subanswer = PinwheelPrice - PTool
            Else
                If proc = 3 Then 'if option is veggie'
                    subanswer = 0
                    VTool = 0
                    VTool = Math.Round(VeggiePrice * discount, 2)
                    subanswer = VeggiePrice - VTool
                Else
                    If proc = 4 Then 'if option is sausage'
                        subanswer = 0
                        STool = 0
                        STool = Math.Round(SausagePrice * discount, 2)
                        subanswer = SausagePrice - STool
                    Else
                        If proc = 5 Then 'if option is fruit'
                            subanswer = 0
                            FTool = 0
                            FTool = Math.Round(FruitPrice * discount, 2)
                            subanswer = FruitPrice - FTool
                        End If
                    End If
                End If
            End If
        End If
        Stat_Output()
    End Sub

    Private Sub Stat_Output() 'this takes the answer and formats into a output'
        If payoption = 1 Then 'if Pre-Pay is used'
            finalanswer = 0
            finalanswer = subanswer
            If finalanswer < 0 Then
                finalanswer = 0
            End If
            Answer.Text = "Your order of " + item.ToString() + " costs $" + finalanswer.ToString() + " using Pre-Pay after discount of " + temp.ToString() + " loyalty points." 'total output line'
        Else
            If payoption = 2 Then 'if Pay upon pickup is used'
                finalanswer = 0
                finalanswer = subanswer
                If finalanswer < 0 Then
                    finalanswer = 0
                End If
                Answer.Text = "Your order of " + item.ToString() + " costs $" + finalanswer.ToString() + " using Pay upon Pickup after discount of " + temp.ToString() + " loyalty points." 'total output line'
            End If
        End If

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click 'When clear button is pressed'
        Input.ResetText()
        Answer.ResetText()
        Ignore.Show()
        Ignore2.Show()
        Ignore.PerformClick()
        Ignore2.PerformClick()
        Ignore.Hide()
        Ignore2.Hide()
    End Sub

    Private Sub Cheese_CheckedChanged(sender As Object, e As EventArgs) Handles Cheese.CheckedChanged 'checks if cheese button has been pressed'
        proc = 1
        item = "Gourmet Cheese"
    End Sub

    Private Sub Pinwheel_CheckedChanged(sender As Object, e As EventArgs) Handles Pinwheel.CheckedChanged 'checks if pinwheel button has been pressed'
        proc = 2
        item = "Pinwheel Wraps"
    End Sub

    Private Sub Veggie_CheckedChanged(sender As Object, e As EventArgs) Handles Veggie.CheckedChanged 'checks if veggie button has been pressed'
        proc = 3
        item = "Veggie"
    End Sub

    Private Sub SausagenCheese_CheckedChanged(sender As Object, e As EventArgs) Handles SausagenCheese.CheckedChanged 'checks if sausage button has been pressed'
        proc = 4
        item = "Sausage and Cheese"
    End Sub

    Private Sub Fruit_CheckedChanged(sender As Object, e As EventArgs) Handles Fruit.CheckedChanged 'checks if fruit button has been pressed'
        proc = 5
        item = "Fruit"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged 'checks if pre-pay has been pressed'
        payoption = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged 'checks if pay upon pickup has been pressed'
        payoption = 2
    End Sub
End Class

