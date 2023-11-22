Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles btnNext2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub btnNext5_Click(sender As Object, e As EventArgs) Handles btnNext5.Click
        TabControl1.SelectedTab = TabPage6
        My.Computer.Audio.Play(My.Resources.wavPage6_7, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnNext6_Click(sender As Object, e As EventArgs) Handles btnNext6.Click
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub btnNext7_Click(sender As Object, e As EventArgs) Handles btnNext7.Click
        TabControl1.SelectedTab = TabPage8
        My.Computer.Audio.Play(My.Resources.wavPage8_10, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnNext8_Click(sender As Object, e As EventArgs) Handles btnNext8.Click
        TabControl1.SelectedTab = TabPage9
    End Sub

    Private Sub btnNext9_Click(sender As Object, e As EventArgs) Handles btnNext9.Click
        TabControl1.SelectedTab = TabPage10
    End Sub

    Private Sub btnNext10_Click(sender As Object, e As EventArgs) Handles btnNext10.Click
        TabControl1.SelectedTab = TabPage11
        My.Computer.Audio.Play(My.Resources.wavPage11_12, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnNext11_Click(sender As Object, e As EventArgs) Handles btnNext11.Click
        TabControl1.SelectedTab = TabPage12
    End Sub

    Private Sub btnNext12_Click(sender As Object, e As EventArgs) Handles btnNext12.Click
        TabControl1.SelectedTab = TabPage13
        My.Computer.Audio.Play(My.Resources.wavPage13wav, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub btnNext13_Click(sender As Object, e As EventArgs) Handles btnNext13.Click
        TabControl1.SelectedTab = TabPage14
    End Sub
    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnBack5_Click(sender As Object, e As EventArgs) Handles btnBack5.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub btnBack6_Click(sender As Object, e As EventArgs) Handles btnBack6.Click
        TabControl1.SelectedTab = TabPage5
        My.Computer.Audio.Play(My.Resources.wavPage1_5, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnBack7_Click(sender As Object, e As EventArgs) Handles btnBack7.Click
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub btnBack8_Click(sender As Object, e As EventArgs) Handles btnBack8.Click
        TabControl1.SelectedTab = TabPage7
        My.Computer.Audio.Play(My.Resources.wavPage6_7, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnBack9_Click(sender As Object, e As EventArgs) Handles btnBack9.Click
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub btnBack10_Click(sender As Object, e As EventArgs) Handles btnBack10.Click
        TabControl1.SelectedTab = TabPage9
    End Sub

    Private Sub btnBack11_Click(sender As Object, e As EventArgs) Handles btnBack11.Click
        TabControl1.SelectedTab = TabPage10
        My.Computer.Audio.Play(My.Resources.wavPage8_10, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnBack12_Click(sender As Object, e As EventArgs) Handles btnBack12.Click
        TabControl1.SelectedTab = TabPage11
    End Sub

    Private Sub btnBack13_Click(sender As Object, e As EventArgs) Handles btnBack13.Click
        TabControl1.SelectedTab = TabPage12
        My.Computer.Audio.Play(My.Resources.wavPage11_12, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPage1.Click
        TabControl1.SelectedTab = TabPage1
        My.Computer.Audio.Play(My.Resources.wavPage1_5, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub lblArkray_Click(sender As Object, e As EventArgs) Handles lblArkray.Click
        lblInfo2.Visible = False
        lblInfo.Text = "Arkray was hailed as the Dragon Emperor, and he was also the one who led the ''Calamity'' attack on the humans. His attack eventually led to his own death. His skeletal remains now rests outside of a town within the Vermilion Isles."
        lblImgInfo.Text = "The skeletal remains of Arkray. His skeleton surrounding a town named the ''Bastion''"
        imgInfo.Image = My.Resources.Arkray_Skeleton
    End Sub

    Private Sub lblKamen_Click(sender As Object, e As EventArgs) Handles lblKamen.Click
        lblInfo2.Visible = True
        lblInfo2.Text = "Once a powerful and respected mage, Kamen is now the ruler of the Catacombs. His control over the undead makes him a formidable threat to humanity. He was once imprisoned by the humans but he eventually escaped with the help of Necron. Now, he grows his power within the Catacombs waiting for the right time to strike against the humans."
    End Sub

    Private Sub lblNecron_Click(sender As Object, e As EventArgs) Handles lblNecron.Click
        lblInfo2.Visible = True
        lblInfo2.Text = "He was a young mage that stole Kamen's research from the authorities and used it to gain power for himself. He later helped Kamen escape from imprisonment and helped him regain his powers. He is considered to be Kamen's right hand man."
    End Sub

    Private Sub lblEden_Click(sender As Object, e As EventArgs) Handles lblEden.Click
        lblInfo2.Visible = True
        lblInfo2.Text = "Eden was once regarded as the utopia for humans. It was a floating island whose size rivaled that of a continent. It was inevitably destroyed when Arkray attacked the humans during the ''Calamity.'' Its current state is nothing like what it was before Arkray's attack."
    End Sub

    Private Sub lblIsles_Click(sender As Object, e As EventArgs) Handles lblIsles.Click
        lblInfo2.Visible = False
        lblInfo.Text = "The Vermilion Isles is now the current state of Eden. Once a beautiful utopia, it is now the embodiment of hell itself, draining the lives of any mortal who wishes to come close to it."
        lblImgInfo.Text = "The current state of the Vermilion Isles"
        imgInfo.Image = My.Resources.Crimson_Isles
    End Sub

    Private Sub lblCata_Click(sender As Object, e As EventArgs) Handles lblCata.Click
        lblInfo2.Visible = True
        lblInfo2.Text = "Before Kamen took over the Catacombs, it was the burial site for those who have fallen during the Calamity. In its current state, it's an elaborate labyrinth created by Kamen and his undead army in order to gain more power from unsuspecting humans who venture into the Catacombs."
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click
        Form2.Show()
        My.Computer.Audio.Play(My.Resources.wavMenu, AudioPlayMode.BackgroundLoop)
        Me.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.wavPage1_5, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
