namespace Sorting_Algorithms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_array_accesess = new System.Windows.Forms.Label();
            this.lbl_conditions = new System.Windows.Forms.Label();
            this.lbl_moves = new System.Windows.Forms.Label();
            this.num_arraylenght = new System.Windows.Forms.NumericUpDown();
            this.btn_generate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_arraylenght)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_arraylenght);
            this.groupBox1.Controls.Add(this.lbl_moves);
            this.groupBox1.Controls.Add(this.lbl_conditions);
            this.groupBox1.Controls.Add(this.lbl_array_accesess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array Accesses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conditions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moves:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Array Lenght:";
            // 
            // lbl_array_accesess
            // 
            this.lbl_array_accesess.AutoSize = true;
            this.lbl_array_accesess.Location = new System.Drawing.Point(119, 27);
            this.lbl_array_accesess.Name = "lbl_array_accesess";
            this.lbl_array_accesess.Size = new System.Drawing.Size(13, 13);
            this.lbl_array_accesess.TabIndex = 4;
            this.lbl_array_accesess.Text = "0";
            // 
            // lbl_conditions
            // 
            this.lbl_conditions.AutoSize = true;
            this.lbl_conditions.Location = new System.Drawing.Point(119, 49);
            this.lbl_conditions.Name = "lbl_conditions";
            this.lbl_conditions.Size = new System.Drawing.Size(13, 13);
            this.lbl_conditions.TabIndex = 5;
            this.lbl_conditions.Text = "0";
            // 
            // lbl_moves
            // 
            this.lbl_moves.AutoSize = true;
            this.lbl_moves.Location = new System.Drawing.Point(119, 71);
            this.lbl_moves.Name = "lbl_moves";
            this.lbl_moves.Size = new System.Drawing.Size(13, 13);
            this.lbl_moves.TabIndex = 6;
            this.lbl_moves.Text = "0";
            // 
            // num_arraylenght
            // 
            this.num_arraylenght.Location = new System.Drawing.Point(82, 91);
            this.num_arraylenght.Name = "num_arraylenght";
            this.num_arraylenght.Size = new System.Drawing.Size(50, 20);
            this.num_arraylenght.TabIndex = 8;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(186, 12);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 141);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sorting Algorithms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_arraylenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_arraylenght;
        private System.Windows.Forms.Label lbl_moves;
        private System.Windows.Forms.Label lbl_conditions;
        private System.Windows.Forms.Label lbl_array_accesess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

