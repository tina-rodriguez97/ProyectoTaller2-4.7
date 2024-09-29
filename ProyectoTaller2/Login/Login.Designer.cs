namespace ProyectoTaller2.Login
{
    partial class Login
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.lblLoginBienvenido = new System.Windows.Forms.Label();
            this.pbxLoginInicio = new System.Windows.Forms.PictureBox();
            this.lblLoginDni = new System.Windows.Forms.Label();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.txtLoginInicio = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.btnLoginIniciar = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.BackColor = System.Drawing.Color.Lavender;
            this.gbxLogin.Controls.Add(this.btnLoginIniciar);
            this.gbxLogin.Controls.Add(this.txtLoginPass);
            this.gbxLogin.Controls.Add(this.txtLoginInicio);
            this.gbxLogin.Controls.Add(this.lblLoginPass);
            this.gbxLogin.Controls.Add(this.lblLoginDni);
            this.gbxLogin.Controls.Add(this.pbxLoginInicio);
            this.gbxLogin.Location = new System.Drawing.Point(234, 0);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(389, 449);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            // 
            // pbxLogin
            // 
            this.pbxLogin.Image = global::ProyectoTaller2.Properties.Resources.image2;
            this.pbxLogin.Location = new System.Drawing.Point(0, 0);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(235, 449);
            this.pbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogin.TabIndex = 0;
            this.pbxLogin.TabStop = false;
            // 
            // lblLoginBienvenido
            // 
            this.lblLoginBienvenido.AutoSize = true;
            this.lblLoginBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginBienvenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoginBienvenido.Location = new System.Drawing.Point(33, 202);
            this.lblLoginBienvenido.Name = "lblLoginBienvenido";
            this.lblLoginBienvenido.Size = new System.Drawing.Size(184, 29);
            this.lblLoginBienvenido.TabIndex = 0;
            this.lblLoginBienvenido.Text = "¡BIENVENIDO!";
            // 
            // pbxLoginInicio
            // 
            this.pbxLoginInicio.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLoginInicio.Location = new System.Drawing.Point(58, 29);
            this.pbxLoginInicio.Name = "pbxLoginInicio";
            this.pbxLoginInicio.Size = new System.Drawing.Size(204, 121);
            this.pbxLoginInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLoginInicio.TabIndex = 0;
            this.pbxLoginInicio.TabStop = false;
            // 
            // lblLoginDni
            // 
            this.lblLoginDni.AutoSize = true;
            this.lblLoginDni.Location = new System.Drawing.Point(65, 202);
            this.lblLoginDni.Name = "lblLoginDni";
            this.lblLoginDni.Size = new System.Drawing.Size(26, 13);
            this.lblLoginDni.TabIndex = 1;
            this.lblLoginDni.Text = "DNI";
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Location = new System.Drawing.Point(65, 293);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(61, 13);
            this.lblLoginPass.TabIndex = 2;
            this.lblLoginPass.Text = "Contraseña";
            // 
            // txtLoginInicio
            // 
            this.txtLoginInicio.Location = new System.Drawing.Point(68, 229);
            this.txtLoginInicio.Name = "txtLoginInicio";
            this.txtLoginInicio.Size = new System.Drawing.Size(184, 20);
            this.txtLoginInicio.TabIndex = 3;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(68, 318);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(184, 20);
            this.txtLoginPass.TabIndex = 4;
            // 
            // btnLoginIniciar
            // 
            this.btnLoginIniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoginIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginIniciar.Location = new System.Drawing.Point(177, 392);
            this.btnLoginIniciar.Name = "btnLoginIniciar";
            this.btnLoginIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginIniciar.TabIndex = 5;
            this.btnLoginIniciar.Text = "Iniciar";
            this.btnLoginIniciar.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.lblLoginBienvenido);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.gbxLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.Label lblLoginBienvenido;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.TextBox txtLoginInicio;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginDni;
        private System.Windows.Forms.PictureBox pbxLoginInicio;
        private System.Windows.Forms.Button btnLoginIniciar;
    }
}