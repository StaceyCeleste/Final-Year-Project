﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSignaturies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSignaturies))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.DeleteBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthoriseBox = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.SurnameBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstBtn, Me.PrevBtn, Me.SaveBtn, Me.DeleteBtn, Me.NextBtn, Me.LastBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(440, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FirstBtn
        '
        Me.FirstBtn.Image = CType(resources.GetObject("FirstBtn.Image"), System.Drawing.Image)
        Me.FirstBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FirstBtn.Name = "FirstBtn"
        Me.FirstBtn.Size = New System.Drawing.Size(55, 22)
        Me.FirstBtn.Text = "&First"
        '
        'PrevBtn
        '
        Me.PrevBtn.Image = CType(resources.GetObject("PrevBtn.Image"), System.Drawing.Image)
        Me.PrevBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(81, 22)
        Me.PrevBtn.Text = "&Previous"
        '
        'SaveBtn
        '
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(56, 22)
        Me.SaveBtn.Text = "&Save"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Image = CType(resources.GetObject("DeleteBtn.Image"), System.Drawing.Image)
        Me.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(68, 22)
        Me.DeleteBtn.Text = "&Delete"
        '
        'NextBtn
        '
        Me.NextBtn.Image = CType(resources.GetObject("NextBtn.Image"), System.Drawing.Image)
        Me.NextBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(57, 22)
        Me.NextBtn.Text = "&Next"
        '
        'LastBtn
        '
        Me.LastBtn.Image = CType(resources.GetObject("LastBtn.Image"), System.Drawing.Image)
        Me.LastBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LastBtn.Name = "LastBtn"
        Me.LastBtn.Size = New System.Drawing.Size(53, 22)
        Me.LastBtn.Text = "&Last"
        '
        'ExitBtn
        '
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(51, 22)
        Me.ExitBtn.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 36)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Edit Active Signaturies"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AuthoriseBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Controls.Add(Me.SurnameBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 147)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Signaturies Details"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IDLabel.Location = New System.Drawing.Point(39, 27)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 18)
        Me.IDLabel.TabIndex = 10
        Me.IDLabel.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Signature Name:"
        '
        'AuthoriseBox
        '
        Me.AuthoriseBox.AutoSize = True
        Me.AuthoriseBox.Location = New System.Drawing.Point(158, 108)
        Me.AuthoriseBox.Name = "AuthoriseBox"
        Me.AuthoriseBox.Size = New System.Drawing.Size(16, 16)
        Me.AuthoriseBox.TabIndex = 8
        Me.AuthoriseBox.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Signature Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Authorised By:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(155, 52)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(249, 22)
        Me.NameBox.TabIndex = 5
        '
        'SurnameBox
        '
        Me.SurnameBox.Location = New System.Drawing.Point(155, 80)
        Me.SurnameBox.Name = "SurnameBox"
        Me.SurnameBox.Size = New System.Drawing.Size(249, 22)
        Me.SurnameBox.TabIndex = 6
        '
        'EditSignaturies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(440, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(456, 281)
        Me.MinimumSize = New System.Drawing.Size(456, 281)
        Me.Name = "EditSignaturies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Signaturies"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FirstBtn As ToolStripButton
    Friend WithEvents PrevBtn As ToolStripButton
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents NextBtn As ToolStripButton
    Friend WithEvents LastBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents DeleteBtn As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AuthoriseBox As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents SurnameBox As TextBox
End Class
