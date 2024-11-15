namespace WinForms_AI_Extensions
{
    partial class MemoEditForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.AIIntegration.Desktop.LanguageInfo languageInfo1 = new DevExpress.AIIntegration.Desktop.LanguageInfo();
            DevExpress.AIIntegration.Desktop.LanguageInfo languageInfo2 = new DevExpress.AIIntegration.Desktop.LanguageInfo();
            DevExpress.AIIntegration.Desktop.LanguageInfo languageInfo3 = new DevExpress.AIIntegration.Desktop.LanguageInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoEditForm));
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
            SuspendLayout();
            // 
            // memoEdit1
            // 
            languageInfo1.Culture = new System.Globalization.CultureInfo("pt");
            languageInfo2.Culture = new System.Globalization.CultureInfo("es");
            languageInfo3.Culture = new System.Globalization.CultureInfo("de");
            behaviorManager1.SetBehaviors(memoEdit1, new DevExpress.Utils.Behaviors.Behavior[] { DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource)), DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource)), DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive), DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditChangeToneBehaviorSource)), DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditChangeStyleBehaviorSource)), DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), new DevExpress.AIIntegration.Desktop.LanguageInfo[] { languageInfo1, languageInfo2, languageInfo3 }), DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource)) });
            memoEdit1.Dock = DockStyle.Fill;
            memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            memoEdit1.Location = new Point(0, 0);
            memoEdit1.Margin = new Padding(2, 2, 2, 2);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(951, 496);
            memoEdit1.TabIndex = 0;
            // 
            // MemoEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 496);
            Controls.Add(memoEdit1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MemoEditForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
