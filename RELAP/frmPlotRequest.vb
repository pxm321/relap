﻿Public Class frmPlotRequest
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Private Sub frmPlotRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

        cboRestartPlotSettings.SelectedIndex = 1
    End Sub

    Private Sub frmPlotRequest_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            cboObjects.DisplayMember = "Tag"
            cboParameter.DisplayMember = "Tag"
            cboParameter.DataSource = New BindingSource(My.Application.ActiveSimulation.FormSurface.FlowsheetDesignSurface.drawingObjects, Nothing)
            cboObjects.DataSource = New BindingSource(My.Application.ActiveSimulation.FormSurface.FlowsheetDesignSurface.drawingObjects, Nothing)
        Catch ex As Exception

        End Try
    End Sub
End Class