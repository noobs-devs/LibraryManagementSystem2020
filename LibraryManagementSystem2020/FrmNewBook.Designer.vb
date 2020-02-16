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
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblBookType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(77, 12)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 20)
        Me.TxtID.TabIndex = 3
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(10, 15)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(18, 13)
        Me.LblID.TabIndex = 2
        Me.LblID.Text = "ID"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(77, 47)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(100, 20)
        Me.TxtTitle.TabIndex = 5
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(10, 50)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(27, 13)
        Me.LblTitle.TabIndex = 4
        Me.LblTitle.Text = "Title"
        '
        'TxtEdition
        '
        Me.TxtEdition.Location = New System.Drawing.Point(77, 81)
        Me.TxtEdition.Name = "TxtEdition"
        Me.TxtEdition.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdition.TabIndex = 7
        '
        'LblEdition
        '
        Me.LblEdition.AutoSize = True
        Me.LblEdition.Location = New System.Drawing.Point(10, 84)
        Me.LblEdition.Name = "LblEdition"
        Me.LblEdition.Size = New System.Drawing.Size(39, 13)
        Me.LblEdition.TabIndex = 6
        Me.LblEdition.Text = "Edition"
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Location = New System.Drawing.Point(77, 116)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(100, 20)
        Me.TxtPublisher.TabIndex = 9
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Location = New System.Drawing.Point(10, 119)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.LblPublisher.TabIndex = 8
        Me.LblPublisher.Text = "Publisher"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Location = New System.Drawing.Point(77, 151)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(100, 20)
        Me.TxtAuthor.TabIndex = 11
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Location = New System.Drawing.Point(10, 154)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(38, 13)
        Me.LblAuthor.TabIndex = 10
        Me.LblAuthor.Text = "Author"
        '
        'TxtCompensationPrice
        '
        Me.TxtCompensationPrice.Location = New System.Drawing.Point(77, 185)
        Me.TxtCompensationPrice.Name = "TxtCompensationPrice"
        Me.TxtCompensationPrice.Size = New System.Drawing.Size(99, 20)
        Me.TxtCompensationPrice.TabIndex = 13
        '
        'LblCompensationPrice
        '
        Me.LblCompensationPrice.AutoSize = True
        Me.LblCompensationPrice.Location = New System.Drawing.Point(9, 188)
        Me.LblCompensationPrice.Name = "LblCompensationPrice"
        Me.LblCompensationPrice.Size = New System.Drawing.Size(101, 13)
        Me.LblCompensationPrice.TabIndex = 12
        Me.LblCompensationPrice.Text = "Compensation Price"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 220)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'LblBookType
        '
        Me.LblBookType.AutoSize = True
        Me.LblBookType.Location = New System.Drawing.Point(10, 223)
        Me.LblBookType.Name = "LblBookType"
        Me.LblBookType.Size = New System.Drawing.Size(59, 13)
        Me.LblBookType.TabIndex = 14
        Me.LblBookType.Text = "Book Type"
        '
        'FrmNewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LblID)
        Me.Name = "FrmNewBook"
        Me.Text = "New Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtID As TextBox
    Friend WithEvents LblID As Label
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblBookType As Label
End Class
