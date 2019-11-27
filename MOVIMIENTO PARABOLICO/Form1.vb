Public Class Form1




    Dim DESPLAZAMIENTOX As Single 'DISTANCIA RECORRIDA EN EL EJE X
    Dim TIEMPO As Single ' TIEMPO TOMADO PARA LOS CALCULOS
    Dim ARRAYX As New ArrayList ' DATOS DE X EN FUNCION DEL TIEMPO
    Dim ARRAYY As New ArrayList ' DATOS DE Y EN FUNCION DEL TIEMPO
    Dim CONTADOR As Integer = 0 ' CONTADOR DE PASO DE TIEMPO



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'HACE LOS CALCULOS Y PONE EN MARCHA EL TIMER
        CALCULAR_TIEMPO_DESPLAZAMIENTOX()
        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub
    Public Sub CALCULAR_TIEMPO_DESPLAZAMIENTOX()
        'LIMPIA LOS ARRAYS Y EL CONTADOR POR SI SE HACEN VARIOS CALCULOS SIN REINICIAR LA APLICACION
        ARRAYX.Clear()
        ARRAYY.Clear()
        CONTADOR = 0
        PictureBox1.Image = Nothing
        Try
            'TOMA DATOS
            Dim ALTURA_INI As Single = CSng(TextBoxALT_INI.Text)
            Dim ALTURA_FIN As Single = CSng(TextBoxALT_FIN.Text)
            Dim VELOCIDAD_INI As Single = CSng(TextBoxVEL_INI.Text)
            Dim ANGULO As Single = CSng(TextBoxANGULO.Text)


            Dim GRAVEDAD As Single = CSng(TextBoxGRAVEDAD.Text)

            'CONVERSION GRADOS A RADIANES
            Dim RADIANES As Single = ANGULO * Math.PI / 180

            'DETERMINAMOS SENO Y COSENO DEL ANGULO
            Dim SENO As Single = Math.Sin(RADIANES)
            LabelSENO.Text = Math.Round(SENO, 3)
            Dim COSENO As Single = Math.Cos(RADIANES)
            LabelCOSENO.Text = Math.Round(COSENO, 3)

            'DETERMINAMOS VECTORES VELOCIDAD INICIAL X E Y
            Dim VECTORY As Single = VELOCIDAD_INI * SENO
            Dim VECTORX As Single = VELOCIDAD_INI * COSENO


            'DETERMINAMOS LA DIFERENCIA DE ALTURAS
            Dim DIFERENCIA_ALTURAS As Single = ALTURA_FIN - ALTURA_INI

            'SI ANGULO ES MAYOR QUE CERO
            If ANGULO > 0 Then

                'DETERMINAMOS LOS DOS POSIBLES TIEMPOS QUE SALEN DE LA ECUACION BICUADRADA APLICANDO (-B +-(B^2-4AC)^0,5)/2A   YA QUE: 1/2 * g* t^2 - Voyt - Yo + Yf = 0
                Dim TIEMPO1 As Single = (VECTORY + Math.Sqrt((VECTORY ^ 2) - (2 * GRAVEDAD * DIFERENCIA_ALTURAS))) / GRAVEDAD
                Label6.Text = Math.Round(TIEMPO1, 2) & " seg"
                Dim TIEMPO2 As Single = (VECTORY - Math.Sqrt((VECTORY ^ 2) - (2 * GRAVEDAD * DIFERENCIA_ALTURAS))) / GRAVEDAD
                Label7.Text = Math.Round(TIEMPO2, 2) & " seg"

                'TOMAREMOS EL TIEMPO EN FUNCION DE LA DIFERENCIA DE ALTURAS. LO NORMAL ES QUE LA ALTURA INICIAL SEA MAYOR O IGUAL A LA FINAL. 
                'If ALTURA_INI >= ALTURA_FIN Then
                '    TIEMPO = Math.Max(TIEMPO1, TIEMPO2)

                'Else
                '    TIEMPO = Math.Min(TIEMPO1, TIEMPO2)
                'End If
                TIEMPO = Math.Max(TIEMPO1, TIEMPO2)
                LabelTIEMPO.Text = Math.Round(TIEMPO, 2) & " seg"

                'EN CASO DE QUE EL ANGULO SEA CERO
            ElseIf ANGULO = 0 Then

                'DETERMINAMOS LOS DOS POSIBLES TIEMPOS QUE SALEN DE LA ECUACION Yf=Yo-(g*t^2)/2 YA QUE EL VECTOR Y SERA IGUAL A 0 => t=+-(2*(Yo-Yf)/g)^0,5 
                Dim TIEMPO1 As Single = Math.Sqrt(2 * (ALTURA_INI - ALTURA_FIN) / GRAVEDAD)
                Label6.Text = Math.Round(TIEMPO1, 2) & " seg"
                Dim TIEMPO2 As Single = Math.Sqrt(2 * (ALTURA_INI - ALTURA_FIN) / GRAVEDAD) * -1
                Label7.Text = Math.Round(TIEMPO2, 2) & " seg"

                'TOMAMOS EL TIEMPO MAYOR DE LOS DOS POSIBLES. EN LA MAYORIA DE LOS EJERCICIOS SERA EL UTIL. AUNQUE NO SIEMPRE
                TIEMPO = Math.Max(TIEMPO1, TIEMPO2)
                LabelTIEMPO.Text = Math.Round(TIEMPO, 2) & " seg"

                'EN CASO DE QUE EL ANGULO SEA NEGATIVO
            Else
                MsgBox("REVISA EL VALOR DEL ANGULO")
            End If

            'EL DESPLAZAMIENTO EN X ES IGUAL AL VECTORX POR EL TIEMPO
            DESPLAZAMIENTOX = VECTORX * TIEMPO
            LabelDESPLAZX.Text = Math.Round(DESPLAZAMIENTOX, 2) & " m"

            'CARGAMOS LOS ARRAYS DEL DESPLAZAMIENTO EN X E Y EN FUNCION DEL TIEMPO
            For I = 0 To TIEMPO
                ARRAYX.Add(VECTORX * I)
                ARRAYY.Add(ALTURA_INI + (VECTORY * I) - ((GRAVEDAD / 2) * I ^ 2))
            Next

            ' AÑADE EL RESTO DE LAS MEDIDAS EN CASO DE QUE EL TIEMPO SEA UN NUMERO DECIMAL
            Dim RESTOX As Single = DESPLAZAMIENTOX - ARRAYX(Math.Truncate(TIEMPO))
            If RESTOX > 0 Then
                ARRAYX.Add(DESPLAZAMIENTOX)
                ARRAYY.Add(ALTURA_FIN)
            End If
            'Dim RESTOY As Single = ARRAYY(Math.Truncate(TIEMPO)) - ALTURA_FIN
            'If RESTOY > 0 Then
            '    ARRAYY.Add(ALTURA_FIN)
            'End If

            'CALCULO DE LA ALTURA MAXIMA: EN EL PUNTO DE ALTURA MAXIMA LA VELOCIDAD Y = 0 : VECTORY - GRAVEDAD * TIEMPO = 0 => TIEMPO = VECTORY/GRAVEDAD
            Dim TIEMPOALTURAMAXIMA As Single = VECTORY / GRAVEDAD

            'LA ALTURA MAXIMA = ALTURA INICIAL + (VELOCIDAD MEDIA EN Y * TIEMPO EN ALCANZAR LA ALTURA MAXIMA)
            Dim YALTURAMAXIMA As Single = ALTURA_INI + ((VECTORY / 2) * TIEMPOALTURAMAXIMA)

            'EL PUNTO EN X EN EL MOMENTO EN QUE LA ALTURA ES MAXIMA = VECTORX * TIEMPOALTURAMAXIMA
            Dim XALTURAMAXIMA As Single = VECTORX * TIEMPOALTURAMAXIMA

            LabelCOORDALTURAMAXIMA.Text = Math.Round(XALTURAMAXIMA, 2) & " X ,  " & Math.Round(YALTURAMAXIMA, 2) & " Y"

            'LA VELOCIDAD FINAL EN X SERA LA MISMA QUE LA INCIAL, DADO QUE EN ESTE MOVIMIENTO EL VECTOR X NO VARIA (MOVIMIENTO UNIFORME)
            LabelVELOCIDADFINALX.Text = Math.Round(VECTORX, 2) & " m/s"

            ' LA VELOCIDAD FINAL EN Y SERA LA RESULTANTE DE Vf= Vo-(GRAVEDAD * TIEMPO) 
            LabelVELOCIDADFINALY.Text = Math.Round(VECTORY - (GRAVEDAD * TIEMPO), 2) & " m/s" ' SI TIENE SIGNO NEGATIVO SIGNIFICA QUE ESTA BAJANDO

        Catch ex As Exception
            MsgBox("REVISA LOS VALORES INICIALES")
        End Try


    End Sub

    Public Sub PINTAR()


        'DEFINIMOS EL AREA DE DIBUJO DENTRO DEL PICTUREBOX: RESERVAREMOS UN MARGEN A CADA LADO PARA QUE SE VEA MEJOR LA GRAFICA
        Dim MARGEN As Integer = 50
        Dim ANCHO As Integer = PictureBox1.Width - MARGEN
        Dim ALTO As Integer = PictureBox1.Height - MARGEN
        'DEFINIMOS LOS ELEMENTOS DE DIBUJO
        Dim BM As Bitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim DIBUJO As Graphics = Graphics.FromImage(BM)
        DIBUJO.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim LAPIZX As New Pen(Brushes.Blue, 6)
        Dim LAPIZY As New Pen(Brushes.Red, 6)
        Dim FUENTE As New Font("verdana", 8)
        Try

        
        'DEFINIMOS EL TRAMO A DIBUJAR EN FUNCION DE LAS DIMENSIONES DEL PICTUREBOX MENOS SUS MARGENES
        Dim TRAMO As Single = (ANCHO - MARGEN) / DESPLAZAMIENTOX  ' RATIO PARA QUE EL DESPLAZAMIENTO TOTAL SEA IGUAL AL ANCHO DE LA ZONA DE DIBUJO

        'DIBUJAMOS X Y SU TEXTO
            For I = 0 To CONTADOR
                DIBUJO.DrawLine(LAPIZX, MARGEN, ALTO, MARGEN + (ARRAYX(I) * TRAMO), ALTO)

            Next
            DIBUJO.DrawString(Math.Round(ARRAYX(CONTADOR), 2), FUENTE, Brushes.Cyan, CInt(MARGEN + ARRAYX(CONTADOR) * TRAMO), CInt(ALTO))
            DIBUJO.DrawString("0", FUENTE, Brushes.Cyan, CInt(MARGEN + ARRAYX(0) * TRAMO), CInt(ALTO))

            'DIBUJAMOS Y Y SU TEXTO
            For I = 0 To CONTADOR - 1
                DIBUJO.DrawLine(LAPIZY, CInt(MARGEN + (ARRAYX(I) * TRAMO)), CInt(ALTO - (ARRAYY(I) * TRAMO)), CInt(MARGEN + (ARRAYX(I + 1) * TRAMO)), CInt(ALTO - (ARRAYY(I + 1) * TRAMO)))

            Next
            DIBUJO.DrawString(Math.Round(ARRAYY(CONTADOR), 2), FUENTE, Brushes.DeepPink, CInt(MARGEN + ARRAYX(CONTADOR) * TRAMO), CInt(ALTO - MARGEN - (ARRAYY(CONTADOR) * TRAMO)))
            DIBUJO.DrawString(TextBoxALT_INI.Text, FUENTE, Brushes.DeepPink, CInt(MARGEN + ARRAYX(0) * TRAMO), CInt(ALTO - (ARRAYY(0) * TRAMO)))

            'MOSTRAMOS LA GRAFICA EN EL PICTUREBOX
        PictureBox1.Image = BM
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'CONTROLAMOS QUE EL TIMER SOLO ACTUE EL MISMO NUMERO DE VECES QUE LOS ARRAYS
        If CONTADOR < ARRAYX.Count Then
            PINTAR()
            CONTADOR += 1
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
