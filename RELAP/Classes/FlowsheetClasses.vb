﻿'    Main Form Auxiliary Classes
'    
'
'    This file is part of RIFGen.
'
'    RIFGen is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    RIFGen is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with RELAP.  If not, see <http://www.gnu.org/licenses/>.

Imports Microsoft.MSDN.Samples.GraphicObjects
Imports RELAP.RELAP.ClassesBasicasTermodinamica
Imports System.Windows.Forms.CheckedListBox

'Imports RELAP.RELAP.SimulationObjects

Namespace RELAP.FormClasses

    Public Enum TipoAviso
        Informacao
        Aviso
        Erro
    End Enum

    <System.Serializable()> Public Class ClsObjectCollections

        'Declares collections for holding graphic elements of the flowsheet.
        Public SubSystemCollection As Dictionary(Of String, SubSystemGraphic)
        Public MixerCollection As Dictionary(Of String, NodeInGraphic)
        Public SplitterCollection As Dictionary(Of String, NodeOutGraphic)
        Public MaterialStreamCollection As Dictionary(Of String, MaterialStreamGraphic)
        Public EnergyStreamCollection As Dictionary(Of String, EnergyStreamGraphic)
        Public PumpCollection As Dictionary(Of String, PumpGraphic)
        '  Public SeparatorCollection As Dictionary(Of String, VesselGraphic)
        Public CompressorCollection As Dictionary(Of String, CompressorGraphic)
        Public PipeCollection As Dictionary(Of String, PipeGraphic)
        Public AnnulusCollection As Dictionary(Of String, AnnulusGraphic)
        Public BranchCollection As Dictionary(Of String, BranchGraphic)
        Public SeparatorCollection As Dictionary(Of String, SeparatorGraphic)
        Public TurbineCollection As Dictionary(Of String, TurbineGraphic)
        Public AccumulatorCollection As Dictionary(Of String, SubSystemGraphic)
        Public ValveCollection As Dictionary(Of String, ValveGraphic)
        Public SingleVolumeCollection As Dictionary(Of String, SingleVolumeGraphic)
        Public SingleJunctionCollection As Dictionary(Of String, SingleJunctionGraphic)
        Public TimeDependentJunctionCollection As Dictionary(Of String, TimeDependentJunctionGraphic)
        Public HeaterCollection As Dictionary(Of String, HeaterGraphic)
        Public TankCollection As Dictionary(Of String, TankGraphic)
        Public FuelRodCollection As Dictionary(Of String, FuelRodGraphic)
        Public PWRControlRodCollection As Dictionary(Of String, PWRControlRodGraphic)
        Public SimulatorCollection As Dictionary(Of String, SimulatorGraphic)
        Public ConnectorCollection As Dictionary(Of String, ConnectorGraphic)
        Public TPSeparatorCollection As Dictionary(Of String, TPVesselGraphic)
        Public MixerENCollection As Dictionary(Of String, NodeEnGraphic)
        Public AdjustCollection As Dictionary(Of String, AdjustGraphic)
        Public SpecCollection As Dictionary(Of String, SpecGraphic)
        Public RecycleCollection As Dictionary(Of String, RecycleGraphic)
        Public ReactorConversionCollection As Dictionary(Of String, ReactorConversionGraphic)
        Public ReactorEquilibriumCollection As Dictionary(Of String, ReactorEquilibriumGraphic)
        Public ReactorGibbsCollection As Dictionary(Of String, ReactorGibbsGraphic)
        Public ReactorCSTRCollection As Dictionary(Of String, ReactorCSTRGraphic)
        Public ReactorPFRCollection As Dictionary(Of String, ReactorPFRGraphic)
        Public HeatStructureCollection As Dictionary(Of String, HeatStructureGraphic)
        Public ShortcutColumnCollection As Dictionary(Of String, ShorcutColumnGraphic)
        Public DistillationColumnCollection As Dictionary(Of String, DistillationColumnGraphic)
        Public AbsorptionColumnCollection As Dictionary(Of String, AbsorptionColumnGraphic)
        Public RefluxedAbsorberCollection As Dictionary(Of String, RefluxedAbsorberGraphic)
        Public ReboiledAbsorberCollection As Dictionary(Of String, ReboiledAbsorberGraphic)
        Public EnergyRecycleCollection As Dictionary(Of String, EnergyRecycleGraphic)
        Public ComponentSeparatorCollection As Dictionary(Of String, ComponentSeparatorGraphic)
        Public OrificePlateCollection As Dictionary(Of String, OrificePlateGraphic)
        Public CustomUOCollection As Dictionary(Of String, CustomUOGraphic)
        Public CapeOpenUOCollection As Dictionary(Of String, CapeOpenUOGraphic)

        Public ObjectCounter As Dictionary(Of String, Integer)

        Public ObjectCollection As Dictionary(Of String, SimulationObjects_BaseClass)

        'These are collections for holding the actual unit operations instances.
        Public CLCS_FuelRodCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.FuelRod)
        Public CLCS_PWRControlRodCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.PWRControlRod)
        Public CLCS_SubSystemCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Subsystem)
        Public CLCS_TankCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Tank)
        Public CLCS_HeatStructureCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.HeatStructure)
        Public CLCS_PumpCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Pump)
        Public CLCS_SingleVolumeCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.SingleVolume)
        Public CLCS_SingleJunctionCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.SingleJunction)
        Public CLCS_TimeDependentJunctionCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.TimeDependentJunction)
        Public CLCS_PipeCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.pipe)
        Public CLCS_AnnulusCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Annulus)
        Public CLCS_BranchCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Branch)
        Public CLCS_SeparatorCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Separator)
        Public CLCS_ValveCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Valve)
        Public CLCS_TurbineCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Turbine)
        Public CLCS_AccumulatorCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Accumulator)
        Public CLCS_SimulatorCollection As Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Simulator)


        Sub New()

            'Creates all the graphic collections.
            SubSystemCollection = New Dictionary(Of String, SubSystemGraphic)
            MixerCollection = New Dictionary(Of String, NodeInGraphic)
            SplitterCollection = New Dictionary(Of String, NodeOutGraphic)
            MaterialStreamCollection = New Dictionary(Of String, MaterialStreamGraphic)
            EnergyStreamCollection = New Dictionary(Of String, EnergyStreamGraphic)
            PumpCollection = New Dictionary(Of String, PumpGraphic)
            '  SeparatorCollection = New Dictionary(Of String, VesselGraphic)
            CompressorCollection = New Dictionary(Of String, CompressorGraphic)
            PipeCollection = New Dictionary(Of String, PipeGraphic)
            AnnulusCollection = New Dictionary(Of String, AnnulusGraphic)
            BranchCollection = New Dictionary(Of String, BranchGraphic)
            SeparatorCollection = New Dictionary(Of String, SeparatorGraphic)
            ValveCollection = New Dictionary(Of String, ValveGraphic)
            AccumulatorCollection = New Dictionary(Of String, SubSystemGraphic)
            SingleVolumeCollection = New Dictionary(Of String, SingleVolumeGraphic)
            SingleJunctionCollection = New Dictionary(Of String, SingleJunctionGraphic)
            TimeDependentJunctionCollection = New Dictionary(Of String, TimeDependentJunctionGraphic)
            HeaterCollection = New Dictionary(Of String, HeaterGraphic)
            TankCollection = New Dictionary(Of String, TankGraphic)
            FuelRodCollection = New Dictionary(Of String, FuelRodGraphic)
            PWRControlRodCollection = New Dictionary(Of String, PWRControlRodGraphic)
            SimulatorCollection = New Dictionary(Of String, SimulatorGraphic)
            ConnectorCollection = New Dictionary(Of String, ConnectorGraphic)
            TPSeparatorCollection = New Dictionary(Of String, TPVesselGraphic)
            TurbineCollection = New Dictionary(Of String, TurbineGraphic)
            MixerENCollection = New Dictionary(Of String, NodeEnGraphic)
            AdjustCollection = New Dictionary(Of String, AdjustGraphic)
            SpecCollection = New Dictionary(Of String, SpecGraphic)
            RecycleCollection = New Dictionary(Of String, RecycleGraphic)
            ReactorConversionCollection = New Dictionary(Of String, ReactorConversionGraphic)
            ReactorEquilibriumCollection = New Dictionary(Of String, ReactorEquilibriumGraphic)
            ReactorGibbsCollection = New Dictionary(Of String, ReactorGibbsGraphic)
            ReactorCSTRCollection = New Dictionary(Of String, ReactorCSTRGraphic)
            ReactorPFRCollection = New Dictionary(Of String, ReactorPFRGraphic)
            HeatStructureCollection = New Dictionary(Of String, HeatStructureGraphic)
            ShortcutColumnCollection = New Dictionary(Of String, ShorcutColumnGraphic)
            DistillationColumnCollection = New Dictionary(Of String, DistillationColumnGraphic)
            AbsorptionColumnCollection = New Dictionary(Of String, AbsorptionColumnGraphic)
            RefluxedAbsorberCollection = New Dictionary(Of String, RefluxedAbsorberGraphic)
            ReboiledAbsorberCollection = New Dictionary(Of String, ReboiledAbsorberGraphic)
            EnergyRecycleCollection = New Dictionary(Of String, EnergyRecycleGraphic)
            ComponentSeparatorCollection = New Dictionary(Of String, ComponentSeparatorGraphic)
            OrificePlateCollection = New Dictionary(Of String, OrificePlateGraphic)
            CustomUOCollection = New Dictionary(Of String, CustomUOGraphic)
            CapeOpenUOCollection = New Dictionary(Of String, CapeOpenUOGraphic)

            ObjectCollection = New Dictionary(Of String, SimulationObjects_BaseClass)

            'Creates all the actual unit operations collections.

            '  CLCS_TankCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Tank)
            CLCS_TankCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Tank)
            CLCS_HeatStructureCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.HeatStructure)
            CLCS_PumpCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Pump)
            CLCS_SingleVolumeCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.SingleVolume)
            CLCS_SingleJunctionCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.SingleJunction)
            CLCS_TimeDependentJunctionCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.TimeDependentJunction)
            CLCS_PipeCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.pipe)
            CLCS_AnnulusCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Annulus)
            CLCS_BranchCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Branch)
            CLCS_SeparatorCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Separator)
            CLCS_ValveCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Valve)
            CLCS_TurbineCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Turbine)
            CLCS_AccumulatorCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Accumulator)
            CLCS_FuelRodCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.FuelRod)
            CLCS_PWRControlRodCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.PWRControlRod)
            CLCS_SimulatorCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Simulator)
            CLCS_SubSystemCollection = New Dictionary(Of String, RELAP.SimulationObjects.UnitOps.Subsystem)


        End Sub

        Sub InitializeCounter()

            Me.ObjectCounter = New Dictionary(Of String, Integer)

            With Me.ObjectCounter

                .Add("TANK", Me.TankCollection.Count)
                .Add("HeatStructure", Me.HeatStructureCollection.Count)
                .Add("Pump", Me.PumpCollection.Count)
                .Add("SingleVolume", Me.SingleVolumeCollection.Count)
                .Add("SingleJunction", Me.SingleJunctionCollection.Count)
                .Add("TimeDependentJunction", Me.TimeDependentJunctionCollection.Count)
                .Add("Pipe", Me.PipeCollection.Count)
                .Add("Annulus", Me.AnnulusCollection.Count)
                .Add("Branch", Me.BranchCollection.Count)
                .Add("Separator", Me.SeparatorCollection.Count)
                .Add("Valve", Me.ValveCollection.Count)
                .Add("Turbine", Me.TurbineCollection.Count)
                .Add("Accumulator", Me.AccumulatorCollection.Count)
                .Add("FuelRod", Me.FuelRodCollection.Count)
                .Add("PCR", Me.PWRControlRodCollection.Count)
                .Add("Simulator", Me.SimulatorCollection.Count)
                .Add("SubSystem", Me.SubSystemCollection.Count)
            End With

        End Sub

        Sub UpdateCounter(ByVal item As String)

            Me.ObjectCounter(item) += 1

        End Sub

    End Class

    <System.Serializable()> Public Class ClsFormOptions

        Public AvailableUnitSystems As New Dictionary(Of String, RELAP.SistemasDeUnidades.Unidades)

        Public ins_clcTextboxes As New List(Of String)
        Public ins_clcComboBox As New List(Of String)
        Public ins_chklistCondensibleGases As New List(Of Integer)
        Public ins_hasboron As Boolean
        Public ins_defaultfluid As Boolean
        Public ins_water As Boolean
        Public ins_heavywater As Boolean

        Private _MinorEdit As MinorEdit
        Public Property MinorEdit() As MinorEdit
            Get
                Return _MinorEdit
            End Get
            Set(ByVal value As MinorEdit)
                _MinorEdit = value
            End Set
        End Property
        Public SelectedComponents As Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ConstantProperties)
        Public NotSelectedComponents As Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ConstantProperties)

        Public Databases As Dictionary(Of String, String())

        Public Reactions As Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.Reaction)
        Public ReactionSets As Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ReactionSet)
        Public SimulationMode As String = ""


        Public SelectedUnitSystem As RELAP.SistemasDeUnidades.Unidades

        Public NumberFormat As String = "#0.0####"
        Public FractionNumberFormat As String = "#0.0######"

        Public SempreCalcularFlashPH As Boolean = False

        Public CalculateBubbleAndDewPoints As Boolean = False

        Public SimNome As String = "simulation_title"
        Public SimAutor As String = "simulation_author"
        Public SimComentario As String = "simulation_details"

        Public FilePath As String = ""

        Public BackupFileName As String = ""

        Public CalculatorActivated As Boolean = True


        Public PropertyPackageIOFlashQuickMode As Boolean = True

        Public ThreePhaseFlashStabTestSeverity As Integer = 0
        Public ThreePhaseFlashStabTestCompIds As String() = New String() {}

        Public Password As String = ""
        Public UsePassword As Boolean = False



        Sub New()

            SelectedComponents = New Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ConstantProperties)
            NotSelectedComponents = New Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ConstantProperties)
            SelectedUnitSystem = New SistemasDeUnidades.UnidadesSI()
            Reactions = New Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.Reaction)
            ReactionSets = New Dictionary(Of String, RELAP.ClassesBasicasTermodinamica.ReactionSet)
            Databases = New Dictionary(Of String, String())


            With ReactionSets
                .Add("DefaultSet", New ReactionSet("DefaultSet", RELAP.App.GetLocalString("Rxn_DefaultSetName"), RELAP.App.GetLocalString("Rxn_DefaultSetDesc")))
            End With

        End Sub

    End Class
    <System.Serializable()> Public Class InitialSettings

    End Class
    <System.Serializable()> Public Class FlowsheetState

        Public Collections As Byte()
        Public GraphicObjects As Byte()
        Public Options As Byte()
        Public WatchItems As Byte()
        Public TreeViewObjects As Byte()
        Public SpreadsheetDT1 As Byte()
        Public SpreadsheetDT2 As Byte()

        Public Snapshot As Bitmap
        Public Description As String = ""
        Public SaveDate As Date

    End Class

End Namespace
