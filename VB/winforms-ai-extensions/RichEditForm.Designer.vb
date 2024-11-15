Namespace WinForms_AI_Extensions
	Partial Public Class RichEditForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()
			Dim languageInfo1 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim languageInfo2 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim languageInfo3 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
			richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			encryptDocumentItem1 = New DevExpress.XtraRichEdit.UI.EncryptDocumentItem()
			showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
			pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
			barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			repositoryItemFontEditRichEdit1 = New DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit()
			changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
			fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
			barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
			toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
			toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
			toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
			toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
			toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
			toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
			toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
			toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
			barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
			changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
			changeFontHighlightColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem()
			changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
			makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
			makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
			capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
			toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
			clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
			barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
			toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
			toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
			toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
			barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
			decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
			increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
			rtlToggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.RtlToggleBulletedListItem()
			rtlToggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.RtlToggleNumberingListItem()
			rtlToggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.RtlToggleMultiLevelListItem()
			rtlDecreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.RtlDecreaseIndentItem()
			rtlIncreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.RtlIncreaseIndentItem()
			toggleParagraphLeftToRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphLeftToRightItem()
			toggleParagraphRightToLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphRightToLeftItem()
			barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
			toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
			toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
			toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
			toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
			toggleParagraphAlignmentArabicJustifyGroupItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem()
			toggleParagraphAlignmentArabicJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem()
			toggleParagraphAlignmentJustifyLowItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem()
			toggleParagraphAlignmentJustifyMediumItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem()
			toggleParagraphAlignmentJustifyHighItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem()
			toggleParagraphAlignmentDistributeItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem()
			toggleParagraphAlignmentThaiDistributeItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem()
			toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
			barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
			changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
			setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
			setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
			setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
			showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
			addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
			removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
			addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
			removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
			changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
			galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
			findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
			replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
			insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
			insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
			insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
			insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
			insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
			editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
			editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
			insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
			insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
			insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
			insertObjectItem1 = New DevExpress.XtraRichEdit.UI.InsertObjectItem()
			insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
			fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			infoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
			homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
			clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
			fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
			paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
			stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
			editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
			insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
			pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
			tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
			illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
			linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
			headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
			textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
			symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
			richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(components)
			behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(components)
			DirectCast(ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(repositoryItemFontEditRichEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			SuspendLayout()
			' 
			' richEditControl1
			' 
			languageInfo1.Culture = New System.Globalization.CultureInfo("pt")
			languageInfo2.Culture = New System.Globalization.CultureInfo("es")
			languageInfo3.Culture = New System.Globalization.CultureInfo("de")
			behaviorManager1.SetBehaviors(richEditControl1, New DevExpress.Utils.Behaviors.Behavior() { DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditExpandBehaviorSource)), DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditShortenBehaviorSource)), DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive), DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditExplainBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditChangeToneBehaviorSource)), DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditProofreadBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditChangeStyleBehaviorSource)), DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditTranslateBehaviorSource), New DevExpress.AIIntegration.Desktop.LanguageInfo() { languageInfo1, languageInfo2, languageInfo3 }), DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditCustomRequestBehaviorSource)), DevExpress.AIIntegration.WinForms.GenerateImageDescriptionBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditGenerateDescriptionBehaviorSource)) })
			richEditControl1.Dock = DockStyle.Fill
			richEditControl1.Location = New Point(0, 231)
			richEditControl1.Margin = New Padding(2, 2, 2, 2)
			richEditControl1.MenuManager = ribbonControl1
			richEditControl1.Name = "richEditControl1"
			richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
			richEditControl1.Size = New Size(1421, 1004)
			richEditControl1.TabIndex = 0
			richEditControl1.Text = "Text"
			' 
			' ribbonControl1
			' 
			ribbonControl1.EmptyAreaImageOptions.ImagePadding = New Padding(22, 23, 22, 23)
			ribbonControl1.ExpandCollapseItem.Id = 0
			ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { ribbonControl1.ExpandCollapseItem, undoItem1, redoItem1, fileNewItem1, fileOpenItem1, fileSaveItem1, fileSaveAsItem1, quickPrintItem1, printItem1, printPreviewItem1, encryptDocumentItem1, showDocumentPropertiesFormItem1, pasteItem1, cutItem1, copyItem1, pasteSpecialItem1, barButtonGroup1, changeFontNameItem1, changeFontSizeItem1, fontSizeIncreaseItem1, fontSizeDecreaseItem1, barButtonGroup2, toggleFontBoldItem1, toggleFontItalicItem1, toggleFontUnderlineItem1, toggleFontDoubleUnderlineItem1, toggleFontStrikeoutItem1, toggleFontDoubleStrikeoutItem1, toggleFontSuperscriptItem1, toggleFontSubscriptItem1, barButtonGroup3, changeFontColorItem1, changeFontHighlightColorItem1, changeTextCaseItem1, makeTextUpperCaseItem1, makeTextLowerCaseItem1, capitalizeEachWordCaseItem1, toggleTextCaseItem1, clearFormattingItem1, barButtonGroup4, toggleBulletedListItem1, toggleNumberingListItem1, toggleMultiLevelListItem1, barButtonGroup5, decreaseIndentItem1, increaseIndentItem1, rtlToggleBulletedListItem1, rtlToggleNumberingListItem1, rtlToggleMultiLevelListItem1, rtlDecreaseIndentItem1, rtlIncreaseIndentItem1, toggleParagraphLeftToRightItem1, toggleParagraphRightToLeftItem1, barButtonGroup6, toggleParagraphAlignmentLeftItem1, toggleParagraphAlignmentCenterItem1, toggleParagraphAlignmentRightItem1, toggleParagraphAlignmentJustifyItem1, toggleParagraphAlignmentArabicJustifyGroupItem1, toggleParagraphAlignmentArabicJustifyItem1, toggleParagraphAlignmentJustifyLowItem1, toggleParagraphAlignmentJustifyMediumItem1, toggleParagraphAlignmentJustifyHighItem1, toggleParagraphAlignmentDistributeItem1, toggleParagraphAlignmentThaiDistributeItem1, toggleShowWhitespaceItem1, barButtonGroup7, changeParagraphLineSpacingItem1, setSingleParagraphSpacingItem1, setSesquialteralParagraphSpacingItem1, setDoubleParagraphSpacingItem1, showLineSpacingFormItem1, addSpacingBeforeParagraphItem1, removeSpacingBeforeParagraphItem1, addSpacingAfterParagraphItem1, removeSpacingAfterParagraphItem1, changeParagraphBackColorItem1, galleryChangeStyleItem1, findItem1, replaceItem1, insertPageBreakItem21, insertTableItem1, insertFloatingPictureItem1, insertBookmarkItem1, insertHyperlinkItem1, editPageHeaderItem1, editPageFooterItem1, insertPageNumberItem1, insertPageCountItem1, insertTextBoxItem1, insertObjectItem1, insertSymbolItem1 })
			ribbonControl1.Location = New Point(0, 0)
			ribbonControl1.Margin = New Padding(2, 2, 2, 2)
			ribbonControl1.MaxItemId = 92
			ribbonControl1.Name = "ribbonControl1"
			ribbonControl1.OptionsMenuMinWidth = 247
			ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { fileRibbonPage1, homeRibbonPage1, insertRibbonPage1 })
			ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { repositoryItemFontEditRichEdit1, repositoryItemRichEditFontSizeEdit1 })
			ribbonControl1.Size = New Size(1421, 231)
			' 
			' undoItem1
			' 
			undoItem1.Id = 1
			undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			redoItem1.Id = 2
			redoItem1.Name = "redoItem1"
			' 
			' fileNewItem1
			' 
			fileNewItem1.Id = 3
			fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			fileOpenItem1.Id = 4
			fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			fileSaveItem1.Id = 5
			fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			fileSaveAsItem1.Id = 6
			fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' quickPrintItem1
			' 
			quickPrintItem1.Id = 7
			quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			printItem1.Id = 8
			printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			printPreviewItem1.Id = 9
			printPreviewItem1.Name = "printPreviewItem1"
			' 
			' encryptDocumentItem1
			' 
			encryptDocumentItem1.Id = 10
			encryptDocumentItem1.Name = "encryptDocumentItem1"
			' 
			' showDocumentPropertiesFormItem1
			' 
			showDocumentPropertiesFormItem1.Id = 11
			showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
			' 
			' pasteItem1
			' 
			pasteItem1.Id = 19
			pasteItem1.Name = "pasteItem1"
			' 
			' cutItem1
			' 
			cutItem1.Id = 20
			cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			copyItem1.Id = 21
			copyItem1.Name = "copyItem1"
			' 
			' pasteSpecialItem1
			' 
			pasteSpecialItem1.Id = 22
			pasteSpecialItem1.Name = "pasteSpecialItem1"
			' 
			' barButtonGroup1
			' 
			barButtonGroup1.Id = 12
			barButtonGroup1.Name = "barButtonGroup1"
			barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
			' 
			' changeFontNameItem1
			' 
			changeFontNameItem1.Edit = repositoryItemFontEditRichEdit1
			changeFontNameItem1.Id = 23
			changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' repositoryItemFontEditRichEdit1
			' 
			repositoryItemFontEditRichEdit1.AutoHeight = False
			repositoryItemFontEditRichEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) })
			repositoryItemFontEditRichEdit1.Name = "repositoryItemFontEditRichEdit1"
			' 
			' changeFontSizeItem1
			' 
			changeFontSizeItem1.Edit = repositoryItemRichEditFontSizeEdit1
			changeFontSizeItem1.Id = 24
			changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) })
			repositoryItemRichEditFontSizeEdit1.Control = richEditControl1
			repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' fontSizeIncreaseItem1
			' 
			fontSizeIncreaseItem1.Id = 25
			fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			fontSizeDecreaseItem1.Id = 26
			fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' barButtonGroup2
			' 
			barButtonGroup2.Id = 13
			barButtonGroup2.Name = "barButtonGroup2"
			barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
			' 
			' toggleFontBoldItem1
			' 
			toggleFontBoldItem1.Id = 27
			toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			toggleFontItalicItem1.Id = 28
			toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' toggleFontUnderlineItem1
			' 
			toggleFontUnderlineItem1.Id = 29
			toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
			' 
			' toggleFontDoubleUnderlineItem1
			' 
			toggleFontDoubleUnderlineItem1.Id = 30
			toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
			' 
			' toggleFontStrikeoutItem1
			' 
			toggleFontStrikeoutItem1.Id = 31
			toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
			' 
			' toggleFontDoubleStrikeoutItem1
			' 
			toggleFontDoubleStrikeoutItem1.Id = 32
			toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
			' 
			' toggleFontSuperscriptItem1
			' 
			toggleFontSuperscriptItem1.Id = 33
			toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
			' 
			' toggleFontSubscriptItem1
			' 
			toggleFontSubscriptItem1.Id = 34
			toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
			' 
			' barButtonGroup3
			' 
			barButtonGroup3.Id = 14
			barButtonGroup3.Name = "barButtonGroup3"
			barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
			' 
			' changeFontColorItem1
			' 
			changeFontColorItem1.Id = 35
			changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' changeFontHighlightColorItem1
			' 
			changeFontHighlightColorItem1.Id = 36
			changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1"
			' 
			' changeTextCaseItem1
			' 
			changeTextCaseItem1.Id = 37
			changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(makeTextUpperCaseItem1),
				New DevExpress.XtraBars.LinkPersistInfo(makeTextLowerCaseItem1),
				New DevExpress.XtraBars.LinkPersistInfo(capitalizeEachWordCaseItem1),
				New DevExpress.XtraBars.LinkPersistInfo(toggleTextCaseItem1)
			})
			changeTextCaseItem1.Name = "changeTextCaseItem1"
			' 
			' makeTextUpperCaseItem1
			' 
			makeTextUpperCaseItem1.Id = 38
			makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
			' 
			' makeTextLowerCaseItem1
			' 
			makeTextLowerCaseItem1.Id = 39
			makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
			' 
			' capitalizeEachWordCaseItem1
			' 
			capitalizeEachWordCaseItem1.Id = 40
			capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
			' 
			' toggleTextCaseItem1
			' 
			toggleTextCaseItem1.Id = 41
			toggleTextCaseItem1.Name = "toggleTextCaseItem1"
			' 
			' clearFormattingItem1
			' 
			clearFormattingItem1.Id = 42
			clearFormattingItem1.Name = "clearFormattingItem1"
			' 
			' barButtonGroup4
			' 
			barButtonGroup4.Id = 15
			barButtonGroup4.Name = "barButtonGroup4"
			barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' toggleBulletedListItem1
			' 
			toggleBulletedListItem1.Id = 43
			toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			' 
			' toggleNumberingListItem1
			' 
			toggleNumberingListItem1.Id = 44
			toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			' 
			' toggleMultiLevelListItem1
			' 
			toggleMultiLevelListItem1.Id = 45
			toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			' 
			' barButtonGroup5
			' 
			barButtonGroup5.Id = 16
			barButtonGroup5.Name = "barButtonGroup5"
			barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
			' 
			' decreaseIndentItem1
			' 
			decreaseIndentItem1.Id = 46
			decreaseIndentItem1.Name = "decreaseIndentItem1"
			' 
			' increaseIndentItem1
			' 
			increaseIndentItem1.Id = 47
			increaseIndentItem1.Name = "increaseIndentItem1"
			' 
			' rtlToggleBulletedListItem1
			' 
			rtlToggleBulletedListItem1.Id = 48
			rtlToggleBulletedListItem1.Name = "rtlToggleBulletedListItem1"
			' 
			' rtlToggleNumberingListItem1
			' 
			rtlToggleNumberingListItem1.Id = 49
			rtlToggleNumberingListItem1.Name = "rtlToggleNumberingListItem1"
			' 
			' rtlToggleMultiLevelListItem1
			' 
			rtlToggleMultiLevelListItem1.Id = 50
			rtlToggleMultiLevelListItem1.Name = "rtlToggleMultiLevelListItem1"
			' 
			' rtlDecreaseIndentItem1
			' 
			rtlDecreaseIndentItem1.Id = 51
			rtlDecreaseIndentItem1.Name = "rtlDecreaseIndentItem1"
			' 
			' rtlIncreaseIndentItem1
			' 
			rtlIncreaseIndentItem1.Id = 52
			rtlIncreaseIndentItem1.Name = "rtlIncreaseIndentItem1"
			' 
			' toggleParagraphLeftToRightItem1
			' 
			toggleParagraphLeftToRightItem1.Id = 53
			toggleParagraphLeftToRightItem1.Name = "toggleParagraphLeftToRightItem1"
			' 
			' toggleParagraphRightToLeftItem1
			' 
			toggleParagraphRightToLeftItem1.Id = 54
			toggleParagraphRightToLeftItem1.Name = "toggleParagraphRightToLeftItem1"
			' 
			' barButtonGroup6
			' 
			barButtonGroup6.Id = 17
			barButtonGroup6.Name = "barButtonGroup6"
			barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			toggleParagraphAlignmentLeftItem1.Id = 55
			toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			toggleParagraphAlignmentCenterItem1.Id = 56
			toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			toggleParagraphAlignmentRightItem1.Id = 57
			toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			toggleParagraphAlignmentJustifyItem1.Id = 58
			toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' toggleParagraphAlignmentArabicJustifyGroupItem1
			' 
			toggleParagraphAlignmentArabicJustifyGroupItem1.Id = 59
			toggleParagraphAlignmentArabicJustifyGroupItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, toggleParagraphAlignmentArabicJustifyItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AJ", ""),
				New DevExpress.XtraBars.LinkPersistInfo(toggleParagraphAlignmentJustifyLowItem1),
				New DevExpress.XtraBars.LinkPersistInfo(toggleParagraphAlignmentJustifyMediumItem1),
				New DevExpress.XtraBars.LinkPersistInfo(toggleParagraphAlignmentJustifyHighItem1)
			})
			toggleParagraphAlignmentArabicJustifyGroupItem1.Name = "toggleParagraphAlignmentArabicJustifyGroupItem1"
			' 
			' toggleParagraphAlignmentArabicJustifyItem1
			' 
			toggleParagraphAlignmentArabicJustifyItem1.Id = 60
			toggleParagraphAlignmentArabicJustifyItem1.Name = "toggleParagraphAlignmentArabicJustifyItem1"
			' 
			' toggleParagraphAlignmentJustifyLowItem1
			' 
			toggleParagraphAlignmentJustifyLowItem1.Id = 61
			toggleParagraphAlignmentJustifyLowItem1.Name = "toggleParagraphAlignmentJustifyLowItem1"
			' 
			' toggleParagraphAlignmentJustifyMediumItem1
			' 
			toggleParagraphAlignmentJustifyMediumItem1.Id = 62
			toggleParagraphAlignmentJustifyMediumItem1.Name = "toggleParagraphAlignmentJustifyMediumItem1"
			' 
			' toggleParagraphAlignmentJustifyHighItem1
			' 
			toggleParagraphAlignmentJustifyHighItem1.Id = 63
			toggleParagraphAlignmentJustifyHighItem1.Name = "toggleParagraphAlignmentJustifyHighItem1"
			' 
			' toggleParagraphAlignmentDistributeItem1
			' 
			toggleParagraphAlignmentDistributeItem1.Id = 64
			toggleParagraphAlignmentDistributeItem1.Name = "toggleParagraphAlignmentDistributeItem1"
			' 
			' toggleParagraphAlignmentThaiDistributeItem1
			' 
			toggleParagraphAlignmentThaiDistributeItem1.Id = 65
			toggleParagraphAlignmentThaiDistributeItem1.Name = "toggleParagraphAlignmentThaiDistributeItem1"
			' 
			' toggleShowWhitespaceItem1
			' 
			toggleShowWhitespaceItem1.Id = 66
			toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' barButtonGroup7
			' 
			barButtonGroup7.Id = 18
			barButtonGroup7.Name = "barButtonGroup7"
			barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
			' 
			' changeParagraphLineSpacingItem1
			' 
			changeParagraphLineSpacingItem1.Id = 67
			changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(setSingleParagraphSpacingItem1),
				New DevExpress.XtraBars.LinkPersistInfo(setSesquialteralParagraphSpacingItem1),
				New DevExpress.XtraBars.LinkPersistInfo(setDoubleParagraphSpacingItem1),
				New DevExpress.XtraBars.LinkPersistInfo(showLineSpacingFormItem1),
				New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""),
				New DevExpress.XtraBars.LinkPersistInfo(removeSpacingBeforeParagraphItem1),
				New DevExpress.XtraBars.LinkPersistInfo(addSpacingAfterParagraphItem1),
				New DevExpress.XtraBars.LinkPersistInfo(removeSpacingAfterParagraphItem1)
			})
			changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
			' 
			' setSingleParagraphSpacingItem1
			' 
			setSingleParagraphSpacingItem1.Id = 68
			setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
			' 
			' setSesquialteralParagraphSpacingItem1
			' 
			setSesquialteralParagraphSpacingItem1.Id = 69
			setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
			' 
			' setDoubleParagraphSpacingItem1
			' 
			setDoubleParagraphSpacingItem1.Id = 70
			setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
			' 
			' showLineSpacingFormItem1
			' 
			showLineSpacingFormItem1.Id = 71
			showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
			' 
			' addSpacingBeforeParagraphItem1
			' 
			addSpacingBeforeParagraphItem1.Id = 72
			addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
			' 
			' removeSpacingBeforeParagraphItem1
			' 
			removeSpacingBeforeParagraphItem1.Id = 73
			removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
			' 
			' addSpacingAfterParagraphItem1
			' 
			addSpacingAfterParagraphItem1.Id = 74
			addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
			' 
			' removeSpacingAfterParagraphItem1
			' 
			removeSpacingAfterParagraphItem1.Id = 75
			removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
			' 
			' changeParagraphBackColorItem1
			' 
			changeParagraphBackColorItem1.Id = 76
			changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
			' 
			' galleryChangeStyleItem1
			' 
			' 
			' 
			' 
			galleryChangeStyleItem1.Gallery.ColumnCount = 10
			galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1 })
			galleryChangeStyleItem1.Gallery.ImageSize = New Size(97, 70)
			galleryChangeStyleItem1.Id = 77
			galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
			' 
			' findItem1
			' 
			findItem1.Id = 78
			findItem1.Name = "findItem1"
			' 
			' replaceItem1
			' 
			replaceItem1.Id = 79
			replaceItem1.Name = "replaceItem1"
			' 
			' insertPageBreakItem21
			' 
			insertPageBreakItem21.Id = 80
			insertPageBreakItem21.Name = "insertPageBreakItem21"
			' 
			' insertTableItem1
			' 
			insertTableItem1.Id = 81
			insertTableItem1.Name = "insertTableItem1"
			' 
			' insertFloatingPictureItem1
			' 
			insertFloatingPictureItem1.Id = 82
			insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
			' 
			' insertBookmarkItem1
			' 
			insertBookmarkItem1.Id = 83
			insertBookmarkItem1.Name = "insertBookmarkItem1"
			' 
			' insertHyperlinkItem1
			' 
			insertHyperlinkItem1.Id = 84
			insertHyperlinkItem1.Name = "insertHyperlinkItem1"
			' 
			' editPageHeaderItem1
			' 
			editPageHeaderItem1.Id = 85
			editPageHeaderItem1.Name = "editPageHeaderItem1"
			' 
			' editPageFooterItem1
			' 
			editPageFooterItem1.Id = 86
			editPageFooterItem1.Name = "editPageFooterItem1"
			' 
			' insertPageNumberItem1
			' 
			insertPageNumberItem1.Id = 87
			insertPageNumberItem1.Name = "insertPageNumberItem1"
			' 
			' insertPageCountItem1
			' 
			insertPageCountItem1.Id = 88
			insertPageCountItem1.Name = "insertPageCountItem1"
			' 
			' insertTextBoxItem1
			' 
			insertTextBoxItem1.Id = 89
			insertTextBoxItem1.Name = "insertTextBoxItem1"
			' 
			' insertObjectItem1
			' 
			insertObjectItem1.Id = 90
			insertObjectItem1.Name = "insertObjectItem1"
			' 
			' insertSymbolItem1
			' 
			insertSymbolItem1.Id = 91
			insertSymbolItem1.Name = "insertSymbolItem1"
			' 
			' fileRibbonPage1
			' 
			fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { commonRibbonPageGroup1, infoRibbonPageGroup1 })
			fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			commonRibbonPageGroup1.Text = ""
			' 
			' infoRibbonPageGroup1
			' 
			infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
			infoRibbonPageGroup1.Text = ""
			' 
			' homeRibbonPage1
			' 
			homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { clipboardRibbonPageGroup1, fontRibbonPageGroup1, paragraphRibbonPageGroup1, stylesRibbonPageGroup1, editingRibbonPageGroup1 })
			homeRibbonPage1.Name = "homeRibbonPage1"
			reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
			reduceOperation1.GroupName = Nothing
			reduceOperation1.ItemLinkIndex = 0
			reduceOperation1.ItemLinksCount = 0
			reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
			homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
			' 
			' clipboardRibbonPageGroup1
			' 
			clipboardRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
			clipboardRibbonPageGroup1.Text = ""
			' 
			' fontRibbonPageGroup1
			' 
			fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True
			fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			fontRibbonPageGroup1.Text = ""
			' 
			' paragraphRibbonPageGroup1
			' 
			paragraphRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True
			paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
			paragraphRibbonPageGroup1.Text = ""
			' 
			' stylesRibbonPageGroup1
			' 
			stylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True
			stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
			stylesRibbonPageGroup1.Text = ""
			' 
			' editingRibbonPageGroup1
			' 
			editingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
			editingRibbonPageGroup1.Text = ""
			' 
			' insertRibbonPage1
			' 
			insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { pagesRibbonPageGroup1, tablesRibbonPageGroup1, illustrationsRibbonPageGroup1, linksRibbonPageGroup1, headerFooterRibbonPageGroup1, textRibbonPageGroup1, symbolsRibbonPageGroup1 })
			insertRibbonPage1.Name = "insertRibbonPage1"
			' 
			' pagesRibbonPageGroup1
			' 
			pagesRibbonPageGroup1.AllowTextClipping = False
			pagesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
			pagesRibbonPageGroup1.Text = ""
			' 
			' tablesRibbonPageGroup1
			' 
			tablesRibbonPageGroup1.AllowTextClipping = False
			tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
			tablesRibbonPageGroup1.Text = ""
			' 
			' illustrationsRibbonPageGroup1
			' 
			illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
			illustrationsRibbonPageGroup1.Text = ""
			' 
			' linksRibbonPageGroup1
			' 
			linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
			linksRibbonPageGroup1.Text = ""
			' 
			' headerFooterRibbonPageGroup1
			' 
			headerFooterRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
			headerFooterRibbonPageGroup1.Text = ""
			' 
			' textRibbonPageGroup1
			' 
			textRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			textRibbonPageGroup1.Name = "textRibbonPageGroup1"
			textRibbonPageGroup1.Text = ""
			' 
			' symbolsRibbonPageGroup1
			' 
			symbolsRibbonPageGroup1.AllowTextClipping = False
			symbolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
			symbolsRibbonPageGroup1.Text = ""
			' 
			' richEditBarController1
			' 
			richEditBarController1.BarItems.Add(undoItem1)
			richEditBarController1.BarItems.Add(redoItem1)
			richEditBarController1.BarItems.Add(fileNewItem1)
			richEditBarController1.BarItems.Add(fileOpenItem1)
			richEditBarController1.BarItems.Add(fileSaveItem1)
			richEditBarController1.BarItems.Add(fileSaveAsItem1)
			richEditBarController1.BarItems.Add(quickPrintItem1)
			richEditBarController1.BarItems.Add(printItem1)
			richEditBarController1.BarItems.Add(printPreviewItem1)
			richEditBarController1.BarItems.Add(encryptDocumentItem1)
			richEditBarController1.BarItems.Add(showDocumentPropertiesFormItem1)
			richEditBarController1.BarItems.Add(pasteItem1)
			richEditBarController1.BarItems.Add(cutItem1)
			richEditBarController1.BarItems.Add(copyItem1)
			richEditBarController1.BarItems.Add(pasteSpecialItem1)
			richEditBarController1.BarItems.Add(changeFontNameItem1)
			richEditBarController1.BarItems.Add(changeFontSizeItem1)
			richEditBarController1.BarItems.Add(fontSizeIncreaseItem1)
			richEditBarController1.BarItems.Add(fontSizeDecreaseItem1)
			richEditBarController1.BarItems.Add(toggleFontBoldItem1)
			richEditBarController1.BarItems.Add(toggleFontItalicItem1)
			richEditBarController1.BarItems.Add(toggleFontUnderlineItem1)
			richEditBarController1.BarItems.Add(toggleFontDoubleUnderlineItem1)
			richEditBarController1.BarItems.Add(toggleFontStrikeoutItem1)
			richEditBarController1.BarItems.Add(toggleFontDoubleStrikeoutItem1)
			richEditBarController1.BarItems.Add(toggleFontSuperscriptItem1)
			richEditBarController1.BarItems.Add(toggleFontSubscriptItem1)
			richEditBarController1.BarItems.Add(changeFontColorItem1)
			richEditBarController1.BarItems.Add(changeFontHighlightColorItem1)
			richEditBarController1.BarItems.Add(makeTextUpperCaseItem1)
			richEditBarController1.BarItems.Add(makeTextLowerCaseItem1)
			richEditBarController1.BarItems.Add(capitalizeEachWordCaseItem1)
			richEditBarController1.BarItems.Add(toggleTextCaseItem1)
			richEditBarController1.BarItems.Add(changeTextCaseItem1)
			richEditBarController1.BarItems.Add(clearFormattingItem1)
			richEditBarController1.BarItems.Add(toggleBulletedListItem1)
			richEditBarController1.BarItems.Add(toggleNumberingListItem1)
			richEditBarController1.BarItems.Add(toggleMultiLevelListItem1)
			richEditBarController1.BarItems.Add(decreaseIndentItem1)
			richEditBarController1.BarItems.Add(increaseIndentItem1)
			richEditBarController1.BarItems.Add(rtlToggleBulletedListItem1)
			richEditBarController1.BarItems.Add(rtlToggleNumberingListItem1)
			richEditBarController1.BarItems.Add(rtlToggleMultiLevelListItem1)
			richEditBarController1.BarItems.Add(rtlDecreaseIndentItem1)
			richEditBarController1.BarItems.Add(rtlIncreaseIndentItem1)
			richEditBarController1.BarItems.Add(toggleParagraphLeftToRightItem1)
			richEditBarController1.BarItems.Add(toggleParagraphRightToLeftItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentLeftItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentCenterItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentRightItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentJustifyItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentArabicJustifyItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentJustifyLowItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentJustifyMediumItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentJustifyHighItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentArabicJustifyGroupItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentDistributeItem1)
			richEditBarController1.BarItems.Add(toggleParagraphAlignmentThaiDistributeItem1)
			richEditBarController1.BarItems.Add(toggleShowWhitespaceItem1)
			richEditBarController1.BarItems.Add(setSingleParagraphSpacingItem1)
			richEditBarController1.BarItems.Add(setSesquialteralParagraphSpacingItem1)
			richEditBarController1.BarItems.Add(setDoubleParagraphSpacingItem1)
			richEditBarController1.BarItems.Add(showLineSpacingFormItem1)
			richEditBarController1.BarItems.Add(addSpacingBeforeParagraphItem1)
			richEditBarController1.BarItems.Add(removeSpacingBeforeParagraphItem1)
			richEditBarController1.BarItems.Add(addSpacingAfterParagraphItem1)
			richEditBarController1.BarItems.Add(removeSpacingAfterParagraphItem1)
			richEditBarController1.BarItems.Add(changeParagraphLineSpacingItem1)
			richEditBarController1.BarItems.Add(changeParagraphBackColorItem1)
			richEditBarController1.BarItems.Add(galleryChangeStyleItem1)
			richEditBarController1.BarItems.Add(findItem1)
			richEditBarController1.BarItems.Add(replaceItem1)
			richEditBarController1.BarItems.Add(insertPageBreakItem21)
			richEditBarController1.BarItems.Add(insertTableItem1)
			richEditBarController1.BarItems.Add(insertFloatingPictureItem1)
			richEditBarController1.BarItems.Add(insertBookmarkItem1)
			richEditBarController1.BarItems.Add(insertHyperlinkItem1)
			richEditBarController1.BarItems.Add(editPageHeaderItem1)
			richEditBarController1.BarItems.Add(editPageFooterItem1)
			richEditBarController1.BarItems.Add(insertPageNumberItem1)
			richEditBarController1.BarItems.Add(insertPageCountItem1)
			richEditBarController1.BarItems.Add(insertTextBoxItem1)
			richEditBarController1.BarItems.Add(insertObjectItem1)
			richEditBarController1.BarItems.Add(insertSymbolItem1)
			richEditBarController1.Control = richEditControl1
			' 
			' RichEditForm
			' 
			AutoScaleDimensions = New SizeF(9F, 19F)
			AutoScaleMode = AutoScaleMode.Font
			ClientSize = New Size(1421, 1235)
			Controls.Add(richEditControl1)
			Controls.Add(ribbonControl1)
			Margin = New Padding(2, 2, 2, 2)
			Name = "RichEditForm"
			Ribbon = ribbonControl1
			Text = "RichEditForm"
			DirectCast(ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(repositoryItemFontEditRichEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
			ResumeLayout(False)
			PerformLayout()
		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private encryptDocumentItem1 As DevExpress.XtraRichEdit.UI.EncryptDocumentItem
		Private showDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
		Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
		Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
		Private repositoryItemFontEditRichEdit1 As DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit
		Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
		Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
		Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
		Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
		Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
		Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
		Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
		Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
		Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
		Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
		Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
		Private changeFontHighlightColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem
		Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
		Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
		Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
		Private capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem
		Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
		Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
		Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
		Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
		Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
		Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
		Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
		Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
		Private rtlToggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.RtlToggleBulletedListItem
		Private rtlToggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.RtlToggleNumberingListItem
		Private rtlToggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.RtlToggleMultiLevelListItem
		Private rtlDecreaseIndentItem1 As DevExpress.XtraRichEdit.UI.RtlDecreaseIndentItem
		Private rtlIncreaseIndentItem1 As DevExpress.XtraRichEdit.UI.RtlIncreaseIndentItem
		Private toggleParagraphLeftToRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphLeftToRightItem
		Private toggleParagraphRightToLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphRightToLeftItem
		Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
		Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
		Private toggleParagraphAlignmentArabicJustifyGroupItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem
		Private toggleParagraphAlignmentArabicJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem
		Private toggleParagraphAlignmentJustifyLowItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem
		Private toggleParagraphAlignmentJustifyMediumItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem
		Private toggleParagraphAlignmentJustifyHighItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem
		Private toggleParagraphAlignmentDistributeItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem
		Private toggleParagraphAlignmentThaiDistributeItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem
		Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
		Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
		Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
		Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
		Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
		Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
		Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
		Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
		Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
		Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
		Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
		Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
		Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
		Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
		Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
		Private insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
		Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
		Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
		Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
		Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
		Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
		Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
		Private insertObjectItem1 As DevExpress.XtraRichEdit.UI.InsertObjectItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
		Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
		Private infoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
		Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
		Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
		Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
		Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
		Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
		Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
		Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
		Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
		Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
		Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
		Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
		Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
		Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
		Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
	End Class
End Namespace