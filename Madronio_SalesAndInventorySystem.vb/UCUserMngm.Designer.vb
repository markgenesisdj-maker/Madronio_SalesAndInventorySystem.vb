<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserMngm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(14, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(985, 339)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Panel4)
        Panel2.Location = New Point(14, 14)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(985, 370)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(14, 399)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(985, 215)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.RoyalBlue
        Panel4.Controls.Add(Label5)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(985, 57)
        Panel4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(14, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(280, 30)
        Label5.TabIndex = 2
        Label5.Text = "User Account Management"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.DimGray
        TextBox1.Location = New Point(38, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 29)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(34, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 3
        Label3.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(34, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.DimGray
        TextBox2.Location = New Point(38, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(414, 29)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.Location = New Point(34, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 20)
        Label2.TabIndex = 3
        Label2.Text = "Confirm Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.DimGray
        TextBox3.Location = New Point(38, 243)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(414, 29)
        TextBox3.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label4.Location = New Point(514, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 20)
        Label4.TabIndex = 3
        Label4.Text = "Login Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = Color.DimGray
        TextBox4.Location = New Point(517, 110)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(414, 29)
        TextBox4.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label6.Location = New Point(514, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 3
        Label6.Text = "User Type"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.Add
        Button1.Location = New Point(38, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 53)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.Save
        Button2.Location = New Point(170, 296)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 53)
        Button2.TabIndex = 1
        Button2.Text = "Save"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.LightGray
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.Location = New Point(302, 296)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 53)
        Button3.TabIndex = 1
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.Delete
        Button4.Location = New Point(434, 296)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 53)
        Button4.TabIndex = 1
        Button4.Text = "Delete"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderColor = Color.LightGray
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button5.Location = New Point(566, 296)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 53)
        Button5.TabIndex = 1
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(14, 15)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(956, 189)
        DataGridView1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.DimGray
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(517, 174)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(414, 29)
        ComboBox1.TabIndex = 5
        ' 
        ' UCUserMngm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UCUserMngm"
        Size = New Size(1016, 636)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox

End Class
