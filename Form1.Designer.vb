<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Cheese = New RadioButton()
        Pinwheel = New RadioButton()
        Veggie = New RadioButton()
        SausagenCheese = New RadioButton()
        Fruit = New RadioButton()
        GroupBox1 = New GroupBox()
        Ignore = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox2 = New GroupBox()
        Ignore2 = New RadioButton()
        Label3 = New Label()
        Label4 = New Label()
        Input = New TextBox()
        Calculate = New Button()
        Clear = New Button()
        Answer = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(737, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(558, 358)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(79, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 106)
        Label1.TabIndex = 1
        Label1.Text = "Catering"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(136, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(253, 49)
        Label2.TabIndex = 2
        Label2.Text = "Star Market"
        ' 
        ' Cheese
        ' 
        Cheese.AutoSize = True
        Cheese.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cheese.Location = New Point(34, 62)
        Cheese.Name = "Cheese"
        Cheese.Size = New Size(254, 26)
        Cheese.TabIndex = 3
        Cheese.TabStop = True
        Cheese.Text = "Gourmet Cheese $49.99"
        Cheese.UseVisualStyleBackColor = True
        ' 
        ' Pinwheel
        ' 
        Pinwheel.AutoSize = True
        Pinwheel.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Pinwheel.Location = New Point(34, 107)
        Pinwheel.Name = "Pinwheel"
        Pinwheel.Size = New Size(249, 26)
        Pinwheel.TabIndex = 4
        Pinwheel.TabStop = True
        Pinwheel.Text = "Pinwheel Wraps $59.99"
        Pinwheel.UseVisualStyleBackColor = True
        ' 
        ' Veggie
        ' 
        Veggie.AutoSize = True
        Veggie.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Veggie.Location = New Point(34, 155)
        Veggie.Name = "Veggie"
        Veggie.Size = New Size(169, 26)
        Veggie.TabIndex = 5
        Veggie.TabStop = True
        Veggie.Text = "Veggie $29.99"
        Veggie.UseVisualStyleBackColor = True
        ' 
        ' SausagenCheese
        ' 
        SausagenCheese.AutoSize = True
        SausagenCheese.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SausagenCheese.Location = New Point(34, 202)
        SausagenCheese.Name = "SausagenCheese"
        SausagenCheese.Size = New Size(291, 26)
        SausagenCheese.TabIndex = 6
        SausagenCheese.TabStop = True
        SausagenCheese.Text = "Sausage and Cheese $49.99"
        SausagenCheese.UseVisualStyleBackColor = True
        ' 
        ' Fruit
        ' 
        Fruit.AutoSize = True
        Fruit.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fruit.Location = New Point(34, 248)
        Fruit.Name = "Fruit"
        Fruit.Size = New Size(143, 26)
        Fruit.TabIndex = 7
        Fruit.TabStop = True
        Fruit.Text = "Fruit $29.99"
        Fruit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Ignore)
        GroupBox1.Controls.Add(Fruit)
        GroupBox1.Controls.Add(SausagenCheese)
        GroupBox1.Controls.Add(Veggie)
        GroupBox1.Controls.Add(Pinwheel)
        GroupBox1.Controls.Add(Cheese)
        GroupBox1.Location = New Point(79, 247)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(417, 324)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Ignore
        ' 
        Ignore.AutoSize = True
        Ignore.Location = New Point(179, 280)
        Ignore.Name = "Ignore"
        Ignore.Size = New Size(89, 29)
        Ignore.TabIndex = 9
        Ignore.TabStop = True
        Ignore.Text = "Ignore"
        Ignore.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(84, 70)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(105, 26)
        RadioButton1.TabIndex = 9
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pre-Pay"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(84, 117)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(186, 26)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "Pay upon Pickup"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Ignore2)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(79, 678)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(394, 170)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Ignore2
        ' 
        Ignore2.AutoSize = True
        Ignore2.Location = New Point(215, 67)
        Ignore2.Name = "Ignore2"
        Ignore2.Size = New Size(99, 29)
        Ignore2.TabIndex = 13
        Ignore2.TabStop = True
        Ignore2.Text = "Ignore2"
        Ignore2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(79, 932)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 49)
        Label3.TabIndex = 12
        Label3.Text = "Please Pay:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(737, 547)
        Label4.Name = "Label4"
        Label4.Size = New Size(249, 41)
        Label4.TabIndex = 13
        Label4.Text = "Loyalty Points"
        ' 
        ' Input
        ' 
        Input.Location = New Point(992, 547)
        Input.Name = "Input"
        Input.Size = New Size(129, 31)
        Input.TabIndex = 14
        ' 
        ' Calculate
        ' 
        Calculate.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Calculate.Location = New Point(675, 687)
        Calculate.Name = "Calculate"
        Calculate.Size = New Size(217, 65)
        Calculate.TabIndex = 15
        Calculate.Text = "Calculate"
        Calculate.UseVisualStyleBackColor = True
        ' 
        ' Clear
        ' 
        Clear.Font = New Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Clear.Location = New Point(992, 687)
        Clear.Name = "Clear"
        Clear.Size = New Size(217, 65)
        Clear.TabIndex = 16
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Answer
        ' 
        Answer.Font = New Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Answer.Location = New Point(334, 914)
        Answer.Name = "Answer"
        Answer.Size = New Size(961, 91)
        Answer.TabIndex = 17
        Answer.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1356, 1041)
        Controls.Add(Answer)
        Controls.Add(Clear)
        Controls.Add(Calculate)
        Controls.Add(Input)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cheese As RadioButton
    Friend WithEvents Pinwheel As RadioButton
    Friend WithEvents Veggie As RadioButton
    Friend WithEvents SausagenCheese As RadioButton
    Friend WithEvents Fruit As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ignore As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Ignore2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Input As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Answer As GroupBox

End Class
