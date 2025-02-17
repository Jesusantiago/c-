using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio2_clase_descuentos
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        inputUser = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        txtDescuento = new System.Windows.Forms.TextBox();
        precioTotal = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 9;
        // 
        // inputUser
        // 
        inputUser.Location = new System.Drawing.Point(51, 74);
        inputUser.Name = "inputUser";
        inputUser.Size = new System.Drawing.Size(131, 23);
        inputUser.TabIndex = 1;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(84, 123);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(66, 23);
        label2.TabIndex = 2;
        label2.Text = "Descuento";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(54, 212);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(142, 24);
        label4.TabIndex = 4;
        label4.Text = "Compra con descuento";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        button1.FlatAppearance.BorderSize = 3;
        button1.Location = new System.Drawing.Point(64, 307);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(117, 35);
        button1.TabIndex = 6;
        button1.Text = "Calcular";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // txtDescuento
        // 
        txtDescuento.Location = new System.Drawing.Point(51, 153);
        txtDescuento.Name = "txtDescuento";
        txtDescuento.Size = new System.Drawing.Size(130, 23);
        txtDescuento.TabIndex = 7;
        txtDescuento.Text = "Descuento dado";
        // 
        // precioTotal
        // 
        precioTotal.Location = new System.Drawing.Point(55, 257);
        precioTotal.Name = "precioTotal";
        precioTotal.Size = new System.Drawing.Size(126, 23);
        precioTotal.TabIndex = 8;
        precioTotal.Text = "Precio con descuento";
        // 
        // Ejercicio2_clase_descuentos
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(238, 387);
        Controls.Add(precioTotal);
        Controls.Add(txtDescuento);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(inputUser);
        Controls.Add(label1);
        Text = "Ejercicio2";
        Load += Ejercicio2_clase_descuentos_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtDescuento;
    private System.Windows.Forms.TextBox precioTotal;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox inputUser;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}