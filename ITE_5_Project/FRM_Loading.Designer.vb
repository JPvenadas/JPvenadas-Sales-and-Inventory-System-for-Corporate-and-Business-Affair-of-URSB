﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Loading
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBL_percentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Depth = 0
        Me.ProgressBar.Location = New System.Drawing.Point(58, 502)
        Me.ProgressBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(936, 5)
        Me.ProgressBar.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(653, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 44)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Logging in..."
        '
        'LBL_percentage
        '
        Me.LBL_percentage.AutoSize = True
        Me.LBL_percentage.BackColor = System.Drawing.Color.Transparent
        Me.LBL_percentage.Font = New System.Drawing.Font("Microsoft JhengHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_percentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.LBL_percentage.Location = New System.Drawing.Point(886, 436)
        Me.LBL_percentage.Name = "LBL_percentage"
        Me.LBL_percentage.Size = New System.Drawing.Size(73, 44)
        Me.LBL_percentage.TabIndex = 7
        Me.LBL_percentage.Text = "0%"
        '
        'FRM_Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 661)
        Me.Controls.Add(Me.LBL_percentage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents LBL_percentage As Label
End Class
