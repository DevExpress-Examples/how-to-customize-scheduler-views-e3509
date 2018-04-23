Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler

Partial Public Class MainPage
    Inherits UserControl

#Region "#CustomWorkingDays"
    Public Sub New()
        InitializeComponent()

        schedulerControl1.WorkDays.BeginUpdate()
        schedulerControl1.WorkDays.Clear()
        schedulerControl1.WorkDays.Add(WeekDays.Monday Or WeekDays.Tuesday _
                                       Or WeekDays.Wednesday Or WeekDays.Thursday)
        schedulerControl1.WorkDays.EndUpdate()
    End Sub
#End Region
End Class

#Region "#ObjectList"
Public Class ObjectList
    Inherits List(Of Object)
End Class
#End Region

#Region "#CustomTimeScale"
Public Class CustomTimeScale
    Inherits TimeScaleFixedInterval
    ' Fields
    Private Const defaultEnabled As Boolean = True
    ' Methods
    Public Sub New()
        MyBase.New(TimeSpan.FromHours(4.0))
    End Sub
    Protected Overrides ReadOnly Property DefaultDisplayName() As String
        Get
            Return "Custom Scale"
        End Get
    End Property
    Protected Overrides ReadOnly Property DefaultMenuCaption() As String
        Get
            Return "Custom Scale"
        End Get
    End Property
End Class
#End Region
