namespace WinFormsApp2;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnAdd = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        lstNames = new System.Windows.Forms.ListBox();
        txtName = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.Location = new System.Drawing.Point(138, 55);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(100, 23);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add Names";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btn1_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(64, 21);
        label1.TabIndex = 1;
        label1.Text = "Names";
        // 
        // lstNames
        // 
        lstNames.FormattingEnabled = true;
        lstNames.Location = new System.Drawing.Point(12, 27);
        lstNames.Name = "lstNames";
        lstNames.Size = new System.Drawing.Size(120, 94);
        lstNames.TabIndex = 2;
        // 
        // txtName
        // 
        txtName.Location = new System.Drawing.Point(138, 26);
        txtName.Name = "txtName";
        txtName.Size = new System.Drawing.Size(100, 23);
        txtName.TabIndex = 3;
        txtName.Text = "Names";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(252, 141);
        Controls.Add(txtName);
        Controls.Add(lstNames);
        Controls.Add(label1);
        Controls.Add(btnAdd);
        Text = "Names";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lstNames;
    private System.Windows.Forms.TextBox txtName;

    private System.Windows.Forms.Button btnAdd;

    #endregion
}