<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBHowMany = New System.Windows.Forms.Label()
        Me.TBSearch = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LBHowMany
        '
        Me.LBHowMany.AutoSize = True
        Me.LBHowMany.Location = New System.Drawing.Point(12, 9)
        Me.LBHowMany.Name = "LBHowMany"
        Me.LBHowMany.Size = New System.Drawing.Size(27, 12)
        Me.LBHowMany.TabIndex = 2
        Me.LBHowMany.Text = "0 자"
        '
        'TBSearch
        '
        Me.TBSearch.Location = New System.Drawing.Point(14, 34)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(367, 146)
        Me.TBSearch.TabIndex = 3
        Me.TBSearch.Text = ""
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 192)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.LBHowMany)
        Me.Name = "MainFrm"
        Me.Text = "글자 수 세자"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBHowMany As Label
    Friend WithEvents TBSearch As RichTextBox
End Class
