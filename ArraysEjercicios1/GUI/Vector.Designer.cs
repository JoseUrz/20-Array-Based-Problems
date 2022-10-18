namespace ArraysEjercicios1.GUI
{
    partial class Vector
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.btnCrearVector = new System.Windows.Forms.Button();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.txtResultado2 = new System.Windows.Forms.Label();
            this.cmbAcciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Tamano de Vector:";
            // 
            // txtTamano
            // 
            this.txtTamano.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTamano.Location = new System.Drawing.Point(317, 42);
            this.txtTamano.Multiline = true;
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(142, 36);
            this.txtTamano.TabIndex = 1;
            this.txtTamano.TextChanged += new System.EventHandler(this.txtTamano_TextChanged);
            this.txtTamano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamano_KeyPress);
            // 
            // btnCrearVector
            // 
            this.btnCrearVector.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearVector.Location = new System.Drawing.Point(503, 42);
            this.btnCrearVector.Name = "btnCrearVector";
            this.btnCrearVector.Size = new System.Drawing.Size(94, 36);
            this.btnCrearVector.TabIndex = 2;
            this.btnCrearVector.Text = "Crear";
            this.btnCrearVector.UseVisualStyleBackColor = true;
            this.btnCrearVector.Click += new System.EventHandler(this.btnCrearVector_Click);
            // 
            // listNumeros
            // 
            this.listNumeros.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.ItemHeight = 19;
            this.listNumeros.Location = new System.Drawing.Point(344, 181);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(158, 232);
            this.listNumeros.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(12, 145);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(178, 29);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "Operaciones";
            // 
            // txtResultado2
            // 
            this.txtResultado2.AutoSize = true;
            this.txtResultado2.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado2.Location = new System.Drawing.Point(12, 213);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(166, 27);
            this.txtResultado2.TabIndex = 5;
            this.txtResultado2.Text = "Operaciones";
            // 
            // cmbAcciones
            // 
            this.cmbAcciones.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAcciones.FormattingEnabled = true;
            this.cmbAcciones.Location = new System.Drawing.Point(503, 109);
            this.cmbAcciones.Name = "cmbAcciones";
            this.cmbAcciones.Size = new System.Drawing.Size(329, 31);
            this.cmbAcciones.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(570, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 105);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAcciones);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.listNumeros);
            this.Controls.Add(this.btnCrearVector);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.label1);
            this.Name = "Vector";
            this.Text = "Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTamano;
        private Button btnCrearVector;
        private ListBox listNumeros;
        private Label txtResultado;
        private Label txtResultado2;
        private ComboBox cmbAcciones;
        private Button button1;
    }
}