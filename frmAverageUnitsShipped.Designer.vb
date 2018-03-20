<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbAnswer = New System.Windows.Forms.Label()
        Me.tbList = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbAnswer2 = New System.Windows.Forms.Label()
        Me.tbList2 = New System.Windows.Forms.TextBox()
        Me.lbAnswer3 = New System.Windows.Forms.Label()
        Me.tbList3 = New System.Windows.Forms.TextBox()
        Me.lbAnswerTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(41, 55)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(31, 13)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "&Units"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(86, 55)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.ShortcutsEnabled = False
        Me.tbUnits.Size = New System.Drawing.Size(100, 20)
        Me.tbUnits.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbUnits, "Enter information here")
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Location = New System.Drawing.Point(41, 23)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(38, 13)
        Me.lbDay.TabIndex = 2
        Me.lbDay.Text = "Day: 0"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(111, 269)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enter Number Into Calculation")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(192, 269)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset Program ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(273, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbAnswer
        '
        Me.lbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAnswer.Location = New System.Drawing.Point(38, 200)
        Me.lbAnswer.Name = "lbAnswer"
        Me.lbAnswer.Size = New System.Drawing.Size(123, 27)
        Me.lbAnswer.TabIndex = 6
        Me.lbAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbAnswer, "Answer Box")
        '
        'tbList
        '
        Me.tbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbList.Location = New System.Drawing.Point(38, 94)
        Me.tbList.Multiline = True
        Me.tbList.Name = "tbList"
        Me.tbList.Size = New System.Drawing.Size(123, 103)
        Me.tbList.TabIndex = 80
        Me.tbList.TabStop = False
        Me.ToolTip1.SetToolTip(Me.tbList, "List of Entrys ")
        '
        'lbAnswer2
        '
        Me.lbAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAnswer2.Location = New System.Drawing.Point(167, 200)
        Me.lbAnswer2.Name = "lbAnswer2"
        Me.lbAnswer2.Size = New System.Drawing.Size(123, 27)
        Me.lbAnswer2.TabIndex = 6
        Me.lbAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbList2
        '
        Me.tbList2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbList2.Location = New System.Drawing.Point(167, 94)
        Me.tbList2.Multiline = True
        Me.tbList2.Name = "tbList2"
        Me.tbList2.Size = New System.Drawing.Size(123, 103)
        Me.tbList2.TabIndex = 80
        Me.tbList2.TabStop = False
        '
        'lbAnswer3
        '
        Me.lbAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAnswer3.Location = New System.Drawing.Point(301, 200)
        Me.lbAnswer3.Name = "lbAnswer3"
        Me.lbAnswer3.Size = New System.Drawing.Size(123, 27)
        Me.lbAnswer3.TabIndex = 6
        Me.lbAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbList3
        '
        Me.tbList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbList3.Location = New System.Drawing.Point(301, 94)
        Me.tbList3.Multiline = True
        Me.tbList3.Name = "tbList3"
        Me.tbList3.Size = New System.Drawing.Size(123, 103)
        Me.tbList3.TabIndex = 80
        Me.tbList3.TabStop = False
        '
        'lbAnswerTotal
        '
        Me.lbAnswerTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAnswerTotal.Location = New System.Drawing.Point(38, 239)
        Me.lbAnswerTotal.Name = "lbAnswerTotal"
        Me.lbAnswerTotal.Size = New System.Drawing.Size(386, 27)
        Me.lbAnswerTotal.TabIndex = 6
        Me.lbAnswerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(452, 304)
        Me.Controls.Add(Me.tbList3)
        Me.Controls.Add(Me.lbAnswer3)
        Me.Controls.Add(Me.tbList2)
        Me.Controls.Add(Me.lbAnswerTotal)
        Me.Controls.Add(Me.lbAnswer2)
        Me.Controls.Add(Me.tbList)
        Me.Controls.Add(Me.lbAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents lbDay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbAnswer As Label
    Friend WithEvents tbList As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbAnswer2 As Label
    Friend WithEvents tbList2 As TextBox
    Friend WithEvents lbAnswer3 As Label
    Friend WithEvents tbList3 As TextBox
    Friend WithEvents lbAnswerTotal As Label
End Class
