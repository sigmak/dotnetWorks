'
' SharpDevelop으로 작성되었습니다.
' 사용자: raven90
' 날짜: 2022-01-08
' 시간: 오전 1:15
' 
' 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
'
Imports System.Drawing

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		'datagridview1 에 data 입력하기
		'참고 : http://vb.net-informations.com/datagridview/vb.net_datagridview_add.htm
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "Product ID"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Product_Price"

        Dim row As String() = New String() {"1", "Product 1", "1000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"2", "Product 2", "2000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"3", "Product 3", "3000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"4", "Product 4", "4000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"5", "Product 5", "5000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"6", "Product 6", "6000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"7", "Product 7", "6000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"8", "Product 8", "6000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"9", "Product 9", "6000"}
        DataGridView1.Rows.Add(row)		
        row = New String() {"10", "Product 10", "6000"}
        DataGridView1.Rows.Add(row)		
        
	End Sub
	
	Sub BtnCaptureClick(sender As Object, e As EventArgs)
		'Resize DataGridView to full height.
		Dim height As Integer = dataGridView1.Height
		Dim gapHeight As Integer
		Dim width As Integer = dataGridView1.Width 
		Dim gapWidth As Integer
		
		Try

				gapHeight=0
				For iRow= 0 To dataGridView1.Rows.Count - 1 
					 gapHeight = gapHeight + dataGridView1.Rows(iRow).Height 
				Next 
				dataGridView1.Height = gapHeight + 40'dataGridView1.RowCount * dataGridView1.RowTemplate.Height
				
				gapWidth=0
				For iCol= 0 To dataGridView1.Columns.Count - 1 
					 gapWidth = gapWidth + dataGridView1.columns(iCol).Width 
				Next 
				dataGridView1.Height = gapHeight + 38'(4.2 * (dataGridView1.Rows.Count - 1 ))'dataGridView1.RowCount * dataGridView1.RowTemplate.Height
				dataGridView1.Width = gapWidth + 44
				
				'Create a Bitmap and draw the DataGridView on it.
				Using bitmap = New Bitmap(dataGridView1.Width, dataGridView1.Height)
					dataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height))
					pictureBox1.Width = dataGridView1.Width + 2
					pictureBox1.Height = dataGridView1.Height + 2
					
					'Resize DataGridView back to original height.
					dataGridView1.Height = height
					dataGridView1.Width = width
					
					''Save the Bitmap to folder.
					'bitmap.Save("D:\DataGridView.png")	'파일로 저장시	
					
					'PictureBox1 의 이미지에 bitmap을 보여주려고 하면
					'참고 : https://stackoverflow.com/questions/2540750/load-picturebox-image-from-memory
					Dim SaveStream As New IO.MemoryStream
					bitmap.Save(SaveStream, System.Drawing.Imaging.ImageFormat.Bmp)
             		pictureBox1.Image = new Bitmap(SaveStream)
					
			    End Using
			
         Catch
            MessageBox.Show("Error.....")			
		End Try
	End Sub
End Class
