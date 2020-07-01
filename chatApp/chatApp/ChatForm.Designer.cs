namespace chatApp
{
    partial class form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("7");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("8");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("9");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("10");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("11");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("12");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("13");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("14");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("15");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("16");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("17");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("18");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("19");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("20");
            this.login = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.chatText = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.chatHistory = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.name = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chattoroom = new System.Windows.Forms.Label();
            this.chatUser = new System.Windows.Forms.Label();
            this.chatSelectedUser = new System.Windows.Forms.Label();
            this.messagehere = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(240, 248);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 20);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(286, 285);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // chatText
            // 
            this.chatText.Location = new System.Drawing.Point(191, 430);
            this.chatText.Name = "chatText";
            this.chatText.Size = new System.Drawing.Size(408, 20);
            this.chatText.TabIndex = 3;
            this.chatText.TextChanged += new System.EventHandler(this.chatText_TextChanged);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.send.Enabled = false;
            this.send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.send.Location = new System.Drawing.Point(605, 427);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(93, 23);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // chatHistory
            // 
            this.chatHistory.Location = new System.Drawing.Point(191, 50);
            this.chatHistory.Multiline = true;
            this.chatHistory.Name = "chatHistory";
            this.chatHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatHistory.Size = new System.Drawing.Size(508, 360);
            this.chatHistory.TabIndex = 5;
            this.chatHistory.TextChanged += new System.EventHandler(this.chatHistory_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(177, 250);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 13);
            this.name.TabIndex = 6;
            this.name.Text = "User Name";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.SystemColors.Window;
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.userList.FullRowSelect = true;
            this.userList.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.userList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.userList.Location = new System.Drawing.Point(21, 50);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(155, 218);
            this.userList.TabIndex = 7;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chat Rooms";
            this.columnHeader1.Width = 150;
            // 
            // chattoroom
            // 
            this.chattoroom.AutoSize = true;
            this.chattoroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chattoroom.Location = new System.Drawing.Point(2, 368);
            this.chattoroom.Name = "chattoroom";
            this.chattoroom.Size = new System.Drawing.Size(105, 13);
            this.chattoroom.TabIndex = 8;
            this.chattoroom.Text = "You are in Room:";
            this.chattoroom.Click += new System.EventHandler(this.label2_Click);
            // 
            // chatUser
            // 
            this.chatUser.AutoSize = true;
            this.chatUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatUser.Location = new System.Drawing.Point(113, 333);
            this.chatUser.Name = "chatUser";
            this.chatUser.Size = new System.Drawing.Size(0, 13);
            this.chatUser.TabIndex = 9;
            // 
            // chatSelectedUser
            // 
            this.chatSelectedUser.AutoSize = true;
            this.chatSelectedUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chatSelectedUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chatSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatSelectedUser.Location = new System.Drawing.Point(116, 368);
            this.chatSelectedUser.Name = "chatSelectedUser";
            this.chatSelectedUser.Size = new System.Drawing.Size(13, 15);
            this.chatSelectedUser.TabIndex = 10;
            this.chatSelectedUser.Text = ".";
            this.chatSelectedUser.Click += new System.EventHandler(this.chatSelectedUser_Click);
            // 
            // messagehere
            // 
            this.messagehere.AutoSize = true;
            this.messagehere.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagehere.Location = new System.Drawing.Point(83, 432);
            this.messagehere.Name = "messagehere";
            this.messagehere.Size = new System.Drawing.Size(93, 15);
            this.messagehere.TabIndex = 11;
            this.messagehere.Text = "Message Here -->";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 474);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(605, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(77, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login as";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagehere);
            this.Controls.Add(this.chatSelectedUser);
            this.Controls.Add(this.chatUser);
            this.Controls.Add(this.chattoroom);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.chatHistory);
            this.Controls.Add(this.send);
            this.Controls.Add(this.chatText);
            this.Name = "form1";
            this.Text = "Chat Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox chatText;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox chatHistory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.Label chattoroom;
        private System.Windows.Forms.Label chatUser;
        private System.Windows.Forms.Label chatSelectedUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label messagehere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

