namespace Cadastros
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.btnCadProfessor = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Location = new System.Drawing.Point(114, 48);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(87, 21);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(114, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedia.Location = new System.Drawing.Point(114, 119);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(62, 21);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Média:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(114, 154);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 21);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deseja Cadastrar?";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(247, 48);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(143, 25);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(247, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 25);
            this.txtNome.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.Location = new System.Drawing.Point(247, 154);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 25);
            this.txtSalario.TabIndex = 9;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedia.Location = new System.Drawing.Point(247, 119);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(143, 25);
            this.txtMedia.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.rdbAluno);
            this.groupBox1.Controls.Add(this.rdbProfessor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(48, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbAluno.Location = new System.Drawing.Point(85, 80);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(69, 24);
            this.rdbAluno.TabIndex = 8;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            this.rdbAluno.CheckedChanged += new System.EventHandler(this.rdbAluno_CheckedChanged);
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbProfessor.Location = new System.Drawing.Point(85, 40);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(94, 24);
            this.rdbProfessor.TabIndex = 7;
            this.rdbProfessor.TabStop = true;
            this.rdbProfessor.Text = "Professor";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            this.rdbProfessor.CheckedChanged += new System.EventHandler(this.rdbProfessor_CheckedChanged);
            // 
            // btnCadProfessor
            // 
            this.btnCadProfessor.BackColor = System.Drawing.SystemColors.Info;
            this.btnCadProfessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadProfessor.Location = new System.Drawing.Point(114, 375);
            this.btnCadProfessor.Name = "btnCadProfessor";
            this.btnCadProfessor.Size = new System.Drawing.Size(99, 54);
            this.btnCadProfessor.TabIndex = 12;
            this.btnCadProfessor.Text = "Cadastrar Professor";
            this.btnCadProfessor.UseVisualStyleBackColor = false;
            this.btnCadProfessor.Click += new System.EventHandler(this.btnCadProfessor_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.BackColor = System.Drawing.SystemColors.Info;
            this.btnCadAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadAluno.Location = new System.Drawing.Point(288, 374);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(102, 55);
            this.btnCadAluno.TabIndex = 13;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = false;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadAluno);
            this.Controls.Add(this.btnCadProfessor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMatricula;
        private Label lblNome;
        private Label lblMedia;
        private Label lblSalario;
        private Label label7;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private TextBox txtSalario;
        private TextBox txtMedia;
        private GroupBox groupBox1;
        private RadioButton rdbAluno;
        private RadioButton rdbProfessor;
        private Button btnCadProfessor;
        private Button btnCadAluno;
    }
}