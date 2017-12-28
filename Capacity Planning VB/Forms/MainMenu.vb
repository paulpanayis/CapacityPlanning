Public Class MainMenu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gDB.OpenDatabase()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        About.Visible = False
        About.Show(Me)
    End Sub

    Private Sub ctlReports_Load() Handles ctlReport.Clicked
        Reports.Visible = False
        Reports.Show(Me)
    End Sub

    Private Sub ctlSprints_Load() Handles ctlSprint.Clicked
        Sprints.Visible = False
        Sprints.Show()
    End Sub

    Private Sub ctlTeams_Load() Handles ctlTeam.Clicked
        Teams.Visible = False
        Teams.Show(Me)
    End Sub

    Private Sub ctlActuals_Load() Handles ctlVelocity.Clicked
        Velocity.Visible = False
        Velocity.Show(Me)
    End Sub

    Private Sub ctlHolidays_Load() Handles ctlHoliday.Clicked
        Holiday.Visible = False
        Holiday.Show(Me)
    End Sub

    Private Sub ctlCapacityPlans_Load() Handles ctlCapacityPlan.Clicked
        CapacityPlans.Visible = False
        CapacityPlans.Show(Me)
    End Sub

    Private Sub ctlLocations_Clicked() Handles ctlLocations.Clicked
        Locations.Visible = False
        Locations.Show(Me)
    End Sub
End Class