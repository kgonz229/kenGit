Public Class ChoiceSample
    Private arrRadColor(2) As RadioButton 'array of three radio button controls
    Private arrRadTrim(2) As RadioButton
    Private arrChk(2) As CheckBox

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long sleeve shirt")
        cboSaleItems.Items.Add("Short sleeve shirt")
        cboSaleItems.Items.Add("Lightweight jacket")
    End Sub
    Private Sub LoadListBoxChoices()
        lstSizes.Items.Add("Small")
        lstSizes.Items.Add("Medium")
        lstSizes.Items.Add("Large")
        lstSizes.Items.Add("XL")
        lstSizes.Items.Add("XXL")
    End Sub

    Private Sub LoadCheckedListBoxChoices()
        clbBox.Items.Add("Baseball cap")
        clbBox.Items.Add("Cowboy Hat")
        clbBox.Items.Add("Tennis Hat")
        clbBox.Items.Add("Golf Hat")
    End Sub
    Private Sub ChoiceSample_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
        LoadListBoxChoices()
        LoadCheckedListBoxChoices()
        'load the control  arrays
        arrRadColor(0) = radRed
        arrRadColor(1) = radBlue
        arrRadColor(2) = radGreen
        arrRadTrim(0) = radGold
        arrRadTrim(1) = radSilver
        arrRadTrim(2) = radBlack
        arrChk(0) = chkExpress
        arrChk(1) = chkSaturday
        arrChk(2) = chkResidence

    End Sub
End Class
