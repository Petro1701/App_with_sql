namespace ConsoleApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_manager_records = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new_record = new System.Windows.Forms.Button();
            this.panel_under_record = new System.Windows.Forms.Panel();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_postavka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_type_of = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_search = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.pictureBox_update = new System.Windows.Forms.PictureBox();
            this.pictureBox_clear = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_manager_records.SuspendLayout();
            this.panel_under_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 648);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel_manager_records);
            this.tabPage1.Controls.Add(this.panel_under_record);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel_search);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отдел 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(513, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Управление записями:";
            // 
            // panel_manager_records
            // 
            this.panel_manager_records.BackColor = System.Drawing.Color.White;
            this.panel_manager_records.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_manager_records.Controls.Add(this.button_save);
            this.panel_manager_records.Controls.Add(this.button_update);
            this.panel_manager_records.Controls.Add(this.button_delete);
            this.panel_manager_records.Controls.Add(this.button_new_record);
            this.panel_manager_records.Location = new System.Drawing.Point(516, 449);
            this.panel_manager_records.Name = "panel_manager_records";
            this.panel_manager_records.Size = new System.Drawing.Size(184, 167);
            this.panel_manager_records.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(43, 123);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 35);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(43, 83);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 35);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Изменить";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(43, 43);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 35);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_new_record
            // 
            this.button_new_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new_record.Location = new System.Drawing.Point(43, 3);
            this.button_new_record.Name = "button_new_record";
            this.button_new_record.Size = new System.Drawing.Size(100, 35);
            this.button_new_record.TabIndex = 0;
            this.button_new_record.Text = "Новая запись";
            this.button_new_record.UseVisualStyleBackColor = true;
            // 
            // panel_under_record
            // 
            this.panel_under_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_under_record.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_under_record.Controls.Add(this.textBox_price);
            this.panel_under_record.Controls.Add(this.label7);
            this.panel_under_record.Controls.Add(this.textBox_postavka);
            this.panel_under_record.Controls.Add(this.label6);
            this.panel_under_record.Controls.Add(this.textBox_count);
            this.panel_under_record.Controls.Add(this.label5);
            this.panel_under_record.Controls.Add(this.textBox_type_of);
            this.panel_under_record.Controls.Add(this.label4);
            this.panel_under_record.Controls.Add(this.textBox_id);
            this.panel_under_record.Controls.Add(this.label3);
            this.panel_under_record.Controls.Add(this.label2);
            this.panel_under_record.Controls.Add(this.pictureBox1);
            this.panel_under_record.Location = new System.Drawing.Point(3, 423);
            this.panel_under_record.Name = "panel_under_record";
            this.panel_under_record.Size = new System.Drawing.Size(478, 193);
            this.panel_under_record.TabIndex = 2;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(117, 145);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(300, 20);
            this.textBox_price.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Цена:";
            // 
            // textBox_postavka
            // 
            this.textBox_postavka.Location = new System.Drawing.Point(117, 120);
            this.textBox_postavka.Name = "textBox_postavka";
            this.textBox_postavka.Size = new System.Drawing.Size(300, 20);
            this.textBox_postavka.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Поставщик:";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(117, 95);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(300, 20);
            this.textBox_count.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество:";
            // 
            // textBox_type_of
            // 
            this.textBox_type_of.Location = new System.Drawing.Point(117, 70);
            this.textBox_type_of.Name = "textBox_type_of";
            this.textBox_type_of.Size = new System.Drawing.Size(300, 20);
            this.textBox_type_of.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип товара:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 45);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(300, 20);
            this.textBox_id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запись:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleApp2.Properties.Resources.icons8_блокнот_50;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(772, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.Silver;
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Controls.Add(this.pictureBox_search);
            this.panel_search.Controls.Add(this.pictureBox_update);
            this.panel_search.Controls.Add(this.pictureBox_clear);
            this.panel_search.Controls.Add(this.label1);
            this.panel_search.Location = new System.Drawing.Point(0, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(772, 55);
            this.panel_search.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(611, 20);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(150, 20);
            this.textBox_search.TabIndex = 4;
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::ConsoleApp2.Properties.Resources.icons8_лупа_50;
            this.pictureBox_search.Location = new System.Drawing.Point(564, 11);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_search.TabIndex = 3;
            this.pictureBox_search.TabStop = false;
            // 
            // pictureBox_update
            // 
            this.pictureBox_update.Image = global::ConsoleApp2.Properties.Resources.icons8_обновление_50;
            this.pictureBox_update.Location = new System.Drawing.Point(514, 11);
            this.pictureBox_update.Name = "pictureBox_update";
            this.pictureBox_update.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_update.TabIndex = 2;
            this.pictureBox_update.TabStop = false;
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_clear.Image")));
            this.pictureBox_clear.Location = new System.Drawing.Point(464, 11);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clear.TabIndex = 1;
            this.pictureBox_clear.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел №1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отдел 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem2.Text = "Информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 674);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_manager_records.ResumeLayout(false);
            this.panel_under_record.ResumeLayout(false);
            this.panel_under_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_update;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_under_record;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_postavka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_type_of;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_manager_records;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new_record;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}