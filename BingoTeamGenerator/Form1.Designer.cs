namespace BingoTeamGenerator
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.GenerateTeamsButton = new System.Windows.Forms.Button();
            this.PlayersListGrid = new System.Windows.Forms.DataGridView();
            this.TeamsDataGrid = new System.Windows.Forms.DataGridView();
            this.NumTeamsLabel = new System.Windows.Forms.Label();
            this.NumTeamsTextbox = new System.Windows.Forms.TextBox();
            this.LoadedPlayersTotalLabel = new System.Windows.Forms.Label();
            this.GeneratedPlayersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(327, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(312, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dragz Team Generator";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(131, 141);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(116, 29);
            this.LoadFileButton.TabIndex = 1;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // GenerateTeamsButton
            // 
            this.GenerateTeamsButton.Location = new System.Drawing.Point(736, 141);
            this.GenerateTeamsButton.Name = "GenerateTeamsButton";
            this.GenerateTeamsButton.Size = new System.Drawing.Size(116, 29);
            this.GenerateTeamsButton.TabIndex = 1;
            this.GenerateTeamsButton.Text = "Generate Teams";
            this.GenerateTeamsButton.UseVisualStyleBackColor = true;
            this.GenerateTeamsButton.Click += new System.EventHandler(this.GenerateTeamsButton_Click);
            // 
            // PlayersListGrid
            // 
            this.PlayersListGrid.AllowUserToAddRows = false;
            this.PlayersListGrid.AllowUserToDeleteRows = false;
            this.PlayersListGrid.AllowUserToResizeRows = false;
            this.PlayersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersListGrid.Enabled = false;
            this.PlayersListGrid.Location = new System.Drawing.Point(12, 176);
            this.PlayersListGrid.Name = "PlayersListGrid";
            this.PlayersListGrid.ReadOnly = true;
            this.PlayersListGrid.RowHeadersWidth = 55;
            this.PlayersListGrid.Size = new System.Drawing.Size(355, 445);
            this.PlayersListGrid.TabIndex = 2;
            // 
            // TeamsDataGrid
            // 
            this.TeamsDataGrid.AllowUserToAddRows = false;
            this.TeamsDataGrid.AllowUserToDeleteRows = false;
            this.TeamsDataGrid.AllowUserToResizeRows = false;
            this.TeamsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsDataGrid.Location = new System.Drawing.Point(616, 176);
            this.TeamsDataGrid.Name = "TeamsDataGrid";
            this.TeamsDataGrid.ReadOnly = true;
            this.TeamsDataGrid.RowHeadersWidth = 55;
            this.TeamsDataGrid.Size = new System.Drawing.Size(355, 445);
            this.TeamsDataGrid.TabIndex = 2;
            // 
            // NumTeamsLabel
            // 
            this.NumTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTeamsLabel.Location = new System.Drawing.Point(373, 315);
            this.NumTeamsLabel.Name = "NumTeamsLabel";
            this.NumTeamsLabel.Size = new System.Drawing.Size(237, 23);
            this.NumTeamsLabel.TabIndex = 3;
            this.NumTeamsLabel.Text = "Number of Teams";
            this.NumTeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumTeamsTextbox
            // 
            this.NumTeamsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTeamsTextbox.Location = new System.Drawing.Point(471, 341);
            this.NumTeamsTextbox.Name = "NumTeamsTextbox";
            this.NumTeamsTextbox.Size = new System.Drawing.Size(39, 26);
            this.NumTeamsTextbox.TabIndex = 4;
            this.NumTeamsTextbox.Text = "2";
            this.NumTeamsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumTeamsTextbox.TextChanged += new System.EventHandler(this.NumTeamsTextbox_TextChanged);
            // 
            // LoadedPlayersTotalLabel
            // 
            this.LoadedPlayersTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedPlayersTotalLabel.Location = new System.Drawing.Point(9, 624);
            this.LoadedPlayersTotalLabel.Name = "LoadedPlayersTotalLabel";
            this.LoadedPlayersTotalLabel.Size = new System.Drawing.Size(167, 23);
            this.LoadedPlayersTotalLabel.TabIndex = 3;
            this.LoadedPlayersTotalLabel.Text = "Total:";
            this.LoadedPlayersTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneratedPlayersLabel
            // 
            this.GeneratedPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedPlayersLabel.Location = new System.Drawing.Point(613, 624);
            this.GeneratedPlayersLabel.Name = "GeneratedPlayersLabel";
            this.GeneratedPlayersLabel.Size = new System.Drawing.Size(182, 23);
            this.GeneratedPlayersLabel.TabIndex = 3;
            this.GeneratedPlayersLabel.Text = "Total:  ";
            this.GeneratedPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 656);
            this.Controls.Add(this.NumTeamsTextbox);
            this.Controls.Add(this.GeneratedPlayersLabel);
            this.Controls.Add(this.LoadedPlayersTotalLabel);
            this.Controls.Add(this.NumTeamsLabel);
            this.Controls.Add(this.TeamsDataGrid);
            this.Controls.Add(this.PlayersListGrid);
            this.Controls.Add(this.GenerateTeamsButton);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button GenerateTeamsButton;
        private System.Windows.Forms.DataGridView PlayersListGrid;
        private System.Windows.Forms.DataGridView TeamsDataGrid;
        private System.Windows.Forms.Label NumTeamsLabel;
        private System.Windows.Forms.TextBox NumTeamsTextbox;
        private System.Windows.Forms.Label LoadedPlayersTotalLabel;
        private System.Windows.Forms.Label GeneratedPlayersLabel;
    }
}

