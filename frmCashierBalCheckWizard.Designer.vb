﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashierBalCheckWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashierBalCheckWizard))
        Me.grdCCheckAmounts = New System.Windows.Forms.DataGridView
        Me.txtCount = New System.Windows.Forms.TextBox
        Me.lblCount = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.tsCkWizard = New System.Windows.Forms.ToolStrip
        Me.tsBtnCKDel = New System.Windows.Forms.ToolStripButton
        CType(Me.grdCCheckAmounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCkWizard.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCCheckAmounts
        '
        Me.grdCCheckAmounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCCheckAmounts.Location = New System.Drawing.Point(22, 29)
        Me.grdCCheckAmounts.Name = "grdCCheckAmounts"
        Me.grdCCheckAmounts.Size = New System.Drawing.Size(240, 150)
        Me.grdCCheckAmounts.TabIndex = 10
        '
        'txtCount
        '
        Me.txtCount.AcceptsReturn = True
        Me.txtCount.Enabled = False
        Me.txtCount.Location = New System.Drawing.Point(56, 185)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(26, 20)
        Me.txtCount.TabIndex = 20
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(10, 192)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(40, 13)
        Me.lblCount.TabIndex = 19
        Me.lblCount.Text = "Count"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(98, 192)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(147, 185)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(98, 20)
        Me.txtTotal.TabIndex = 17
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(170, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(65, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Green
        Me.btnSave.Location = New System.Drawing.Point(69, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(7, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(65, 23)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'tsCkWizard
        '
        Me.tsCkWizard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnCKDel})
        Me.tsCkWizard.Location = New System.Drawing.Point(0, 0)
        Me.tsCkWizard.Name = "tsCkWizard"
        Me.tsCkWizard.Size = New System.Drawing.Size(292, 25)
        Me.tsCkWizard.TabIndex = 24
        Me.tsCkWizard.Text = "ToolStrip1"
        '
        'tsBtnCKDel
        '
        Me.tsBtnCKDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnCKDel.Image = CType(resources.GetObject("tsBtnCKDel.Image"), System.Drawing.Image)
        Me.tsBtnCKDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCKDel.Name = "tsBtnCKDel"
        Me.tsBtnCKDel.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnCKDel.Text = "ToolStripButton1"
        Me.tsBtnCKDel.ToolTipText = "Delete"
        '
        'frmCashierBalCheckWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.tsCkWizard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.grdCCheckAmounts)
        Me.Location = New System.Drawing.Point(520, 50)
        Me.Name = "frmCashierBalCheckWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Check Wizard"
        CType(Me.grdCCheckAmounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCkWizard.ResumeLayout(False)
        Me.tsCkWizard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCCheckAmounts As System.Windows.Forms.DataGridView
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tsCkWizard As System.Windows.Forms.ToolStrip
    Friend WithEvents tsBtnCKDel As System.Windows.Forms.ToolStripButton
End Class