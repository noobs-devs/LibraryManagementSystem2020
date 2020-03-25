<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBook
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
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtEdition = New System.Windows.Forms.TextBox()
        Me.LblEdition = New System.Windows.Forms.Label()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.TxtCompensationPrice = New System.Windows.Forms.TextBox()
        Me.LblCompensationPrice = New System.Windows.Forms.Label()
        Me.TxtBookType = New System.Windows.Forms.TextBox()
        Me.LblBookType = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(446, 437)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 3
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(400, 440)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 2
        Me.LblId.Text = "ID"
        '
        'TxtTitle
        '
        Me.TxtTitle.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTitle.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtTitle.Location = New System.Drawing.Point(293, 75)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(263, 31)
        Me.TxtTitle.TabIndex = 5
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblTitle.Location = New System.Drawing.Point(165, 78)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(115, 28)
        Me.LblTitle.TabIndex = 4
        Me.LblTitle.Text = "Book Title"
        '
        'TxtEdition
        '
        Me.TxtEdition.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEdition.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtEdition.Location = New System.Drawing.Point(293, 115)
        Me.TxtEdition.Name = "TxtEdition"
        Me.TxtEdition.Size = New System.Drawing.Size(263, 31)
        Me.TxtEdition.TabIndex = 7
        '
        'LblEdition
        '
        Me.LblEdition.AutoSize = True
        Me.LblEdition.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdition.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblEdition.Location = New System.Drawing.Point(193, 118)
        Me.LblEdition.Name = "LblEdition"
        Me.LblEdition.Size = New System.Drawing.Size(87, 28)
        Me.LblEdition.TabIndex = 6
        Me.LblEdition.Text = "Edition"
        '
        'TxtPublisher
        '
        Me.TxtPublisher.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPublisher.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPublisher.Location = New System.Drawing.Point(293, 155)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(263, 31)
        Me.TxtPublisher.TabIndex = 9
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublisher.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblPublisher.Location = New System.Drawing.Point(172, 158)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(108, 28)
        Me.LblPublisher.TabIndex = 8
        Me.LblPublisher.Text = "Publisher"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAuthor.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAuthor.Location = New System.Drawing.Point(293, 196)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(263, 31)
        Me.TxtAuthor.TabIndex = 11
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblAuthor.Location = New System.Drawing.Point(197, 199)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(83, 28)
        Me.LblAuthor.TabIndex = 10
        Me.LblAuthor.Text = "Author"
        '
        'TxtCompensationPrice
        '
        Me.TxtCompensationPrice.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompensationPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCompensationPrice.Location = New System.Drawing.Point(294, 237)
        Me.TxtCompensationPrice.Name = "TxtCompensationPrice"
        Me.TxtCompensationPrice.Size = New System.Drawing.Size(99, 31)
        Me.TxtCompensationPrice.TabIndex = 13
        '
        'LblCompensationPrice
        '
        Me.LblCompensationPrice.AutoSize = True
        Me.LblCompensationPrice.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompensationPrice.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblCompensationPrice.Location = New System.Drawing.Point(67, 240)
        Me.LblCompensationPrice.Name = "LblCompensationPrice"
        Me.LblCompensationPrice.Size = New System.Drawing.Size(213, 28)
        Me.LblCompensationPrice.TabIndex = 12
        Me.LblCompensationPrice.Text = "Compensation Price"
        '
        'TxtBookType
        '
        Me.TxtBookType.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBookType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBookType.Location = New System.Drawing.Point(294, 279)
        Me.TxtBookType.Name = "TxtBookType"
        Me.TxtBookType.Size = New System.Drawing.Size(204, 31)
        Me.TxtBookType.TabIndex = 15
        '
        'LblBookType
        '
        Me.LblBookType.AutoSize = True
        Me.LblBookType.Font = New System.Drawing.Font("Sitka Small", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookType.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblBookType.Location = New System.Drawing.Point(163, 282)
        Me.LblBookType.Name = "LblBookType"
        Me.LblBookType.Size = New System.Drawing.Size(117, 28)
        Me.LblBookType.TabIndex = 14
        Me.LblBookType.Text = "Book Type"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnSubmit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSubmit.Location = New System.Drawing.Point(241, 352)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(136, 36)
        Me.BtnSubmit.TabIndex = 16
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BtnClear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnClear.Location = New System.Drawing.Point(457, 352)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(136, 36)
        Me.BtnClear.TabIndex = 17
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(693, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "___________________________ Please Enter Following Details to Register New Book _" &
    "__________________________"
        '
        'FrmNewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(731, 497)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtBookType)
        Me.Controls.Add(Me.LblBookType)
        Me.Controls.Add(Me.TxtCompensationPrice)
        Me.Controls.Add(Me.LblCompensationPrice)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.TxtPublisher)
        Me.Controls.Add(Me.LblPublisher)
        Me.Controls.Add(Me.TxtEdition)
        Me.Controls.Add(Me.LblEdition)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblId)
        Me.Name = "FrmNewBook"
        Me.Text = "New Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtEdition As TextBox
    Friend WithEvents LblEdition As Label
    Friend WithEvents TxtPublisher As TextBox
    Friend WithEvents LblPublisher As Label
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents LblAuthor As Label
    Friend WithEvents TxtCompensationPrice As TextBox
    Friend WithEvents LblCompensationPrice As Label
    Friend WithEvents TxtBookType As TextBox
    Friend WithEvents LblBookType As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label1 As Label
End Class
