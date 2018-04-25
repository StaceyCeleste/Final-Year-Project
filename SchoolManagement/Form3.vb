Imports SchoolManagement.Form1
Public Class Form3
    Private Access As New DBControl

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User
    End Sub

    ' Sets Background Images 
    ' Default Background Image
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.DSS_3
    End Sub

    ' Winter Background Images
    Private Sub SnowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnowToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter1
    End Sub

    Private Sub SunshineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SunshineToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter2
    End Sub

    Private Sub WinterSunsetSkyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinterSunsetSkyToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter3
    End Sub

    Private Sub WinterLakeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinterLakeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter4
    End Sub

    Private Sub WinterMountainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinterMountainToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter6
    End Sub

    Private Sub WinterTreesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinterTreesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Winter7
    End Sub

    ' Autumn Background Images
    Private Sub AutumnLeavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnLeavesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn1
    End Sub

    Private Sub AutumnNightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnNightToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn2
    End Sub

    Private Sub AutumnTreesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnTreesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn3
    End Sub

    Private Sub AutumnRoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnRoadToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn4
    End Sub

    Private Sub AutumnSunshineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnSunshineToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn5
    End Sub

    Private Sub AutumnBenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnBenchToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn6
    End Sub

    Private Sub AutumnRiverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnRiverToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn7
    End Sub

    Private Sub AutumnParkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnParkToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn8
    End Sub

    Private Sub AutumnWaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnWaterToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn81
    End Sub

    Private Sub AutumnLakeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnLakeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Autumn9
    End Sub

    ' Spring Background Images
    Private Sub SpringSkyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringSkyToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring1
    End Sub

    Private Sub SpringTreeBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringTreeBranchToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring2
    End Sub

    Private Sub SpringLakeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringLakeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring3
    End Sub

    Private Sub SpringNightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringNightToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring4
    End Sub

    Private Sub SpringParkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringParkToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring5
    End Sub

    Private Sub SpringSunshineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringSunshineToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring6
    End Sub

    Private Sub SpringFlowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringFlowersToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring7
    End Sub

    Private Sub SpringWindyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringWindyToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Spring8
    End Sub

    ' Summer Background Images
    Private Sub SummerNightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummerNightToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Summer1
    End Sub

    Private Sub SummerSunsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummerSunsetToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Summer2
    End Sub

    Private Sub SummerParkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummerParkToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Summer3
    End Sub

    Private Sub SummerBeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummerBeachToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Summer4
    End Sub

    ' Exit Button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Add Student Button
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Form4.Show()
    End Sub

    ' View Current Student Button
    Private Sub CurrentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentToolStripMenuItem.Click
        CurrentStudent.Show()
    End Sub

    ' Admin Team Button
    Private Sub AdminTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminTeamToolStripMenuItem.Click
        AdminTeam.Show()
    End Sub

    ' Rejection List Button
    Private Sub RejectionListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RejectionListsToolStripMenuItem.Click
        RejectionList.Show()
    End Sub

    ' Transfers List Button
    Private Sub TransfersListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransfersListsToolStripMenuItem.Click
        TransferList.Show()
    End Sub

    ' Waiting List Button
    Private Sub WaitingListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WaitingListToolStripMenuItem1.Click
        WaitingList.Show()
    End Sub

    ' School Leavers Button
    Private Sub SchoolLeaversToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolLeaversToolStripMenuItem.Click
        SchoolLeavers.Show()
    End Sub


    ' Classes Button
    Private Sub ClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesToolStripMenuItem.Click
        Classes.Show()
    End Sub

    ' Class Placement Button
    Private Sub ClassPlacementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassPlacementsToolStripMenuItem.Click
        ClassPlacement.Show()
    End Sub

    ' Nutritional Details Button
    Private Sub NutritionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NutritionDetailsToolStripMenuItem.Click
        NutritionDets.Show()
    End Sub

    ' Menu Button
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        MenuForm.Show()
    End Sub

    ' Referrals Button
    Private Sub ReferralsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferralsToolStripMenuItem.Click
        ReferralsForm.Show()
    End Sub

    ' Children's Homes Button
    Private Sub ChildrensHomesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChildrensHomesToolStripMenuItem.Click
        ChildrensHomes.Show()
    End Sub

    ' Personal Details Button
    Private Sub PersonalDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalDetailsToolStripMenuItem.Click
        Parents.Show()
    End Sub

    ' Interview Results Button
    Private Sub InterviewResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterviewResultsToolStripMenuItem.Click
        InterviewResults.Show()
    End Sub

    ' Current Parents Button
    Private Sub CurrentParentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentParentsToolStripMenuItem.Click
        CurrentParent.Show()
    End Sub

    ' Add Staff Button
    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        AddStaff.Show()
    End Sub

    ' Existing Staff Button
    Private Sub ExistingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistingToolStripMenuItem.Click
        ExistingStaff.Show()
    End Sub

    ' Leave Register Button
    Private Sub LeaveRegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeaveRegisterToolStripMenuItem1.Click
        StaffLeave.Show()
    End Sub

    ' SGB Members Button
    Private Sub SGBMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SGBMembersToolStripMenuItem.Click
        SGBMembers.Show()
    End Sub

    ' SGB Executive Committee Button
    Private Sub SGBExecutiveCommitteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SGBExecutiveCommitteeToolStripMenuItem.Click
        ExecCommittee.Show()
    End Sub

    ' Upcoming Excursions Button
    Private Sub VenuesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VenuesToolStripMenuItem2.Click
        UpcomingExcursions.Show()
    End Sub

    ' Excursion Details Button
    Private Sub ExcursionDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExcursionDetailsToolStripMenuItem1.Click
        Excursions.Show()
    End Sub

    ' Learner Time Management Button
    Private Sub TimeManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeManagementToolStripMenuItem.Click
        LearnerTimeMan.Show()
    End Sub

    ' Codes of Sports Button
    Private Sub SportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsToolStripMenuItem.Click
        CodesOfSports.Show()
    End Sub

    ' Sports Participants Button
    Private Sub ParticipantsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParticipantsToolStripMenuItem1.Click
        SportsParticipants.Show()
    End Sub

    ' House Details Button
    Private Sub HouseDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HouseDetailsToolStripMenuItem1.Click
        HouseDetails.Show()
    End Sub

    ' Sports Events Button
    Private Sub SportsEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsEventsToolStripMenuItem.Click
        SportsEvents.Show()
    End Sub

    ' Security Committee Button
    Private Sub CommitteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeToolStripMenuItem.Click
        SecurityCommittee.Show()
    End Sub

    ' Injuries Form Button
    Private Sub InjuriesSustainedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InjuriesSustainedToolStripMenuItem.Click
        InjuriesForm.Show()
    End Sub

    ' Searches Button
    Private Sub SearchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchesToolStripMenuItem.Click
        Searches.Show()
    End Sub

    ' School Walkers Button
    Private Sub SchoolWalkersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SchoolWalkersToolStripMenuItem1.Click
        SchoolWalkers.Show()
    End Sub

    ' Drivers Button
    Private Sub DriversToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriversToolStripMenuItem.Click
        Drivers.Show()
    End Sub

    ' Insurance Button
    Private Sub InsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsuranceToolStripMenuItem.Click
        InsuranceDetails.Show()
    End Sub

    ' vehicle Details Button
    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        VehicleDetails.Show()
    End Sub

    ' Accidents Log Button
    Private Sub AccidentsLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccidentsLogToolStripMenuItem.Click
        AccidentsLog.Show()
    End Sub
    ' Logout Button
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    ' Transport Waiting List Button
    Private Sub WaitingListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WaitingListToolStripMenuItem2.Click
        TransportWaitingList.Show()
    End Sub

    ' School Transport Button
    Private Sub SchoolTransportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SchoolTransportToolStripMenuItem1.Click
        SchoolTransport.Show()
    End Sub

    ' Public Transport Button
    Private Sub PublicTransportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PublicTransportToolStripMenuItem1.Click
        PublicTransport.Show()
    End Sub

    ' Private Transport Button
    Private Sub PrivateTransportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrivateTransportToolStripMenuItem1.Click
        PrivateTransport.Show()
    End Sub

    Private Sub ServiceHistoryToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ServiceHistoryToolStripMenuItem2.Click
        ServiceHistory.Show()
    End Sub

    Private Sub RepairCompanyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairCompanyDetailsToolStripMenuItem.Click
        ServiceCompanies.Show()
    End Sub

    Private Sub AddServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServiceToolStripMenuItem.Click
        VehicleService.Show()
    End Sub

    Private Sub LogServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogServiceToolStripMenuItem.Click
        NewService.Show()
    End Sub

    Private Sub ServiceHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceHistoryToolStripMenuItem.Click
        VehServiceHist.Show()
    End Sub

    Private Sub LocalCouncillorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalCouncillorsToolStripMenuItem.Click
        LocalCouncillors.Show()
    End Sub

    Private Sub ReligiousOrgsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReligiousOrgsToolStripMenuItem.Click
        ReligiousOrgs.Show()
    End Sub

    Private Sub SchoolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolsToolStripMenuItem.Click
        Schools.Show()
    End Sub

    Private Sub CommunityMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommunityMembersToolStripMenuItem.Click
        CommunityMembers.Show()
    End Sub

    Private Sub AssetRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetRegisterToolStripMenuItem.Click
        AssetReg.Show()
    End Sub

    Private Sub StockRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockRegisterToolStripMenuItem.Click
        StockReg.Show()
    End Sub

    Private Sub StockTakeResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockTakeResultsToolStripMenuItem.Click
        StockTakeRes.Show()
    End Sub

    Private Sub PoliceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliceToolStripMenuItem.Click
        PoliceDets.Show()
    End Sub

    Private Sub AmbulanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmbulanceToolStripMenuItem.Click
        AmbulanceDets.Show()
    End Sub

    Private Sub FireDeptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FireDeptToolStripMenuItem.Click
        FireDept.Show()
    End Sub

    Private Sub MedicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalToolStripMenuItem.Click
        MedicalInfo.Show()
    End Sub

    Private Sub EducationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EducationToolStripMenuItem.Click
        EducationDept.Show()
    End Sub

    Private Sub HealthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HealthToolStripMenuItem.Click
        HealthDept.Show()
    End Sub

    Private Sub SocialWelfareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialWelfareToolStripMenuItem.Click
        SocialWelfare.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem2.Click
        SGBAttendance.Show()
    End Sub

    Private Sub VenuesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VenuesToolStripMenuItem1.Click
        FunctionVenues.Show()
    End Sub

    Private Sub InternalFunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternalFunctionsToolStripMenuItem.Click
        InternalFunctions.Show()
    End Sub

    Private Sub ExternalFunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternalFunctionsToolStripMenuItem.Click
        ExternalFunctions.Show()
    End Sub

    Private Sub YearPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearPlanToolStripMenuItem.Click
        YearPlanner.Show()
    End Sub

    Private Sub GalleryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalleryToolStripMenuItem.Click
        ViewGallery.Show()
    End Sub

    Private Sub AddImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddImageToolStripMenuItem.Click
        AddImage.Show()
    End Sub

    Private Sub ActiveSignaturiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveSignaturiesToolStripMenuItem.Click
        ActiveSignaturies.Show()
    End Sub

    Private Sub SchoolFeePaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolFeePaymentsToolStripMenuItem.Click
        SchoolFees.Show()
    End Sub

    Private Sub BackupRestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupRestoreToolStripMenuItem.Click
        BackupDB.Show()
    End Sub

    Private Sub DonationsSponsorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationsSponsorsToolStripMenuItem.Click
        DonationsSponsors.Show()
    End Sub

    Private Sub FundraisingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FundraisingToolStripMenuItem.Click
        Fundraising.show()
    End Sub

    Private Sub BankingDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankingDetailsToolStripMenuItem.Click
        BankingDets.Show()
    End Sub

    Private Sub CashReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashReceiptsToolStripMenuItem.Click
        CashReceipts.Show()
    End Sub

    Private Sub JuniorPhaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuniorPhaseToolStripMenuItem.Click
        JuniorPhase.Show()
    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        IntermediatePhase.Show()
    End Sub

    Private Sub PrevocationalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevocationalToolStripMenuItem.Click
        PrevocationalPhase.Show()
    End Sub
End Class