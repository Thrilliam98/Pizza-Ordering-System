<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkStarter = New System.Windows.Forms.CheckBox()
        Me.ChkMainMenu = New System.Windows.Forms.CheckBox()
        Me.ChkSweets = New System.Windows.Forms.CheckBox()
        Me.ChkDrinks = New System.Windows.Forms.CheckBox()
        Me.QuantityStarter = New System.Windows.Forms.NumericUpDown()
        Me.QuantityMainMenu = New System.Windows.Forms.NumericUpDown()
        Me.QuantitySweets = New System.Windows.Forms.NumericUpDown()
        Me.QuantityDrinks = New System.Windows.Forms.NumericUpDown()
        Me.btnAddStarter = New System.Windows.Forms.Button()
        Me.btnAddMainMenu = New System.Windows.Forms.Button()
        Me.btnAddSweets = New System.Windows.Forms.Button()
        Me.btnAddDrinks = New System.Windows.Forms.Button()
        Me.LstItem = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboDrinks = New System.Windows.Forms.ComboBox()
        Me.ComboSweets = New System.Windows.Forms.ComboBox()
        Me.ComboMainMenu = New System.Windows.Forms.ComboBox()
        Me.ComboStarter = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.LstCost = New System.Windows.Forms.ListBox()
        Me.LstQuantity = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider3 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider4 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider5 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider6 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider7 = New System.Windows.Forms.HelpProvider()
        CType(Me.QuantityStarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySweets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beach View"
        '
        'ChkStarter
        '
        Me.ChkStarter.AutoSize = True
        Me.ChkStarter.Location = New System.Drawing.Point(33, 101)
        Me.ChkStarter.Name = "ChkStarter"
        Me.ChkStarter.Size = New System.Drawing.Size(57, 17)
        Me.ChkStarter.TabIndex = 1
        Me.ChkStarter.Text = "Starter"
        Me.ChkStarter.UseVisualStyleBackColor = True
        '
        'ChkMainMenu
        '
        Me.ChkMainMenu.AutoSize = True
        Me.ChkMainMenu.Location = New System.Drawing.Point(33, 138)
        Me.ChkMainMenu.Name = "ChkMainMenu"
        Me.ChkMainMenu.Size = New System.Drawing.Size(79, 17)
        Me.ChkMainMenu.TabIndex = 2
        Me.ChkMainMenu.Text = "Main Menu"
        Me.ChkMainMenu.UseVisualStyleBackColor = True
        '
        'ChkSweets
        '
        Me.ChkSweets.AutoSize = True
        Me.ChkSweets.Location = New System.Drawing.Point(33, 176)
        Me.ChkSweets.Name = "ChkSweets"
        Me.ChkSweets.Size = New System.Drawing.Size(61, 17)
        Me.ChkSweets.TabIndex = 3
        Me.ChkSweets.Text = "Sweets"
        Me.ChkSweets.UseVisualStyleBackColor = True
        '
        'ChkDrinks
        '
        Me.ChkDrinks.AutoSize = True
        Me.ChkDrinks.Location = New System.Drawing.Point(33, 215)
        Me.ChkDrinks.Name = "ChkDrinks"
        Me.ChkDrinks.Size = New System.Drawing.Size(56, 17)
        Me.ChkDrinks.TabIndex = 4
        Me.ChkDrinks.Text = "Drinks"
        Me.ChkDrinks.UseVisualStyleBackColor = True
        '
        'QuantityStarter
        '
        Me.QuantityStarter.Location = New System.Drawing.Point(291, 16)
        Me.QuantityStarter.Name = "QuantityStarter"
        Me.QuantityStarter.Size = New System.Drawing.Size(81, 20)
        Me.QuantityStarter.TabIndex = 5
        '
        'QuantityMainMenu
        '
        Me.QuantityMainMenu.Location = New System.Drawing.Point(291, 55)
        Me.QuantityMainMenu.Name = "QuantityMainMenu"
        Me.QuantityMainMenu.Size = New System.Drawing.Size(81, 20)
        Me.QuantityMainMenu.TabIndex = 6
        '
        'QuantitySweets
        '
        Me.QuantitySweets.Location = New System.Drawing.Point(291, 93)
        Me.QuantitySweets.Name = "QuantitySweets"
        Me.QuantitySweets.Size = New System.Drawing.Size(81, 20)
        Me.QuantitySweets.TabIndex = 7
        '
        'QuantityDrinks
        '
        Me.QuantityDrinks.Location = New System.Drawing.Point(291, 132)
        Me.QuantityDrinks.Name = "QuantityDrinks"
        Me.QuantityDrinks.Size = New System.Drawing.Size(81, 20)
        Me.QuantityDrinks.TabIndex = 8
        '
        'btnAddStarter
        '
        Me.btnAddStarter.Location = New System.Drawing.Point(401, 95)
        Me.btnAddStarter.Name = "btnAddStarter"
        Me.btnAddStarter.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStarter.TabIndex = 9
        Me.btnAddStarter.Text = "Add"
        Me.btnAddStarter.UseVisualStyleBackColor = True
        '
        'btnAddMainMenu
        '
        Me.btnAddMainMenu.Location = New System.Drawing.Point(401, 134)
        Me.btnAddMainMenu.Name = "btnAddMainMenu"
        Me.btnAddMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMainMenu.TabIndex = 10
        Me.btnAddMainMenu.Text = "Add"
        Me.btnAddMainMenu.UseVisualStyleBackColor = True
        '
        'btnAddSweets
        '
        Me.btnAddSweets.Location = New System.Drawing.Point(401, 173)
        Me.btnAddSweets.Name = "btnAddSweets"
        Me.btnAddSweets.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSweets.TabIndex = 11
        Me.btnAddSweets.Text = "Add"
        Me.btnAddSweets.UseVisualStyleBackColor = True
        '
        'btnAddDrinks
        '
        Me.btnAddDrinks.Location = New System.Drawing.Point(401, 211)
        Me.btnAddDrinks.Name = "btnAddDrinks"
        Me.btnAddDrinks.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDrinks.TabIndex = 12
        Me.btnAddDrinks.Text = "Add"
        Me.btnAddDrinks.UseVisualStyleBackColor = True
        '
        'LstItem
        '
        Me.LstItem.FormattingEnabled = True
        Me.LstItem.Location = New System.Drawing.Point(30, 67)
        Me.LstItem.Name = "LstItem"
        Me.LstItem.Size = New System.Drawing.Size(124, 173)
        Me.LstItem.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(73, 261)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Label4"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(242, 256)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(343, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(82, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Item:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(234, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(385, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cost:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.ComboDrinks)
        Me.Panel1.Controls.Add(Me.ComboSweets)
        Me.Panel1.Controls.Add(Me.ComboMainMenu)
        Me.Panel1.Controls.Add(Me.ComboStarter)
        Me.Panel1.Controls.Add(Me.QuantityStarter)
        Me.Panel1.Controls.Add(Me.QuantityMainMenu)
        Me.Panel1.Controls.Add(Me.QuantitySweets)
        Me.Panel1.Controls.Add(Me.QuantityDrinks)
        Me.Panel1.Location = New System.Drawing.Point(13, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 162)
        Me.Panel1.TabIndex = 22
        '
        'ComboDrinks
        '
        Me.ComboDrinks.FormattingEnabled = True
        Me.ComboDrinks.Items.AddRange(New Object() {"Coca Cola", "Diet Coca Cola", "Coca Cola Zero", "Dr Pepper Zero", "Fanta", "Lemonade"})
        Me.ComboDrinks.Location = New System.Drawing.Point(135, 133)
        Me.ComboDrinks.Name = "ComboDrinks"
        Me.ComboDrinks.Size = New System.Drawing.Size(121, 21)
        Me.ComboDrinks.TabIndex = 12
        '
        'ComboSweets
        '
        Me.ComboSweets.FormattingEnabled = True
        Me.ComboSweets.Items.AddRange(New Object() {"Chocolate Fudge Cake", "Brownies and Ice Cream", "Sticky Toffee Pudding", "Warm Apple Pie", "3 Scoops of Ice Cream", "Fruit Salad"})
        Me.ComboSweets.Location = New System.Drawing.Point(135, 94)
        Me.ComboSweets.Name = "ComboSweets"
        Me.ComboSweets.Size = New System.Drawing.Size(121, 21)
        Me.ComboSweets.TabIndex = 11
        '
        'ComboMainMenu
        '
        Me.ComboMainMenu.FormattingEnabled = True
        Me.ComboMainMenu.Items.AddRange(New Object() {"Pepperoni Pizza", "BBQ Chicken Pizza", "Spaghetti and Meatballs", "Classic Beef Lasagne", "Classic Beef Burger", "Classic Cheese Burger", "New York BBQ Chicken", "Steak and Fries"})
        Me.ComboMainMenu.Location = New System.Drawing.Point(135, 56)
        Me.ComboMainMenu.Name = "ComboMainMenu"
        Me.ComboMainMenu.Size = New System.Drawing.Size(121, 21)
        Me.ComboMainMenu.TabIndex = 10
        '
        'ComboStarter
        '
        Me.ComboStarter.FormattingEnabled = True
        Me.ComboStarter.Items.AddRange(New Object() {"Garlic Bread", "Dough Balls", "Olives", "Chicken Wings", "Mozzarella Sticks", "Chicken Fingers"})
        Me.ComboStarter.Location = New System.Drawing.Point(135, 15)
        Me.ComboStarter.Name = "ComboStarter"
        Me.ComboStarter.Size = New System.Drawing.Size(121, 21)
        Me.ComboStarter.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.LstCost)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LstQuantity)
        Me.Panel2.Controls.Add(Me.btnCalculate)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.LstItem)
        Me.Panel2.Location = New System.Drawing.Point(13, 268)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 325)
        Me.Panel2.TabIndex = 23
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(195, 285)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Quit"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'LstCost
        '
        Me.LstCost.FormattingEnabled = True
        Me.LstCost.Location = New System.Drawing.Point(343, 67)
        Me.LstCost.Name = "LstCost"
        Me.LstCost.Size = New System.Drawing.Size(120, 173)
        Me.LstCost.TabIndex = 21
        '
        'LstQuantity
        '
        Me.LstQuantity.FormattingEnabled = True
        Me.LstQuantity.Location = New System.Drawing.Point(184, 67)
        Me.LstQuantity.Name = "LstQuantity"
        Me.LstQuantity.Size = New System.Drawing.Size(120, 173)
        Me.LstQuantity.TabIndex = 20
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(135, 256)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 605)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddDrinks)
        Me.Controls.Add(Me.btnAddSweets)
        Me.Controls.Add(Me.btnAddMainMenu)
        Me.Controls.Add(Me.btnAddStarter)
        Me.Controls.Add(Me.ChkDrinks)
        Me.Controls.Add(Me.ChkSweets)
        Me.Controls.Add(Me.ChkMainMenu)
        Me.Controls.Add(Me.ChkStarter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.QuantityStarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySweets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ChkStarter As CheckBox
    Friend WithEvents ChkMainMenu As CheckBox
    Friend WithEvents ChkSweets As CheckBox
    Friend WithEvents ChkDrinks As CheckBox
    Friend WithEvents QuantityStarter As NumericUpDown
    Friend WithEvents QuantityMainMenu As NumericUpDown
    Friend WithEvents QuantitySweets As NumericUpDown
    Friend WithEvents QuantityDrinks As NumericUpDown
    Friend WithEvents btnAddStarter As Button
    Friend WithEvents btnAddMainMenu As Button
    Friend WithEvents btnAddSweets As Button
    Friend WithEvents btnAddDrinks As Button
    Friend WithEvents LstItem As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboDrinks As ComboBox
    Friend WithEvents ComboSweets As ComboBox
    Friend WithEvents ComboMainMenu As ComboBox
    Friend WithEvents ComboStarter As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents LstCost As ListBox
    Friend WithEvents LstQuantity As ListBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents HelpProvider2 As HelpProvider
    Friend WithEvents HelpProvider3 As HelpProvider
    Friend WithEvents HelpProvider4 As HelpProvider
    Friend WithEvents HelpProvider5 As HelpProvider
    Friend WithEvents HelpProvider6 As HelpProvider
    Friend WithEvents HelpProvider7 As HelpProvider
    Friend WithEvents Button8 As Button
End Class
