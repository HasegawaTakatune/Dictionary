namespace Dictionary
{
    partial class CreateDictionaryInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputRow = new System.Windows.Forms.ComboBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputInfo = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.AddDictionaryList = new System.Windows.Forms.CheckedListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputRow
            // 
            this.InputRow.FormattingEnabled = true;
            this.InputRow.Items.AddRange(new object[] {
            "あ行",
            "か行",
            "さ行",
            "た行",
            "な行",
            "は行",
            "ま行",
            "や行",
            "ら行",
            "わ行"});
            this.InputRow.Location = new System.Drawing.Point(23, 91);
            this.InputRow.Name = "InputRow";
            this.InputRow.Size = new System.Drawing.Size(121, 23);
            this.InputRow.TabIndex = 0;
            this.InputRow.Text = "あ行";
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(213, 91);
            this.InputName.MaxLength = 40;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(332, 22);
            this.InputName.TabIndex = 1;
            // 
            // InputInfo
            // 
            this.InputInfo.AcceptsReturn = true;
            this.InputInfo.Location = new System.Drawing.Point(213, 129);
            this.InputInfo.MaxLength = 200;
            this.InputInfo.Multiline = true;
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(417, 75);
            this.InputInfo.TabIndex = 2;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(170, 91);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(37, 15);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "言葉";
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Location = new System.Drawing.Point(170, 129);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(37, 15);
            this.LabelInfo.TabIndex = 4;
            this.LabelInfo.Text = "意味";
            // 
            // AddDictionaryList
            // 
            this.AddDictionaryList.FormattingEnabled = true;
            this.AddDictionaryList.Items.AddRange(new object[] {
            "TEST"});
            this.AddDictionaryList.Location = new System.Drawing.Point(23, 286);
            this.AddDictionaryList.Name = "AddDictionaryList";
            this.AddDictionaryList.Size = new System.Drawing.Size(610, 140);
            this.AddDictionaryList.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(23, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 30);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(664, 286);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 30);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "生成";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(270, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(304, 40);
            this.Title.TabIndex = 8;
            this.Title.Text = "辞書データの生成";
            // 
            // CreateDictionaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddDictionaryList);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.InputInfo);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputRow);
            this.Name = "CreateDictionaryInfo";
            this.Text = "CreateDictionaryInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputRow;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputInfo;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.CheckedListBox AddDictionaryList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label Title;
    }
}