namespace WinFormsApp2;

partial class Ejercicio1_clase_numeroPar
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
        button1 = new System.Windows.Forms.Button();
        inputTxt = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(32, 95);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(95, 40);
        button1.TabIndex = 1;
        button1.Text = "Comprobar";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // inputTxt
        // 
        inputTxt.Location = new System.Drawing.Point(32, 66);
        inputTxt.Name = "inputTxt";
        inputTxt.Size = new System.Drawing.Size(100, 23);
        inputTxt.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(17, 11);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(133, 30);
        label1.TabIndex = 2;
        label1.Text = "Ingresa un numero";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(163, 143);
        Controls.Add(label1);
        Controls.Add(inputTxt);
        Controls.Add(button1);
        Text = "Names";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox inputTxt;

    private System.Windows.Forms.Button button1;



    #endregion
}