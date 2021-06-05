Imports System.IO
Public Class Impresion_Inventario
    Private empresa, nit_empresa, direccion_empresa, telefono_empresa, mensaje_empresa As String
    Public x As Integer = 5
    Public y As Integer = 20
    Public i_factu, i_pastse, i_fecha, i_bodega, i_mes, i_fecha103 As String
    Public otra_hoja As Boolean = False
    Public inicio As Integer = 0
    Public salto_pagina = 116
    Public dtconteo As New DataTable

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim dtconsulta_encabezado As New DataTable
        Dim consultas As New Querys_impresiones_inventarios
        Dim aux As String ' es para poder extraer la descripcion de la referencia e imprimirla segun el tope
        Dim tope As Integer = 35 'se debe cambiar el tope para la impresion de la descripcion de la referencia

        If otra_hoja = False Then ' valido si estamos imprimiendo mas hojas para no reimprimir el encabezado
            dtconsulta_encabezado = consultas.cons_encabezado(i_pastse, i_factu)

            Dim prFont_encabezado As New Font("Arial", 8, FontStyle.Bold) ' ESTA ES LA FUENTE DE IMPRESION
            Dim prFont_detalle As New Font("Arial", 9, FontStyle.Bold) ' ESTA ES LA FUENTE DE IMPRESION

            'IMPRIMIMOS EL ENCABEZADO HOJA'
            empresa = dtconsulta_encabezado.Rows(0)(1).ToString()
            nit_empresa = dtconsulta_encabezado.Rows(0)(2).ToString()
            direccion_empresa = dtconsulta_encabezado.Rows(0)(3).ToString()

            e.Graphics.DrawString(empresa, prFont_encabezado, Brushes.Black, x, y)
            y = y + 12
            e.Graphics.DrawString("INFORME DE INVENTARIO FISICO", prFont_encabezado, Brushes.Black, x, y)
            y = y + 12
            e.Graphics.DrawString("TOTALIZADO POR SUBGRUPOS", prFont_encabezado, Brushes.Black, x, y)
            y = y + 12
            e.Graphics.DrawString("Fecha Informe: " & i_fecha103, prFont_encabezado, Brushes.Black, x, y)
            y = y + 12
            e.Graphics.DrawString("Fecha Impresión: " & Date.Now.ToString("dd/MM/yyyy"), prFont_encabezado, Brushes.Black, x, y)
            y = y + 12
            e.Graphics.DrawString("Bodega:" & i_bodega, prFont_encabezado, Brushes.Black, x, y)
            y = y + 20

            'IMPRIMIMOS EL ENCABEZADO DEL DETALLE '
            e.Graphics.DrawString("CONTEO", prFont_encabezado, Brushes.Black, x + 35, y)
            e.Graphics.DrawString("SISTEMA", prFont_encabezado, Brushes.Black, x + 100, y)
            e.Graphics.DrawString("DIFERENCIA", prFont_encabezado, Brushes.Black, x + 165, y)
            y = y + 5
            e.Graphics.DrawString("________________________________________", prFont_encabezado, Brushes.Black, x, y)

        End If

        If otra_hoja = True Then
            y = 20
            salto_pagina = 58
        Else
            y = y + 15
            salto_pagina = 53
        End If

        Dim i As Integer
        'IMPRIMOS EL DETALLE
        For i = Me.inicio To Me.inicio + salto_pagina
            If i < dtconteo.Rows.Count Then
                If Math.Round(Math.Round(CDbl(dtconteo.Rows(i)(4).ToString()), 2) - Math.Round(CDbl(dtconteo.Rows(i)(5).ToString()), 2), 2) <> 0 Then ' para no imprimir las que no tengan diferencias

                    e.Graphics.DrawString(dtconteo.Rows(i)(2).ToString(), Me.Font, Brushes.Black, x - 2, y) 'ref

                    'imprimimos la descripcion, se realiza de esta manera para que pueda mostrar toda la descripcion
                    aux = Trim(dtconteo.Rows(i)(3).ToString())
                    Dim largo As Integer = Len(aux)
                    If largo > tope Then
                        largo = tope
                    End If
                    e.Graphics.DrawString(aux.Substring(0, largo), Me.Font, Brushes.Black, x + 35, y) 'desc
                    y = y + 13

                    e.Graphics.DrawString(Math.Round(CDbl(dtconteo.Rows(i)(4).ToString()), 2), Me.Font, Brushes.Black, x + 35, y) 'cant
                    e.Graphics.DrawString(Math.Round(CDbl(dtconteo.Rows(i)(5).ToString()), 2), Me.Font, Brushes.Black, x + 100, y) 'saldo
                    e.Graphics.DrawString(Math.Round(Math.Round(CDbl(dtconteo.Rows(i)(4).ToString()), 2) - Math.Round(CDbl(dtconteo.Rows(i)(5).ToString()), 2), 2), Me.Font, Brushes.Black, x + 165, y) 'dif
                    y = y + 15
                End If
                If i = Me.inicio + salto_pagina And i < dtconteo.Rows.Count - 1 Then
                    e.HasMorePages = True ' Todavia faltan mas paginas
                    otra_hoja = True
                End If
            Else
                i = Me.inicio + salto_pagina
            End If
        Next

        Me.inicio = Me.inicio + salto_pagina + 1

        If i = dtconteo.Rows.Count - 1 Then
            y = y + 40
            e.Graphics.DrawString(".", Me.Font, Brushes.Black, x, y) 'final
        End If

    End Sub

    Private Sub Impresion_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consultar As New Querys_inventarios
        Dim consultas As New Querys_impresiones_inventarios

        consultar.actualiza_saldo(i_bodega, factu, i_pastse, i_mes, i_fecha)
        dtconteo = consultas.cons_conteo(i_bodega, i_factu, i_pastse, i_mes, i_fecha)

        Me.Refresh()
        Application.DoEvents()

        PrintDocument1.Print()

        Me.Close()

    End Sub
End Class