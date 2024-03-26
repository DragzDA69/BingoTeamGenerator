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
            this.PlayersDataGrid = new System.Windows.Forms.DataGridView();
            this.TeamsDataGrid = new System.Windows.Forms.DataGridView();
            this.NumTeamsLabel = new System.Windows.Forms.Label();
            this.NumTeamsTextbox = new System.Windows.Forms.TextBox();
            this.TotalLoadedPlayersLabel = new System.Windows.Forms.Label();
            this.TotalGeneratedTeamsLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(327, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(308, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Bingo Team Generator";
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
            this.GenerateTeamsButton.Location = new System.Drawing.Point(432, 379);
            this.GenerateTeamsButton.Name = "GenerateTeamsButton";
            this.GenerateTeamsButton.Size = new System.Drawing.Size(116, 29);
            this.GenerateTeamsButton.TabIndex = 1;
            this.GenerateTeamsButton.Text = "Generate Teams";
            this.GenerateTeamsButton.UseVisualStyleBackColor = true;
            this.GenerateTeamsButton.Click += new System.EventHandler(this.GenerateTeamsButton_Click);
            // 
            // PlayersDataGrid
            // 
            this.PlayersDataGrid.AllowUserToAddRows = false;
            this.PlayersDataGrid.AllowUserToDeleteRows = false;
            this.PlayersDataGrid.AllowUserToResizeRows = false;
            this.PlayersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersDataGrid.Location = new System.Drawing.Point(12, 176);
            this.PlayersDataGrid.Name = "PlayersDataGrid";
            this.PlayersDataGrid.ReadOnly = true;
            this.PlayersDataGrid.RowHeadersWidth = 55;
            this.PlayersDataGrid.Size = new System.Drawing.Size(355, 445);
            this.PlayersDataGrid.TabIndex = 2;
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
            // TotalLoadedPlayersLabel
            // 
            this.TotalLoadedPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLoadedPlayersLabel.Location = new System.Drawing.Point(9, 624);
            this.TotalLoadedPlayersLabel.Name = "TotalLoadedPlayersLabel";
            this.TotalLoadedPlayersLabel.Size = new System.Drawing.Size(167, 23);
            this.TotalLoadedPlayersLabel.TabIndex = 3;
            this.TotalLoadedPlayersLabel.Text = "Total:";
            this.TotalLoadedPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalGeneratedTeamsLabel
            // 
            this.TotalGeneratedTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGeneratedTeamsLabel.Location = new System.Drawing.Point(613, 624);
            this.TotalGeneratedTeamsLabel.Name = "TotalGeneratedTeamsLabel";
            this.TotalGeneratedTeamsLabel.Size = new System.Drawing.Size(182, 23);
            this.TotalGeneratedTeamsLabel.TabIndex = 3;
            this.TotalGeneratedTeamsLabel.Text = "Total:  ";
            this.TotalGeneratedTeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(735, 141);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(116, 29);
            this.ClearAllButton.TabIndex = 1;
            this.ClearAllButton.Text = "Clear";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 656);
            this.Controls.Add(this.NumTeamsTextbox);
            this.Controls.Add(this.TotalGeneratedTeamsLabel);
            this.Controls.Add(this.TotalLoadedPlayersLabel);
            this.Controls.Add(this.NumTeamsLabel);
            this.Controls.Add(this.TeamsDataGrid);
            this.Controls.Add(this.PlayersDataGrid);
            this.Controls.Add(this.GenerateTeamsButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button GenerateTeamsButton;
        private System.Windows.Forms.DataGridView PlayersDataGrid;
        private System.Windows.Forms.DataGridView TeamsDataGrid;
        private System.Windows.Forms.Label NumTeamsLabel;
        private System.Windows.Forms.TextBox NumTeamsTextbox;
        private System.Windows.Forms.Label TotalLoadedPlayersLabel;
        private System.Windows.Forms.Label TotalGeneratedTeamsLabel;
        private System.Windows.Forms.Button ClearAllButton;
    }
}

