<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStaff
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
        Me.TxtStaffID = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtMobileNumber = New System.Windows.Forms.TextBox()
        Me.LblMobileNumber = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.LblCity = New System.Windows.Forms.Label()
        Me.TxtPinCode = New System.Windows.Forms.TextBox()
        Me.LblPinCode = New System.Windows.Forms.Label()
        Me.TxtState = New System.Windows.Forms.TextBox()
        Me.LblState = New System.Windows.Forms.Label()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtStaffID
        '
        Me.TxtStaffID.Location = New System.Drawing.Point(78, 12)
        Me.TxtStaffID.Name = "TxtStaffID"
        Me.TxtStaffID.Size = New System.Drawing.Size(100, 20)
        Me.TxtStaffID.TabIndex = 3
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(11, 15)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(18, 13)
        Me.LblID.TabIndex = 2
        Me.LblID.Text = "ID"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(78, 38)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstName.TabIndex = 5
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(11, 41)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LblFirstName.TabIndex = 4
        Me.LblFirstName.Text = "First Name"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(78, 64)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(100, 20)
        Me.TxtLastName.TabIndex = 7
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Location = New System.Drawing.Point(11, 67)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(58, 13)
        Me.LblLastName.TabIndex = 6
        Me.LblLastName.Text = "Last Name"
        '
        'TxtMobileNumber
        '
        Me.TxtMobileNumber.Location = New System.Drawing.Point(78, 90)
        Me.TxtMobileNumber.Name = "TxtMobileNumber"
        Me.TxtMobileNumber.Size = New System.Drawing.Size(100, 20)
        Me.TxtMobileNumber.TabIndex = 9
        '
        'LblMobileNumber
        '
        Me.LblMobileNumber.AutoSize = True
        Me.LblMobileNumber.Location = New System.Drawing.Point(11, 93)
        Me.LblMobileNumber.Name = "LblMobileNumber"
        Me.LblMobileNumber.Size = New System.Drawing.Size(78, 13)
        Me.LblMobileNumber.TabIndex = 8
        Me.LblMobileNumber.Text = "Mobile Number"
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(78, 116)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(100, 20)
        Me.TxtCity.TabIndex = 11
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.Location = New System.Drawing.Point(11, 119)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(24, 13)
        Me.LblCity.TabIndex = 10
        Me.LblCity.Text = "City"
        '
        'TxtPinCode
        '
        Me.TxtPinCode.Location = New System.Drawing.Point(78, 142)
        Me.TxtPinCode.Name = "TxtPinCode"
        Me.TxtPinCode.Size = New System.Drawing.Size(100, 20)
        Me.TxtPinCode.TabIndex = 13
        '
        'LblPinCode
        '
        Me.LblPinCode.AutoSize = True
        Me.LblPinCode.Location = New System.Drawing.Point(11, 145)
        Me.LblPinCode.Name = "LblPinCode"
        Me.LblPinCode.Size = New System.Drawing.Size(50, 13)
        Me.LblPinCode.TabIndex = 12
        Me.LblPinCode.Text = "Pin Code"
        '
        'TxtState
        '
        Me.TxtState.Location = New System.Drawing.Point(78, 168)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(100, 20)
        Me.TxtState.TabIndex = 15
        '
        'LblState
        '
        Me.LblState.AutoSize = True
        Me.LblState.Location = New System.Drawing.Point(11, 171)
        Me.LblState.Name = "LblState"
        Me.LblState.Size = New System.Drawing.Size(32, 13)
        Me.LblState.TabIndex = 14
        Me.LblState.Text = "State"
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(78, 194)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(100, 20)
        Me.TxtArea.TabIndex = 17
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Location = New System.Drawing.Point(11, 197)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(29, 13)
        Me.LblArea.TabIndex = 16
        Me.LblArea.Text = "Area"
        '
        'FrmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtArea)
        Me.Controls.Add(Me.LblArea)
        Me.Controls.Add(Me.TxtState)
        Me.Controls.Add(Me.LblState)
        Me.Controls.Add(Me.TxtPinCode)
        Me.Controls.Add(Me.LblPinCode)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(Me.LblCity)
        Me.Controls.Add(Me.TxtMobileNumber)
        Me.Controls.Add(Me.LblMobileNumber)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.LblLastName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.LblFirstName)
        Me.Controls.Add(Me.TxtStaffID)
        Me.Controls.Add(Me.LblID)
        Me.Name = "FrmStaff"
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtStaffID As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents LblFirstName As Label
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents LblLastName As Label
    Friend WithEvents TxtMobileNumber As TextBox
    Friend WithEvents LblMobileNumber As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents LblCity As Label
    Friend WithEvents TxtPinCode As TextBox
    Friend WithEvents LblPinCode As Label
    Friend WithEvents TxtState As TextBox
    Friend WithEvents LblState As Label
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents LblArea As Label
End Class
