Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Controls

Namespace DragDropOnBarItem
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4})
			Me.barManager1.MaxItemId = 4
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 1"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4)})
			Me.bar1.Text = "Custom 1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Item1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 2
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "barButtonItem4"
			Me.barButtonItem4.Id = 3
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(292, 24)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 266)
			Me.barDockControlBottom.Size = New System.Drawing.Size(292, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 242)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(292, 24)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 242)
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(72, 160)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(152, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Drag me"
'			Me.simpleButton1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.simpleButton1_MouseMove);
			' 
			' Form1
			' 
			Me.AllowDrop = True
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(292, 266)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "How to drag a custom object and drop it onto an XtraBars toolbar item"
'			Me.DragDrop += New System.Windows.Forms.DragEventHandler(Me.Form1_DragDrop);
'			Me.DragOver += New System.Windows.Forms.DragEventHandler(Me.Form1_DragOver);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub simpleButton1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles simpleButton1.MouseMove
			If e.Button = MouseButtons.Left Then
				TryCast(sender, SimpleButton).DoDragDrop("New caption", DragDropEffects.All)
			End If
		End Sub

		Private DragTargetItem As BarItem

		Private Sub Form1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragOver
			Dim ctrl, prevCtrl As Control
			Dim pt As New Point(e.X, e.Y)

			' disable dropping by default
			e.Effect = DragDropEffects.None
			DragTargetItem = Nothing

			prevCtrl = Me
			ctrl = prevCtrl
			' find the topmost control in Z-order at the mouse position
			Do While ctrl IsNot Nothing
				prevCtrl = ctrl
				ctrl = prevCtrl.GetChildAtPoint(prevCtrl.PointToClient(pt))
			Loop

			' check if the found control is an XtraBars BarControl
			If TypeOf prevCtrl Is CustomBarControl Then
				Dim barCtrl As CustomBarControl
				Dim link As BarItemLink
				barCtrl = TryCast(prevCtrl, CustomBarControl)

				' get the item link at the given point

				link = barCtrl.GetLinkByPoint(pt)
				' identify the link's item
				If link IsNot Nothing AndAlso link.Item.Name = "barButtonItem1" Then
					DragTargetItem = link.Item
					' enable drag&drop
					e.Effect = DragDropEffects.Move
				End If
			End If
		End Sub

		Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
			'perform the desired "drop" action
			If DragTargetItem IsNot Nothing Then
				' We change an item's Caption here
				DragTargetItem.Caption = CStr(e.Data.GetData(GetType(String)))
				DragTargetItem = Nothing
			End If
		End Sub


	End Class
End Namespace
