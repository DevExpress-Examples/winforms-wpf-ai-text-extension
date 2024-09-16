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
            languageInfo1.Culture = new System.Globalization.CultureInfo("es");
            languageInfo2.Culture = new System.Globalization.CultureInfo("de");
            languageInfo3.Culture = new System.Globalization.CultureInfo("pt");
            behaviorManager1.SetBehaviors(memoEdit1, new DevExpress.Utils.Behaviors.Behavior[] { (DevExpress.AIIntegration.WinForms.ExpandBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.ExpandBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.ShortenBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.ShortenBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.ToneStyleBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.ToneStyleBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditToneStyleBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.ExplainBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.ExplainBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.ProofreadBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.ProofreadBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.RewriteStyleBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.RewriteStyleBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditRewriteStyleBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.SummarizeBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.SummarizeBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), new object[] { DevExpress.AIIntegration.SummarizeBehaviorMode.Abstractive, null }), (DevExpress.AIIntegration.WinForms.CustomRequestBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.CustomRequestBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource), new object[] { null }), (DevExpress.AIIntegration.WinForms.TranslateBehavior)DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.TranslateBehavior), typeof(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), new object[] { new DevExpress.AIIntegration.Desktop.LanguageInfo[] { languageInfo1, languageInfo2, languageInfo3 }, null }) });
            memoEdit1.Dock = DockStyle.Fill;
            memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            memoEdit1.Location = new Point(0, 0);
            memoEdit1.Margin = new Padding(3, 2, 3, 2);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(1268, 653);
            memoEdit1.TabIndex = 0;
            // 
            // MemoEditForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 653);
            Controls.Add(memoEdit1);
            Margin = new Padding(3, 2, 3, 2);
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
