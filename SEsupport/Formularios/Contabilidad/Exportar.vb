Module Exportar

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        ElGrid.Columns(0).Name = "Nit Pagador"
        ElGrid.Columns(1).Name = "Tipo Pago"
        ElGrid.Columns(2).Name = "Aplicacion"
        ElGrid.Columns(3).Name = "Secuencia"
        ElGrid.Columns(4).Name = "No Cuenta"
        ElGrid.Columns(5).Name = "Tipo Cuenta"
        ElGrid.Columns(6).Name = "Descripcion"
        ElGrid.Columns(7).Name = "Tipo Documento Beneficiario"
        ElGrid.Columns(8).Name = "Nit Beneficiario"
        ElGrid.Columns(9).Name = "Nombre Beneficiario"
        ElGrid.Columns(10).Name = "Tipo Transaccion"
        ElGrid.Columns(11).Name = "Codigo Banco"
        ElGrid.Columns(12).Name = "No Cuenta Beneficiario"
        ElGrid.Columns(13).Name = "Email"
        ElGrid.Columns(14).Name = "Documento Autorizado"
        ElGrid.Columns(15).Name = "Referencia"
        ElGrid.Columns(16).Name = "OficinaEntrega"
        ElGrid.Columns(17).Name = "Valor Transaccion"
        ElGrid.Columns(18).Name = "Fecha Transaccion"

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            'exHoja = exLibro.Worksheets.Add()
            exHoja = exLibro.Worksheets(1)

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function

End Module
