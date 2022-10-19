Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddStarter.Click
        Dim Starter As String
        Dim Cost As Single
        Starter = ComboStarter.SelectedItem
        Select Case Starter
            Case "Garlic Bread"
                Cost = 3.99
            Case "Dough Balls"
                Cost = 4.49
            Case "Olives"
                Cost = 2.99
            Case "Chicken Wings"
                Cost = 5.99
            Case "Mozzarella Sticks"
                Cost = 4.99
            Case "Chicken Fingers"
                Cost = 5.99
        End Select
        If ChkStarter.Checked = True Then
            Cost = Cost * QuantityStarter.Value
            LstItem.Items.Add(Starter & ControlChars.CrLf)
            LstQuantity.Items.Add(QuantityStarter.Value & ControlChars.CrLf)
            LstCost.Items.Add(FormatCurrency(Cost) & ControlChars.CrLf)
        End If
        ChkStarter.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddMainMenu.Click
        Dim MainMenu As String
        Dim Cost As Single
        MainMenu = ComboMainMenu.SelectedItem
        Select Case MainMenu
            Case "Pepperoni Pizza"
                Cost = 9.99
            Case "BBQ Chicken Pizza"
                Cost = 9.99
            Case "Spaghetti and Meatballs"
                Cost = 12.99
            Case "Classic Beef Lasagne"
                Cost = 9.79
            Case "Classic Beef Burger"
                Cost = 8.99
            Case "Classic Cheese Burger"
                Cost = 9.99
            Case "New York BBQ Chicken"
                Cost = 13.99
            Case "Steak and Fries"
                Cost = 12.99
        End Select
        If ChkMainMenu.Checked = True Then
            Cost = Cost * QuantityMainMenu.Value
            LstItem.Items.Add(MainMenu & ControlChars.CrLf)
            LstQuantity.Items.Add(QuantityMainMenu.Value & ControlChars.CrLf)
            LstCost.Items.Add(FormatCurrency(Cost) & ControlChars.CrLf)
        End If
        ChkMainMenu.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddSweets.Click
        Dim Sweets As String
        Dim Cost As Single
        Sweets = ComboSweets.SelectedItem
        Select Case Sweets
            Case "Chocolate Fudge Cake"
                Cost = 5.49
            Case "Brownies and Ice Cream"
                Cost = 5.59
            Case "Sticky Toffee Pudding"
                Cost = 5.99
            Case "Warm Apple Pie"
                Cost = 5.49
            Case "3 Scoops of Ice Cream"
                Cost = 3.49
            Case "Fruit Salad"
                Cost = 3.49
        End Select
        If ChkSweets.Checked = True Then
            Cost = Cost * QuantitySweets.Value
            LstItem.Items.Add(Sweets & ControlChars.CrLf)
            LstQuantity.Items.Add(QuantitySweets.Value & ControlChars.CrLf)
            LstCost.Items.Add(FormatCurrency(Cost) & ControlChars.CrLf)
        End If
        ChkSweets.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddDrinks.Click
        Dim Drinks As String
        Dim Cost As Single
        Drinks = ComboDrinks.SelectedItem
        Select Case Drinks
            Case "Coca Cola"
                Cost = 2.99
            Case "Diet Coca Cola"
                Cost = 2.79
            Case "Coca Cola Zero"
                Cost = 2.79
            Case "Dr Pepper Zero"
                Cost = 2.79
            Case "Fanta"
                Cost = 2.79
            Case "Lemonade"
                Cost = 2.79
        End Select
        If ChkDrinks.Checked = True Then
            Cost = Cost * QuantityDrinks.Value
            LstItem.Items.Add(Drinks & ControlChars.CrLf)
            LstQuantity.Items.Add(QuantityDrinks.Value & ControlChars.CrLf)
            LstCost.Items.Add(FormatCurrency(Cost) & ControlChars.CrLf)
        End If
        ChkDrinks.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LstItem.Items.Remove(LstItem.SelectedItem)
        LstQuantity.Items.Remove(LstQuantity.SelectedItem)
        LstCost.Items.Remove(LstCost.SelectedItem)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        LstItem.Items.Clear()
        LstQuantity.Items.Clear()
        LstCost.Items.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Total As Single
        Dim Cost As Single
        For Each Cost In LstCost.Items
            Total += Cost
        Next Cost
        lblTotal.Text = FormatCurrency(Total)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpProvider1.SetHelpString(btnDelete, "Select Item, Quantity and Cost to Delete Order.")
        HelpProvider2.SetHelpString(btnClear, "Press the Clear Button to delete everything on the order.")
        HelpProvider3.SetHelpString(btnCalculate, "Press the Calculate Button to add up the prices in the Cost List Box Together.")
        HelpProvider4.SetHelpString(btnAddStarter, "Make sure that the Check Box has been checked, an item has been selected from the Combo Box and the Quantity has been choosen.")
        HelpProvider5.SetHelpString(btnAddMainMenu, "Make sure that the Check Box has been checked, an item has been selected from the Combo Box and the Quantity has been choosen.")
        HelpProvider6.SetHelpString(btnAddSweets, "Make sure that the Check Box has been checked, an item has been selected from the Combo Box and the Quantity has been choosen.")
        HelpProvider7.SetHelpString(btnAddDrinks, "Make sure that the Check Box has been checked, an item has been selected from the Combo Box and the Quantity has been choosen.")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
