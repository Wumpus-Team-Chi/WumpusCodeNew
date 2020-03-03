namespace HuntTheWumpus
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
            this.components = new System.ComponentModel.Container();
            this.construct_objects = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Label();
            this.playerInputX = new System.Windows.Forms.TextBox();
            this.movePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerInputY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // construct_objects
            // 
            this.construct_objects.Location = new System.Drawing.Point(37, 287);
            this.construct_objects.Name = "construct_objects";
            this.construct_objects.Size = new System.Drawing.Size(75, 23);
            this.construct_objects.TabIndex = 0;
            this.construct_objects.Text = "make game";
            this.construct_objects.UseVisualStyleBackColor = true;
            this.construct_objects.Click += new System.EventHandler(this.construct_objects_Click);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(365, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(59, 13);
            this.player.TabIndex = 1;
            this.player.Text = ":) <-- player";
            // 
            // playerInputX
            // 
            this.playerInputX.Location = new System.Drawing.Point(319, 270);
            this.playerInputX.Name = "playerInputX";
            this.playerInputX.Size = new System.Drawing.Size(100, 20);
            this.playerInputX.TabIndex = 2;
            this.playerInputX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movePlayer
            // 
            this.movePlayer.Location = new System.Drawing.Point(156, 287);
            this.movePlayer.Name = "movePlayer";
            this.movePlayer.Size = new System.Drawing.Size(129, 23);
            this.movePlayer.TabIndex = 3;
            this.movePlayer.Text = "click to move player";
            this.movePlayer.UseVisualStyleBackColor = true;
            this.movePlayer.Click += new System.EventHandler(this.movePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x:";
            // 
            // playerInputY
            // 
            this.playerInputY.Location = new System.Drawing.Point(319, 308);
            this.playerInputY.Name = "playerInputY";
            this.playerInputY.Size = new System.Drawing.Size(100, 20);
            this.playerInputY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "y:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerInputY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movePlayer);
            this.Controls.Add(this.playerInputX);
            this.Controls.Add(this.player);
            this.Controls.Add(this.construct_objects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button construct_objects;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.TextBox playerInputX;
        private System.Windows.Forms.Button movePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerInputY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

