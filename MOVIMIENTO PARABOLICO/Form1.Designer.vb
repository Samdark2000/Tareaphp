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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxALT_INI = New System.Windows.Forms.TextBox()
        Me.TextBoxALT_FIN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxVEL_INI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxANGULO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxGRAVEDAD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelTIEMPO = New System.Windows.Forms.Label()
        Me.LabelDESPLAZX = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCOORDALTURAMAXIMA = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelVELOCIDADFINALY = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelVELOCIDADFINALX = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelSENO = New System.Windows.Forms.Label()
        Me.LabelCOSENO = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(382, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(771, 703)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ALTURA INICIAL"
        '
        'TextBoxALT_INI
        '
        Me.TextBoxALT_INI.Location = New System.Drawing.Point(139, 5)
        Me.TextBoxALT_INI.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxALT_INI.Name = "TextBoxALT_INI"
        Me.TextBoxALT_INI.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxALT_INI.TabIndex = 2
        Me.TextBoxALT_INI.Text = "0"
        Me.TextBoxALT_INI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxALT_FIN
        '
        Me.TextBoxALT_FIN.Location = New System.Drawing.Point(139, 28)
        Me.TextBoxALT_FIN.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxALT_FIN.Name = "TextBoxALT_FIN"
        Me.TextBoxALT_FIN.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxALT_FIN.TabIndex = 4
        Me.TextBoxALT_FIN.Text = "0"
        Me.TextBoxALT_FIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(20, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ALTURA FINAL"
        '
        'TextBoxVEL_INI
        '
        Me.TextBoxVEL_INI.Location = New System.Drawing.Point(139, 52)
        Me.TextBoxVEL_INI.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxVEL_INI.Name = "TextBoxVEL_INI"
        Me.TextBoxVEL_INI.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxVEL_INI.TabIndex = 6
        Me.TextBoxVEL_INI.Text = "600"
        Me.TextBoxVEL_INI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(20, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VELOC. INICIAL"
        '
        'TextBoxANGULO
        '
        Me.TextBoxANGULO.Location = New System.Drawing.Point(139, 74)
        Me.TextBoxANGULO.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxANGULO.Name = "TextBoxANGULO"
        Me.TextBoxANGULO.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxANGULO.TabIndex = 8
        Me.TextBoxANGULO.Text = "60"
        Me.TextBoxANGULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(20, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ANGULO"
        '
        'TextBoxGRAVEDAD
        '
        Me.TextBoxGRAVEDAD.Location = New System.Drawing.Point(138, 97)
        Me.TextBoxGRAVEDAD.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxGRAVEDAD.Name = "TextBoxGRAVEDAD"
        Me.TextBoxGRAVEDAD.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxGRAVEDAD.TabIndex = 10
        Me.TextBoxGRAVEDAD.Text = "10"
        Me.TextBoxGRAVEDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(19, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "GRAVEDAD"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(20, 134)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "TIEMPO, DESPLZ X, ALTURA MAX."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(183, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TIEMPO1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(277, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TIEMPO2"
        '
        'LabelTIEMPO
        '
        Me.LabelTIEMPO.AutoSize = True
        Me.LabelTIEMPO.ForeColor = System.Drawing.Color.DimGray
        Me.LabelTIEMPO.Location = New System.Drawing.Point(182, 280)
        Me.LabelTIEMPO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTIEMPO.Name = "LabelTIEMPO"
        Me.LabelTIEMPO.Size = New System.Drawing.Size(54, 13)
        Me.LabelTIEMPO.TabIndex = 14
        Me.LabelTIEMPO.Text = "TIEMPO"
        '
        'LabelDESPLAZX
        '
        Me.LabelDESPLAZX.AutoSize = True
        Me.LabelDESPLAZX.ForeColor = System.Drawing.Color.DimGray
        Me.LabelDESPLAZX.Location = New System.Drawing.Point(183, 302)
        Me.LabelDESPLAZX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDESPLAZX.Name = "LabelDESPLAZX"
        Me.LabelDESPLAZX.Size = New System.Drawing.Size(131, 13)
        Me.LabelDESPLAZX.TabIndex = 15
        Me.LabelDESPLAZX.Text = "DESPLAZAMIENTO X"
        '
        'Timer1
        '
        '
        'LabelCOORDALTURAMAXIMA
        '
        Me.LabelCOORDALTURAMAXIMA.AutoSize = True
        Me.LabelCOORDALTURAMAXIMA.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCOORDALTURAMAXIMA.Location = New System.Drawing.Point(183, 328)
        Me.LabelCOORDALTURAMAXIMA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCOORDALTURAMAXIMA.Name = "LabelCOORDALTURAMAXIMA"
        Me.LabelCOORDALTURAMAXIMA.Size = New System.Drawing.Size(160, 13)
        Me.LabelCOORDALTURAMAXIMA.TabIndex = 16
        Me.LabelCOORDALTURAMAXIMA.Text = "COORD. ALTURA MAXIMA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(15, 254)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TIEMPOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(15, 280)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "TIEMPO CALCULO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(17, 302)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "DESPLAZAMIENTO X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(15, 328)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "COORD. ALTURA MAXIMA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(15, 381)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "VELOCIDAD FINAL Y"
        '
        'LabelVELOCIDADFINALY
        '
        Me.LabelVELOCIDADFINALY.AutoSize = True
        Me.LabelVELOCIDADFINALY.ForeColor = System.Drawing.Color.DimGray
        Me.LabelVELOCIDADFINALY.Location = New System.Drawing.Point(183, 381)
        Me.LabelVELOCIDADFINALY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVELOCIDADFINALY.Name = "LabelVELOCIDADFINALY"
        Me.LabelVELOCIDADFINALY.Size = New System.Drawing.Size(128, 13)
        Me.LabelVELOCIDADFINALY.TabIndex = 21
        Me.LabelVELOCIDADFINALY.Text = "VELOCIDAD FINAL Y"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(15, 352)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "VELOCIDAD FINAL X"
        '
        'LabelVELOCIDADFINALX
        '
        Me.LabelVELOCIDADFINALX.AutoSize = True
        Me.LabelVELOCIDADFINALX.ForeColor = System.Drawing.Color.DimGray
        Me.LabelVELOCIDADFINALX.Location = New System.Drawing.Point(183, 352)
        Me.LabelVELOCIDADFINALX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVELOCIDADFINALX.Name = "LabelVELOCIDADFINALX"
        Me.LabelVELOCIDADFINALX.Size = New System.Drawing.Size(128, 13)
        Me.LabelVELOCIDADFINALX.TabIndex = 23
        Me.LabelVELOCIDADFINALX.Text = "VELOCIDAD FINAL X"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(15, 205)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "SENO (ANGULO)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(17, 228)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "COSENO (ANGULO)"
        '
        'LabelSENO
        '
        Me.LabelSENO.AutoSize = True
        Me.LabelSENO.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSENO.Location = New System.Drawing.Point(182, 205)
        Me.LabelSENO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSENO.Name = "LabelSENO"
        Me.LabelSENO.Size = New System.Drawing.Size(41, 13)
        Me.LabelSENO.TabIndex = 27
        Me.LabelSENO.Text = "SENO"
        '
        'LabelCOSENO
        '
        Me.LabelCOSENO.AutoSize = True
        Me.LabelCOSENO.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCOSENO.Location = New System.Drawing.Point(182, 228)
        Me.LabelCOSENO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCOSENO.Name = "LabelCOSENO"
        Me.LabelCOSENO.Size = New System.Drawing.Size(58, 13)
        Me.LabelCOSENO.TabIndex = 28
        Me.LabelCOSENO.Text = "COSENO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1236, 725)
        Me.Controls.Add(Me.LabelCOSENO)
        Me.Controls.Add(Me.LabelSENO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelVELOCIDADFINALX)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelVELOCIDADFINALY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelCOORDALTURAMAXIMA)
        Me.Controls.Add(Me.LabelDESPLAZX)
        Me.Controls.Add(Me.LabelTIEMPO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxGRAVEDAD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxANGULO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxVEL_INI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxALT_FIN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxALT_INI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Name = "Form1"
        Me.Text = "PARABOLICO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxALT_INI As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxALT_FIN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxVEL_INI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxANGULO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGRAVEDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelTIEMPO As System.Windows.Forms.Label
    Friend WithEvents LabelDESPLAZX As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelCOORDALTURAMAXIMA As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelVELOCIDADFINALY As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelVELOCIDADFINALX As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelSENO As System.Windows.Forms.Label
    Friend WithEvents LabelCOSENO As System.Windows.Forms.Label

End Class
