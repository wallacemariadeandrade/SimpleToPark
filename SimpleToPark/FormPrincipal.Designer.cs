﻿namespace SimpleToPark
{
    partial class FormPrincipal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelValorArrecadado = new System.Windows.Forms.Label();
            this.dataGridViewCarrosEstacionados = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonConfigurar = new System.Windows.Forms.Button();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrosEstacionados)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.90499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.09501F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72945F));
            this.tableLayoutPanel2.Controls.Add(this.labelValorArrecadado, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewCarrosEstacionados, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(149, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.99526F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.00474F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(669, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelValorArrecadado
            // 
            this.labelValorArrecadado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValorArrecadado.AutoSize = true;
            this.labelValorArrecadado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorArrecadado.Location = new System.Drawing.Point(443, 403);
            this.labelValorArrecadado.Name = "labelValorArrecadado";
            this.labelValorArrecadado.Size = new System.Drawing.Size(223, 19);
            this.labelValorArrecadado.TabIndex = 0;
            this.labelValorArrecadado.Text = "Valor da Arrecadado R$ 0,00";
            this.labelValorArrecadado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCarrosEstacionados
            // 
            this.dataGridViewCarrosEstacionados.AllowUserToAddRows = false;
            this.dataGridViewCarrosEstacionados.AllowUserToDeleteRows = false;
            this.dataGridViewCarrosEstacionados.AllowUserToResizeColumns = false;
            this.dataGridViewCarrosEstacionados.AllowUserToResizeRows = false;
            this.dataGridViewCarrosEstacionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCarrosEstacionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarrosEstacionados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCarrosEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrosEstacionados.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCarrosEstacionados.Name = "dataGridViewCarrosEstacionados";
            this.dataGridViewCarrosEstacionados.ReadOnly = true;
            this.dataGridViewCarrosEstacionados.RowHeadersVisible = false;
            this.dataGridViewCarrosEstacionados.Size = new System.Drawing.Size(663, 378);
            this.dataGridViewCarrosEstacionados.TabIndex = 1;
            this.dataGridViewCarrosEstacionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrosEstacionados_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonCadastrar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonConfigurar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelValorHora, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27014F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.17062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32228F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 422);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCadastrar.BackColor = System.Drawing.Color.Silver;
            this.buttonCadastrar.Location = new System.Drawing.Point(3, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(134, 50);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonConfigurar
            // 
            this.buttonConfigurar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigurar.BackColor = System.Drawing.Color.Silver;
            this.buttonConfigurar.Location = new System.Drawing.Point(3, 372);
            this.buttonConfigurar.Name = "buttonConfigurar";
            this.buttonConfigurar.Size = new System.Drawing.Size(134, 47);
            this.buttonConfigurar.TabIndex = 1;
            this.buttonConfigurar.Text = "Configurar";
            this.buttonConfigurar.UseVisualStyleBackColor = false;
            this.buttonConfigurar.Click += new System.EventHandler(this.buttonConfigurar_Click);
            // 
            // labelValorHora
            // 
            this.labelValorHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorHora.Location = new System.Drawing.Point(3, 331);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(116, 38);
            this.labelValorHora.TabIndex = 2;
            this.labelValorHora.Text = "Valor da Hora R$ 0,00";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(845, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Simple To Park";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrosEstacionados)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelValorArrecadado;
        private System.Windows.Forms.DataGridView dataGridViewCarrosEstacionados;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonConfigurar;
        private System.Windows.Forms.Label labelValorHora;
    }
}

