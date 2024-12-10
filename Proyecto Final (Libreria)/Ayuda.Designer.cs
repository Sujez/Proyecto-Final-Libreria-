namespace Proyecto_Final__Libreria_
{
    partial class Ayuda
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
            this.tabAyuda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAyuda
            // 
            this.tabAyuda.Controls.Add(this.tabPage1);
            this.tabAyuda.Controls.Add(this.tabPage2);
            this.tabAyuda.Controls.Add(this.tabPage3);
            this.tabAyuda.Controls.Add(this.tabPage4);
            this.tabAyuda.Controls.Add(this.tabPage5);
            this.tabAyuda.Location = new System.Drawing.Point(12, 12);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.SelectedIndex = 0;
            this.tabAyuda.Size = new System.Drawing.Size(681, 403);
            this.tabAyuda.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Libro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Libro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(673, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar/Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(673, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Editoriales";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(673, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Agregar/Eliminar elementos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 437);
            this.Controls.Add(this.tabAyuda);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.tabAyuda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAyuda;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}