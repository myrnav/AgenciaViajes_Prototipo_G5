﻿namespace AgenciaViajes_Prototipo_G5
{
    partial class ConsultaEstadoReserva
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Numero Pre reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 49);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Pago";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 31);
            textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(41, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(41, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 109);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(416, 314);
            button1.Name = "button1";
            button1.Size = new Size(167, 64);
            button1.TabIndex = 8;
            button1.Text = "Cancelar Reserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(589, 314);
            button2.Name = "button2";
            button2.Size = new Size(154, 64);
            button2.TabIndex = 9;
            button2.Text = "Volver a Menú Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ConsultaEstadoReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ConsultaEstadoReserva";
            Text = "Consultar Estado de Reserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
    }
}