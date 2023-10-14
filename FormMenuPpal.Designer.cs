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
            buttonConsultaDeDisponibilidad = new Button();
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
            label1.Location = new Point(22, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una de las opciones:";
            // 
            // buttonConsultaDeDisponibilidad
            // 
            buttonConsultaDeDisponibilidad.Location = new Point(72, 45);
            buttonConsultaDeDisponibilidad.Margin = new Padding(2);
            buttonConsultaDeDisponibilidad.Name = "buttonConsultaDeDisponibilidad";
            buttonConsultaDeDisponibilidad.Size = new Size(144, 37);
            buttonConsultaDeDisponibilidad.TabIndex = 1;
            buttonConsultaDeDisponibilidad.Text = "Consulta de Disponibilidad de Productos";
            buttonConsultaDeDisponibilidad.UseVisualStyleBackColor = true;
            buttonConsultaDeDisponibilidad.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 85);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(144, 37);
            button2.TabIndex = 2;
            button2.Text = "Armado Itinerarios / Presupuestos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(72, 125);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(144, 37);
            button3.TabIndex = 3;
            button3.Text = "Generación de Pre Reserva";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(72, 166);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(144, 37);
            button4.TabIndex = 4;
            button4.Text = "Confirmación de Reservas";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaEstadoReserva
            // 
            buttonConsultaEstadoReserva.Location = new Point(72, 206);
            buttonConsultaEstadoReserva.Margin = new Padding(2);
            buttonConsultaEstadoReserva.Name = "buttonConsultaEstadoReserva";
            buttonConsultaEstadoReserva.Size = new Size(144, 37);
            buttonConsultaEstadoReserva.TabIndex = 5;
            buttonConsultaEstadoReserva.Text = "Consultar Estado de Reservas";
            buttonConsultaEstadoReserva.UseVisualStyleBackColor = true;
            buttonConsultaEstadoReserva.Click += buttonConsultaEstadoReserva_Click;
            // 
            // button6
            // 
            button6.Location = new Point(300, 206);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(144, 37);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button6);
            Controls.Add(buttonConsultaEstadoReserva);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonConsultaDeDisponibilidad);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormMenuPpal";
            Text = "Menú Principal";
            Load += FormMenuPpal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConsultaDeDisponibilidad;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonConsultaEstadoReserva;
        private Button button6;
    }
}