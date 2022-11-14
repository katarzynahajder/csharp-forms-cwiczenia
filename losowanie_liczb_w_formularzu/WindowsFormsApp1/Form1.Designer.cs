
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_losuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_wynik = new System.Windows.Forms.Label();
            this.textBox_wpisana_liczba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_wylosowana = new System.Windows.Forms.Label();
            this.label_wygrana_czy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_proby = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz liczbę";
            // 
            // button_losuj
            // 
            this.button_losuj.Location = new System.Drawing.Point(37, 71);
            this.button_losuj.Name = "button_losuj";
            this.button_losuj.Size = new System.Drawing.Size(75, 23);
            this.button_losuj.TabIndex = 1;
            this.button_losuj.Text = "Losuj";
            this.button_losuj.UseVisualStyleBackColor = true;
            this.button_losuj.Visible = false;
            this.button_losuj.Click += new System.EventHandler(this.button_losuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba punktów";
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wynik.Location = new System.Drawing.Point(194, 45);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(23, 25);
            this.label_wynik.TabIndex = 3;
            this.label_wynik.Text = "0";
            // 
            // textBox_wpisana_liczba
            // 
            this.textBox_wpisana_liczba.Location = new System.Drawing.Point(37, 45);
            this.textBox_wpisana_liczba.Name = "textBox_wpisana_liczba";
            this.textBox_wpisana_liczba.Size = new System.Drawing.Size(100, 20);
            this.textBox_wpisana_liczba.TabIndex = 4;
            this.textBox_wpisana_liczba.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_wpisana_liczba_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wylosowana liczba";
            // 
            // label_wylosowana
            // 
            this.label_wylosowana.AutoSize = true;
            this.label_wylosowana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wylosowana.Location = new System.Drawing.Point(317, 45);
            this.label_wylosowana.Name = "label_wylosowana";
            this.label_wylosowana.Size = new System.Drawing.Size(23, 25);
            this.label_wylosowana.TabIndex = 6;
            this.label_wylosowana.Text = "0";
            // 
            // label_wygrana_czy
            // 
            this.label_wygrana_czy.AutoSize = true;
            this.label_wygrana_czy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wygrana_czy.Location = new System.Drawing.Point(35, 118);
            this.label_wygrana_czy.Name = "label_wygrana_czy";
            this.label_wygrana_czy.Size = new System.Drawing.Size(0, 25);
            this.label_wygrana_czy.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość prób";
            // 
            // label_proby
            // 
            this.label_proby.AutoSize = true;
            this.label_proby.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_proby.Location = new System.Drawing.Point(421, 45);
            this.label_proby.Name = "label_proby";
            this.label_proby.Size = new System.Drawing.Size(23, 25);
            this.label_proby.TabIndex = 9;
            this.label_proby.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 173);
            this.Controls.Add(this.label_proby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_wygrana_czy);
            this.Controls.Add(this.label_wylosowana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_wpisana_liczba);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_losuj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_losuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.TextBox textBox_wpisana_liczba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_wylosowana;
        private System.Windows.Forms.Label label_wygrana_czy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_proby;
    }
}

