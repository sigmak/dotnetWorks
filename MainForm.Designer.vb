'
' SharpDevelop으로 작성되었습니다.
' 사용자: sigmak
' 날짜: 2022-01-08
' 시간: 오전 1:15
' 
' 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnCapture = New System.Windows.Forms.Button()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dataGridView1
		'
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(2, 35)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.RowTemplate.Height = 23
		Me.dataGridView1.Size = New System.Drawing.Size(188, 77)
		Me.dataGridView1.TabIndex = 0
		'
		'btnCapture
		'
		Me.btnCapture.Location = New System.Drawing.Point(38, 3)
		Me.btnCapture.Name = "btnCapture"
		Me.btnCapture.Size = New System.Drawing.Size(94, 26)
		Me.btnCapture.TabIndex = 1
		Me.btnCapture.Text = "컨트롤 캡쳐"
		Me.btnCapture.UseVisualStyleBackColor = true
		AddHandler Me.btnCapture.Click, AddressOf Me.BtnCaptureClick
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.pictureBox1.Location = New System.Drawing.Point(432, 25)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(353, 152)
		Me.pictureBox1.TabIndex = 2
		Me.pictureBox1.TabStop = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(797, 309)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.btnCapture)
		Me.Controls.Add(Me.dataGridView1)
		Me.Name = "MainForm"
		Me.Text = "captureControlTest"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private btnCapture As System.Windows.Forms.Button
	Private dataGridView1 As System.Windows.Forms.DataGridView
End Class
