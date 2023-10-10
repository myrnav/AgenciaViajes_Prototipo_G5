namespace AgenciaViajes_Prototipo_G5
{
    partial class FormMenuPpal
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonConsultaEstadoReserva = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una de las opciones:";
            // 
            // button1
            // 
            button1.Location = new Point(103, 75);
            button1.Name = "button1";
            button1.Size = new Size(206, 61);
            button1.TabIndex = 1;
            button1.Text = "Consulta de Disponibilidad de Productos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 142);
            button2.Name = "button2";
            button2.Size = new Size(206, 61);
            button2.TabIndex = 2;
            button2.Text = "Armado Itinerarios / Presupuestos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(103, 209);
            button3.Name = "button3";
            button3.Size = new Size(206, 61);
            button3.TabIndex = 3;
            button3.Text = "Generación de Pre Reserva";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(103, 276);
            button4.Name = "button4";
            button4.Size = new Size(206, 61);
            button4.TabIndex = 4;
            button4.Text = "Confirmación de Reservas";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaEstadoReserva
            // 
            buttonConsultaEstadoReserva.Location = new Point(103, 343);
            buttonConsultaEstadoReserva.Name = "buttonConsultaEstadoReserva";
            buttonConsultaEstadoReserva.Size = new Size(206, 61);
            buttonConsultaEstadoReserva.TabIndex = 5;
            buttonConsultaEstadoReserva.Text = "Consultar Estado de Reservas";
            buttonConsultaEstadoReserva.UseVisualStyleBackColor = true;
            buttonConsultaEstadoReserva.Click += buttonConsultaEstadoReserva_Click;
            // 
            // button6
            // 
            button6.Location = new Point(429, 343);
            button6.Name = "button6";
            button6.Size = new Size(206, 61);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(buttonConsultaEstadoReserva);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormMenuPpal";
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonConsultaEstadoReserva;
        private Button button6;
    }
}