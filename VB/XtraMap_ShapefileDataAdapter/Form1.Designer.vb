Namespace XtraMap_ShapefileDataAdapter

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            vectorItemsLayer1.Name = "MapLayer"
            Me.mapControl1.Layers.Add(vectorItemsLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(757, 509)
            Me.mapControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(757, 509)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl
    End Class
End Namespace
