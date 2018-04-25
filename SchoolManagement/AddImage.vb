Imports System.IO
Imports SchoolManagement.Form1
Public Class AddImage
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub AddImage_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Image"
        ImageRetrieve()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub CornflowerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CornflowerBlueToolStripMenuItem.Click
        Me.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub DarkRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkRedToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub DarkVioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkVioletToolStripMenuItem.Click
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub DeepSkyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeepSkyBlueToolStripMenuItem.Click
        Me.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub HotPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotPinkToolStripMenuItem.Click
        Me.BackColor = Color.HotPink
    End Sub

    Private Sub IvoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvoryToolStripMenuItem.Click
        Me.BackColor = Color.Ivory
    End Sub

    Private Sub LightCoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightCoralToolStripMenuItem.Click
        Me.BackColor = Color.LightCoral
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click
        Me.BackColor = Color.LimeGreen
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = Color.MediumPurple
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        OpenFileDialog1.Filter = "ImageFile(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png | all files (*.*) | *.* "
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles TitleBox.TextChanged, DescriptBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TitleBox.Text) And
                Not String.IsNullOrWhiteSpace(DescriptBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveImage()

        Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim breader As New BinaryReader(fsreader)
            Dim imgbuffer(fsreader.Length) As Byte

            breader.Read(imgbuffer, 0, fsreader.Length)
            fsreader.Close()

            Access.AddParam("@imgt", TitleBox.Text)
            Access.AddParam("@imgf", imgbuffer)
            Access.AddParam("@imgd", DescriptBox.Text)

        Access.ExecQuery("INSERT INTO GalleryItems (ImageTitle, ImageFile, ImgDescription) " &
                             "VALUES (@imgt, @imgf, @imgd); ")

        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Image Saved Successfully!")
        ImageRetrieve()
        ViewGallery.ImageRetrieve()
    End Sub

    Private Sub ImageRetrieve()
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(256, 180)

        Access.ExecQuery("SELECT * FROM GalleryItems")

        Dim dt_images As New DataTable

        Access.DBDA.Fill(dt_images)

        For Each dr As DataRow In dt_images.Rows
            Dim img_buffer = CType(dr("ImageFile"), Byte())
            Dim img_stream As New MemoryStream(img_buffer, True)
            img_stream.Write(img_buffer, 0, img_buffer.Length)
            imglist.Images.Add(dr("ID").ToString(), New Bitmap(img_stream))
            img_stream.Close()

            Dim lsvparent As New ListViewItem
            lsvparent.Text = dr("ImageTitle").ToString & " - " & dr("ImgDescription").ToString
            lsvparent.ImageKey = dr("ID").ToString
            ListView1.Items.Add(lsvparent)
        Next
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveImage()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ViewGallery.Show()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TitleBox.Text = "Add Image Title Here"
        DescriptBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class