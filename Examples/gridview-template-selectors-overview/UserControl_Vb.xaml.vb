Public Class Default_Vb


' #region gridview-template-selectors-overview_1
Public Class SampleTemplateSelector
    Inherits DataTemplateSelector
    Public Overloads Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
        If TypeOf item Is League Then
            Return Me.LeagueTemplate
        ElseIf TypeOf item Is Division Then
            Return Me.DivisionTemplate
        ElseIf TypeOf item Is Team Then
            Return Me.TeamTemplate
        End If
        Return Nothing
    End Function
Private _LeagueTemplate As DataTemplate
    Public Property LeagueTemplate() As DataTemplate
        Get
            Return _LeagueTemplate
        End Get
        Set(ByVal value As DataTemplate)
            _LeagueTemplate = value
        End Set
    End Property
Private _DivisionTemplate As DataTemplate
    Public Property DivisionTemplate() As DataTemplate
        Get
            Return _DivisionTemplate
        End Get
        Set(ByVal value As DataTemplate)
            _DivisionTemplate = value
        End Set
    End Property
Private _TeamTemplate As DataTemplate
    Public Property TeamTemplate() As DataTemplate
        Get
            Return _TeamTemplate
        End Get
        Set(ByVal value As DataTemplate)
            _TeamTemplate = value
        End Set
    End Property
End Class
' #endregion
End Class
