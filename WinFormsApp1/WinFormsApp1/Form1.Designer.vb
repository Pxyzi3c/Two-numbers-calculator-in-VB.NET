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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.Teal
        Me.btnAdd.Location = New System.Drawing.Point(51, 239)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 60)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSubtract
        '
        Me.btnSubtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubtract.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.ForeColor = System.Drawing.Color.Teal
        Me.btnSubtract.Location = New System.Drawing.Point(51, 305)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(62, 60)
        Me.btnSubtract.TabIndex = 1
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiply.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.ForeColor = System.Drawing.Color.Teal
        Me.btnMultiply.Location = New System.Drawing.Point(119, 239)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(62, 60)
        Me.btnMultiply.TabIndex = 2
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDivide.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.ForeColor = System.Drawing.Color.Teal
        Me.btnDivide.Location = New System.Drawing.Point(119, 305)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(62, 60)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.BackColor = System.Drawing.Color.Teal
        Me.txtFirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstNumber.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirstNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFirstNumber.Location = New System.Drawing.Point(50, 77)
        Me.txtFirstNumber.Multiline = True
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(130, 60)
        Me.txtFirstNumber.TabIndex = 4
        Me.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.BackColor = System.Drawing.Color.Teal
        Me.txtSecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSecondNumber.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSecondNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSecondNumber.Location = New System.Drawing.Point(228, 77)
        Me.txtSecondNumber.Multiline = True
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(130, 60)
        Me.txtSecondNumber.TabIndex = 5
        Me.txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.Teal
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResult.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtResult.Location = New System.Drawing.Point(119, 160)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(239, 60)
        Me.txtResult.TabIndex = 6
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.BackColor = System.Drawing.Color.Transparent
        Me.lblCalculation.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalculation.ForeColor = System.Drawing.Color.Teal
        Me.lblCalculation.Location = New System.Drawing.Point(29, 9)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(351, 30)
        Me.lblCalculation.TabIndex = 7
        Me.lblCalculation.Text = "Calculation of Two Numbers"
        Me.lblCalculation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.BackColor = System.Drawing.Color.Transparent
        Me.lblSymbol.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSymbol.ForeColor = System.Drawing.Color.Transparent
        Me.lblSymbol.Location = New System.Drawing.Point(186, 86)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(39, 42)
        Me.lblSymbol.TabIndex = 8
        Me.lblSymbol.Text = "?"
        Me.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.BackColor = System.Drawing.Color.Transparent
        Me.lblEqual.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEqual.ForeColor = System.Drawing.Color.Transparent
        Me.lblEqual.Location = New System.Drawing.Point(62, 169)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(39, 42)
        Me.lblEqual.TabIndex = 9
        Me.lblEqual.Text = "="
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(187, 239)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(171, 60)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(187, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 60)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstNumber.ForeColor = System.Drawing.Color.DimGray
        Me.lblFirstNumber.Location = New System.Drawing.Point(104, 57)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(81, 17)
        Me.lblFirstNumber.TabIndex = 12
        Me.lblFirstNumber.Text = "First Number"
        Me.lblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(259, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Second Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(319, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.LabExercise1.My.Resources.Resources.ranger_4df6c1b61
        Me.ClientSize = New System.Drawing.Size(409, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Name = "Form1"
        Me.Text = "HARVY JONES PONTILLAS (DICT22)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblSymbol As Label
    Friend WithEvents lblEqual As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
