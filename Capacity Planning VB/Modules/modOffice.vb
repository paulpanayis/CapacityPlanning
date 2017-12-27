Module modOffice
    Sub ExportListViewToExcel(ByRef lvwX As ListView, Optional ByVal blnNoHeader As Boolean = False)
        Dim objExcel As New clsExcel

        objExcel.PasteListView(lvwX, blnNoHeader)

        objExcel = Nothing
    End Sub
End Module
