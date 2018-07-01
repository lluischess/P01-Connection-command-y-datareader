<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rbtId = New System.Windows.Forms.RadioButton()
        Me.rbtNom = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.tbcargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbape = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbfecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 86)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Carregar dades"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(211, 10)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(366, 404)
        Me.ListBox1.TabIndex = 1
        '
        'rbtId
        '
        Me.rbtId.AutoSize = True
        Me.rbtId.Location = New System.Drawing.Point(6, 104)
        Me.rbtId.Name = "rbtId"
        Me.rbtId.Size = New System.Drawing.Size(133, 24)
        Me.rbtId.TabIndex = 2
        Me.rbtId.Text = "Ordenar per ID"
        Me.rbtId.UseVisualStyleBackColor = True
        '
        'rbtNom
        '
        Me.rbtNom.AutoSize = True
        Me.rbtNom.Checked = True
        Me.rbtNom.Location = New System.Drawing.Point(6, 134)
        Me.rbtNom.Name = "rbtNom"
        Me.rbtNom.Size = New System.Drawing.Size(199, 24)
        Me.rbtNom.TabIndex = 3
        Me.rbtNom.TabStop = True
        Me.rbtNom.Text = "Ordenar per Cognombre"
        Me.rbtNom.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Id Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(598, 70)
        Me.tbid.Name = "tbid"
        Me.tbid.ReadOnly = True
        Me.tbid.Size = New System.Drawing.Size(232, 26)
        Me.tbid.TabIndex = 10
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(598, 118)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(232, 26)
        Me.tbNom.TabIndex = 11
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(6, 245)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(196, 25)
        Me.Insert.TabIndex = 12
        Me.Insert.Text = "INSERTAR"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(6, 187)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(196, 25)
        Me.update.TabIndex = 13
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(6, 303)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(196, 25)
        Me.delete.TabIndex = 14
        Me.delete.Text = "ELIMINAR"
        Me.delete.UseVisualStyleBackColor = True
        '
        'tbcargo
        '
        Me.tbcargo.Location = New System.Drawing.Point(598, 229)
        Me.tbcargo.Name = "tbcargo"
        Me.tbcargo.Size = New System.Drawing.Size(232, 26)
        Me.tbcargo.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(594, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cargo"
        '
        'tbape
        '
        Me.tbape.Location = New System.Drawing.Point(598, 174)
        Me.tbape.Name = "tbape"
        Me.tbape.Size = New System.Drawing.Size(232, 26)
        Me.tbape.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(594, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Apellido"
        '
        'tbfecha
        '
        Me.tbfecha.Location = New System.Drawing.Point(598, 284)
        Me.tbfecha.Name = "tbfecha"
        Me.tbfecha.Size = New System.Drawing.Size(232, 26)
        Me.tbfecha.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(598, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Mostrar Dades:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 428)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbape)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbcargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtNom)
        Me.Controls.Add(Me.rbtId)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents rbtId As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNom As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNom As System.Windows.Forms.TextBox
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents tbcargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbape As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbfecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbid As TextBox
End Class
