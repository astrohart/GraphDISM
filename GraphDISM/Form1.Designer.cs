﻿namespace GraphDISM
{
    partial class GraphDismMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphDismMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Information = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.chkOpenNewFormInfo = new System.Windows.Forms.CheckBox();
            this.txtPathInfo = new System.Windows.Forms.TextBox();
            this.btnOpenFileInfo = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.mount = new System.Windows.Forms.TabPage();
            this.chkAppendUnmount = new System.Windows.Forms.CheckBox();
            this.chkCheckIntegrityUnmount = new System.Windows.Forms.CheckBox();
            this.chkCommitUnmount = new System.Windows.Forms.CheckBox();
            this.btnUnmout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.chkCheckIntegrityMount = new System.Windows.Forms.CheckBox();
            this.chkOptimizeMount = new System.Windows.Forms.CheckBox();
            this.chkReadOnlyMout = new System.Windows.Forms.CheckBox();
            this.txtMountTo = new System.Windows.Forms.TextBox();
            this.btnMountTo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbMoutIndex = new System.Windows.Forms.NumericUpDown();
            this.txtMountFrom = new System.Windows.Forms.TextBox();
            this.btnOpenWimMount = new System.Windows.Forms.Button();
            this.Exporter = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCompress = new System.Windows.Forms.ComboBox();
            this.chkBoot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.chkVerifyExport = new System.Windows.Forms.CheckBox();
            this.txtExportTo = new System.Windows.Forms.TextBox();
            this.btnExportTo = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtExportFrom = new System.Windows.Forms.TextBox();
            this.btnOpenWimExp = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkVerifySplit = new System.Windows.Forms.CheckBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSizeSplit = new System.Windows.Forms.TextBox();
            this.txtSplitTo = new System.Windows.Forms.TextBox();
            this.txtOpenSplit = new System.Windows.Forms.TextBox();
            this.btnSplitTo = new System.Windows.Forms.Button();
            this.btnOpenSplit = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnResetOutput = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Information.SuspendLayout();
            this.mount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMoutIndex)).BeginInit();
            this.Exporter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.Splitter.SuspendLayout();
            this.about.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Information);
            this.tabControl1.Controls.Add(this.mount);
            this.tabControl1.Controls.Add(this.Exporter);
            this.tabControl1.Controls.Add(this.Splitter);
            this.tabControl1.Controls.Add(this.about);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.White;
            this.Information.Controls.Add(this.label19);
            this.Information.Controls.Add(this.chkOpenNewFormInfo);
            this.Information.Controls.Add(this.txtPathInfo);
            this.Information.Controls.Add(this.btnOpenFileInfo);
            this.Information.Controls.Add(this.btnGetInfo);
            this.Information.Location = new System.Drawing.Point(4, 22);
            this.Information.Name = "Information";
            this.Information.Padding = new System.Windows.Forms.Padding(3);
            this.Information.Size = new System.Drawing.Size(711, 319);
            this.Information.TabIndex = 0;
            this.Information.Text = "Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Source";
            // 
            // chkOpenNewFormInfo
            // 
            this.chkOpenNewFormInfo.AutoSize = true;
            this.chkOpenNewFormInfo.Location = new System.Drawing.Point(495, 136);
            this.chkOpenNewFormInfo.Name = "chkOpenNewFormInfo";
            this.chkOpenNewFormInfo.Size = new System.Drawing.Size(180, 17);
            this.chkOpenNewFormInfo.TabIndex = 3;
            this.chkOpenNewFormInfo.Text = "Ouvrir dans une nouvelle fenêtre";
            this.chkOpenNewFormInfo.UseVisualStyleBackColor = true;
            // 
            // txtPathInfo
            // 
            this.txtPathInfo.Location = new System.Drawing.Point(121, 49);
            this.txtPathInfo.Name = "txtPathInfo";
            this.txtPathInfo.Size = new System.Drawing.Size(369, 20);
            this.txtPathInfo.TabIndex = 2;
            // 
            // btnOpenFileInfo
            // 
            this.btnOpenFileInfo.Location = new System.Drawing.Point(6, 47);
            this.btnOpenFileInfo.Name = "btnOpenFileInfo";
            this.btnOpenFileInfo.Size = new System.Drawing.Size(109, 23);
            this.btnOpenFileInfo.TabIndex = 0;
            this.btnOpenFileInfo.Text = "Ouvrir WIM/SWM";
            this.btnOpenFileInfo.UseVisualStyleBackColor = true;
            this.btnOpenFileInfo.Click += new System.EventHandler(this.btnOpenFileInfo_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(577, 48);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(98, 82);
            this.btnGetInfo.TabIndex = 1;
            this.btnGetInfo.Text = "Obtenir Information WIM/SWM";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // mount
            // 
            this.mount.Controls.Add(this.chkAppendUnmount);
            this.mount.Controls.Add(this.chkCheckIntegrityUnmount);
            this.mount.Controls.Add(this.chkCommitUnmount);
            this.mount.Controls.Add(this.btnUnmout);
            this.mount.Controls.Add(this.button1);
            this.mount.Controls.Add(this.label18);
            this.mount.Controls.Add(this.chkCheckIntegrityMount);
            this.mount.Controls.Add(this.chkOptimizeMount);
            this.mount.Controls.Add(this.chkReadOnlyMout);
            this.mount.Controls.Add(this.txtMountTo);
            this.mount.Controls.Add(this.btnMountTo);
            this.mount.Controls.Add(this.label7);
            this.mount.Controls.Add(this.label17);
            this.mount.Controls.Add(this.cbbMoutIndex);
            this.mount.Controls.Add(this.txtMountFrom);
            this.mount.Controls.Add(this.btnOpenWimMount);
            this.mount.Location = new System.Drawing.Point(4, 22);
            this.mount.Name = "mount";
            this.mount.Size = new System.Drawing.Size(711, 319);
            this.mount.TabIndex = 5;
            this.mount.Text = "Monter";
            this.mount.UseVisualStyleBackColor = true;
            // 
            // chkAppendUnmount
            // 
            this.chkAppendUnmount.AutoSize = true;
            this.chkAppendUnmount.Location = new System.Drawing.Point(499, 296);
            this.chkAppendUnmount.Name = "chkAppendUnmount";
            this.chkAppendUnmount.Size = new System.Drawing.Size(200, 17);
            this.chkAppendUnmount.TabIndex = 22;
            this.chkAppendUnmount.Text = "Ajoute l\'image au lieu de la remplacer";
            this.chkAppendUnmount.UseVisualStyleBackColor = true;
            // 
            // chkCheckIntegrityUnmount
            // 
            this.chkCheckIntegrityUnmount.AutoSize = true;
            this.chkCheckIntegrityUnmount.Location = new System.Drawing.Point(499, 273);
            this.chkCheckIntegrityUnmount.Name = "chkCheckIntegrityUnmount";
            this.chkCheckIntegrityUnmount.Size = new System.Drawing.Size(102, 17);
            this.chkCheckIntegrityUnmount.TabIndex = 21;
            this.chkCheckIntegrityUnmount.Text = "Verifier l\'intégrité";
            this.chkCheckIntegrityUnmount.UseVisualStyleBackColor = true;
            // 
            // chkCommitUnmount
            // 
            this.chkCommitUnmount.AutoSize = true;
            this.chkCommitUnmount.Location = new System.Drawing.Point(499, 250);
            this.chkCommitUnmount.Name = "chkCommitUnmount";
            this.chkCommitUnmount.Size = new System.Drawing.Size(153, 17);
            this.chkCommitUnmount.TabIndex = 20;
            this.chkCommitUnmount.Text = "Appliquer les changements";
            this.chkCommitUnmount.UseVisualStyleBackColor = true;
            // 
            // btnUnmout
            // 
            this.btnUnmout.Location = new System.Drawing.Point(499, 221);
            this.btnUnmout.Name = "btnUnmout";
            this.btnUnmout.Size = new System.Drawing.Size(75, 23);
            this.btnUnmout.TabIndex = 19;
            this.btnUnmout.Text = "Demonter";
            this.btnUnmout.UseVisualStyleBackColor = true;
            this.btnUnmout.Click += new System.EventHandler(this.btnUnmout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 82);
            this.button1.TabIndex = 18;
            this.button1.Text = "Monter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Destination";
            // 
            // chkCheckIntegrityMount
            // 
            this.chkCheckIntegrityMount.AutoSize = true;
            this.chkCheckIntegrityMount.Location = new System.Drawing.Point(577, 182);
            this.chkCheckIntegrityMount.Name = "chkCheckIntegrityMount";
            this.chkCheckIntegrityMount.Size = new System.Drawing.Size(102, 17);
            this.chkCheckIntegrityMount.TabIndex = 16;
            this.chkCheckIntegrityMount.Text = "Verifier l\'intégrité";
            this.chkCheckIntegrityMount.UseVisualStyleBackColor = true;
            // 
            // chkOptimizeMount
            // 
            this.chkOptimizeMount.AutoSize = true;
            this.chkOptimizeMount.Location = new System.Drawing.Point(577, 159);
            this.chkOptimizeMount.Name = "chkOptimizeMount";
            this.chkOptimizeMount.Size = new System.Drawing.Size(69, 17);
            this.chkOptimizeMount.TabIndex = 15;
            this.chkOptimizeMount.Text = "Optimiser";
            this.chkOptimizeMount.UseVisualStyleBackColor = true;
            // 
            // chkReadOnlyMout
            // 
            this.chkReadOnlyMout.AutoSize = true;
            this.chkReadOnlyMout.Location = new System.Drawing.Point(577, 136);
            this.chkReadOnlyMout.Name = "chkReadOnlyMout";
            this.chkReadOnlyMout.Size = new System.Drawing.Size(92, 17);
            this.chkReadOnlyMout.TabIndex = 14;
            this.chkReadOnlyMout.Text = "Lecture Seule";
            this.chkReadOnlyMout.UseVisualStyleBackColor = true;
            // 
            // txtMountTo
            // 
            this.txtMountTo.Location = new System.Drawing.Point(121, 128);
            this.txtMountTo.Name = "txtMountTo";
            this.txtMountTo.Size = new System.Drawing.Size(369, 20);
            this.txtMountTo.TabIndex = 13;
            // 
            // btnMountTo
            // 
            this.btnMountTo.Location = new System.Drawing.Point(6, 126);
            this.btnMountTo.Name = "btnMountTo";
            this.btnMountTo.Size = new System.Drawing.Size(109, 23);
            this.btnMountTo.TabIndex = 12;
            this.btnMountTo.Text = "Dossier de montage";
            this.btnMountTo.UseVisualStyleBackColor = true;
            this.btnMountTo.Click += new System.EventHandler(this.btnMountTo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Source";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(76, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Index :";
            // 
            // cbbMoutIndex
            // 
            this.cbbMoutIndex.Location = new System.Drawing.Point(121, 75);
            this.cbbMoutIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbMoutIndex.Name = "cbbMoutIndex";
            this.cbbMoutIndex.Size = new System.Drawing.Size(47, 20);
            this.cbbMoutIndex.TabIndex = 11;
            this.cbbMoutIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMountFrom
            // 
            this.txtMountFrom.Location = new System.Drawing.Point(121, 49);
            this.txtMountFrom.Name = "txtMountFrom";
            this.txtMountFrom.Size = new System.Drawing.Size(369, 20);
            this.txtMountFrom.TabIndex = 10;
            // 
            // btnOpenWimMount
            // 
            this.btnOpenWimMount.Location = new System.Drawing.Point(6, 47);
            this.btnOpenWimMount.Name = "btnOpenWimMount";
            this.btnOpenWimMount.Size = new System.Drawing.Size(109, 23);
            this.btnOpenWimMount.TabIndex = 9;
            this.btnOpenWimMount.Text = "Ouvrir WIM/SWM";
            this.btnOpenWimMount.UseVisualStyleBackColor = true;
            this.btnOpenWimMount.Click += new System.EventHandler(this.btnOpenWimMount_Click);
            // 
            // Exporter
            // 
            this.Exporter.BackColor = System.Drawing.Color.White;
            this.Exporter.Controls.Add(this.label11);
            this.Exporter.Controls.Add(this.label10);
            this.Exporter.Controls.Add(this.label9);
            this.Exporter.Controls.Add(this.cmbCompress);
            this.Exporter.Controls.Add(this.chkBoot);
            this.Exporter.Controls.Add(this.label1);
            this.Exporter.Controls.Add(this.numIndex);
            this.Exporter.Controls.Add(this.chkVerifyExport);
            this.Exporter.Controls.Add(this.txtExportTo);
            this.Exporter.Controls.Add(this.btnExportTo);
            this.Exporter.Controls.Add(this.btnExport);
            this.Exporter.Controls.Add(this.txtExportFrom);
            this.Exporter.Controls.Add(this.btnOpenWimExp);
            this.Exporter.Location = new System.Drawing.Point(4, 22);
            this.Exporter.Name = "Exporter";
            this.Exporter.Padding = new System.Windows.Forms.Padding(3);
            this.Exporter.Size = new System.Drawing.Size(711, 319);
            this.Exporter.TabIndex = 2;
            this.Exporter.Text = "Exporter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Destination";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Compression :";
            // 
            // cmbCompress
            // 
            this.cmbCompress.AutoCompleteCustomSource.AddRange(new string[] {
            "Rapide (defaut)",
            "Maximum",
            "Recovery"});
            this.cmbCompress.FormattingEnabled = true;
            this.cmbCompress.Items.AddRange(new object[] {
            "Rapide (Defaut)",
            "Maximum",
            "Recovery",
            "Aucune"});
            this.cmbCompress.Location = new System.Drawing.Point(121, 154);
            this.cmbCompress.Name = "cmbCompress";
            this.cmbCompress.Size = new System.Drawing.Size(121, 21);
            this.cmbCompress.TabIndex = 9;
            // 
            // chkBoot
            // 
            this.chkBoot.AutoSize = true;
            this.chkBoot.Location = new System.Drawing.Point(577, 159);
            this.chkBoot.Name = "chkBoot";
            this.chkBoot.Size = new System.Drawing.Size(68, 17);
            this.chkBoot.TabIndex = 11;
            this.chkBoot.Text = "Bootable";
            this.chkBoot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Index :";
            // 
            // numIndex
            // 
            this.numIndex.Location = new System.Drawing.Point(121, 75);
            this.numIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(47, 20);
            this.numIndex.TabIndex = 6;
            this.numIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkVerifyExport
            // 
            this.chkVerifyExport.AutoSize = true;
            this.chkVerifyExport.Location = new System.Drawing.Point(577, 136);
            this.chkVerifyExport.Name = "chkVerifyExport";
            this.chkVerifyExport.Size = new System.Drawing.Size(58, 17);
            this.chkVerifyExport.TabIndex = 10;
            this.chkVerifyExport.Text = "Vérifier";
            this.chkVerifyExport.UseVisualStyleBackColor = true;
            // 
            // txtExportTo
            // 
            this.txtExportTo.Location = new System.Drawing.Point(121, 128);
            this.txtExportTo.Name = "txtExportTo";
            this.txtExportTo.Size = new System.Drawing.Size(369, 20);
            this.txtExportTo.TabIndex = 8;
            // 
            // btnExportTo
            // 
            this.btnExportTo.Location = new System.Drawing.Point(6, 126);
            this.btnExportTo.Name = "btnExportTo";
            this.btnExportTo.Size = new System.Drawing.Size(109, 23);
            this.btnExportTo.TabIndex = 7;
            this.btnExportTo.Text = "Exporter vers";
            this.btnExportTo.UseVisualStyleBackColor = true;
            this.btnExportTo.Click += new System.EventHandler(this.btnExportTo_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(577, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 82);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtExportFrom
            // 
            this.txtExportFrom.Location = new System.Drawing.Point(121, 49);
            this.txtExportFrom.Name = "txtExportFrom";
            this.txtExportFrom.Size = new System.Drawing.Size(369, 20);
            this.txtExportFrom.TabIndex = 5;
            // 
            // btnOpenWimExp
            // 
            this.btnOpenWimExp.Location = new System.Drawing.Point(6, 47);
            this.btnOpenWimExp.Name = "btnOpenWimExp";
            this.btnOpenWimExp.Size = new System.Drawing.Size(109, 23);
            this.btnOpenWimExp.TabIndex = 4;
            this.btnOpenWimExp.Text = "Ouvrir WIM/SWM";
            this.btnOpenWimExp.UseVisualStyleBackColor = true;
            this.btnOpenWimExp.Click += new System.EventHandler(this.btnOpenWimExp_Click);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.White;
            this.Splitter.Controls.Add(this.label16);
            this.Splitter.Controls.Add(this.label15);
            this.Splitter.Controls.Add(this.label14);
            this.Splitter.Controls.Add(this.label13);
            this.Splitter.Controls.Add(this.chkVerifySplit);
            this.Splitter.Controls.Add(this.btnSplit);
            this.Splitter.Controls.Add(this.label12);
            this.Splitter.Controls.Add(this.txtSizeSplit);
            this.Splitter.Controls.Add(this.txtSplitTo);
            this.Splitter.Controls.Add(this.txtOpenSplit);
            this.Splitter.Controls.Add(this.btnSplitTo);
            this.Splitter.Controls.Add(this.btnOpenSplit);
            this.Splitter.Location = new System.Drawing.Point(4, 22);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(711, 319);
            this.Splitter.TabIndex = 4;
            this.Splitter.Text = "Splitter";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "1024Mo = 1Go";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "4096Mo = 4Go (FAT32)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Destination";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Source";
            // 
            // chkVerifySplit
            // 
            this.chkVerifySplit.AutoSize = true;
            this.chkVerifySplit.Location = new System.Drawing.Point(577, 136);
            this.chkVerifySplit.Name = "chkVerifySplit";
            this.chkVerifySplit.Size = new System.Drawing.Size(58, 17);
            this.chkVerifySplit.TabIndex = 12;
            this.chkVerifySplit.Text = "Vérifier";
            this.chkVerifySplit.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(577, 48);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(98, 82);
            this.btnSplit.TabIndex = 11;
            this.btnSplit.Text = "Splitter";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Taille de l\'image en Mo :";
            // 
            // txtSizeSplit
            // 
            this.txtSizeSplit.Location = new System.Drawing.Point(143, 154);
            this.txtSizeSplit.Name = "txtSizeSplit";
            this.txtSizeSplit.Size = new System.Drawing.Size(76, 20);
            this.txtSizeSplit.TabIndex = 9;
            this.txtSizeSplit.Text = "4096";
            // 
            // txtSplitTo
            // 
            this.txtSplitTo.Location = new System.Drawing.Point(121, 128);
            this.txtSplitTo.Name = "txtSplitTo";
            this.txtSplitTo.Size = new System.Drawing.Size(293, 20);
            this.txtSplitTo.TabIndex = 8;
            // 
            // txtOpenSplit
            // 
            this.txtOpenSplit.Location = new System.Drawing.Point(121, 49);
            this.txtOpenSplit.Name = "txtOpenSplit";
            this.txtOpenSplit.Size = new System.Drawing.Size(293, 20);
            this.txtOpenSplit.TabIndex = 7;
            // 
            // btnSplitTo
            // 
            this.btnSplitTo.Location = new System.Drawing.Point(6, 126);
            this.btnSplitTo.Name = "btnSplitTo";
            this.btnSplitTo.Size = new System.Drawing.Size(109, 23);
            this.btnSplitTo.TabIndex = 6;
            this.btnSplitTo.Text = "Splitter vers";
            this.btnSplitTo.UseVisualStyleBackColor = true;
            this.btnSplitTo.Click += new System.EventHandler(this.btnSplitTo_Click);
            // 
            // btnOpenSplit
            // 
            this.btnOpenSplit.Location = new System.Drawing.Point(6, 47);
            this.btnOpenSplit.Name = "btnOpenSplit";
            this.btnOpenSplit.Size = new System.Drawing.Size(109, 23);
            this.btnOpenSplit.TabIndex = 5;
            this.btnOpenSplit.Text = "Ouvrir WIM";
            this.btnOpenSplit.UseVisualStyleBackColor = true;
            this.btnOpenSplit.Click += new System.EventHandler(this.btnOpenSplit_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.DarkGray;
            this.about.Controls.Add(this.label8);
            this.about.Controls.Add(this.label6);
            this.about.Controls.Add(this.label5);
            this.about.Controls.Add(this.label4);
            this.about.Controls.Add(this.label3);
            this.about.Controls.Add(this.label2);
            this.about.Location = new System.Drawing.Point(4, 22);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(711, 319);
            this.about.TabIndex = 3;
            this.about.Text = "A propos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(504, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "inspiré de DISM GUI et le plus ancien GImageX avec quelques modifications et pref" +
    "erences personnelles ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Version 0.2.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(583, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Je ne suis responsable d\'aucunes mauvaises utilisation de ce programme. Je le fou" +
    "rnis tel quel à vous d\'en faire bon usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Programme Libre ouvert au modifications et aux critiques constructives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Première programmation système de Jules GROSPEILLER";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 363);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(715, 183);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.WordWrap = false;
            // 
            // btnResetOutput
            // 
            this.btnResetOutput.Location = new System.Drawing.Point(619, 552);
            this.btnResetOutput.Name = "btnResetOutput";
            this.btnResetOutput.Size = new System.Drawing.Size(93, 23);
            this.btnResetOutput.TabIndex = 2;
            this.btnResetOutput.Text = "Remise à zero";
            this.btnResetOutput.UseVisualStyleBackColor = true;
            this.btnResetOutput.Click += new System.EventHandler(this.btnResetOutput_Click);
            // 
            // GraphDismMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 587);
            this.Controls.Add(this.btnResetOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphDismMain";
            this.ShowIcon = false;
            this.Text = "GraphDISM by Jules";
            this.tabControl1.ResumeLayout(false);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.mount.ResumeLayout(false);
            this.mount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMoutIndex)).EndInit();
            this.Exporter.ResumeLayout(false);
            this.Exporter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.Splitter.ResumeLayout(false);
            this.Splitter.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Information;
        private System.Windows.Forms.TabPage Exporter;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOpenFileInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtPathInfo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtExportFrom;
        private System.Windows.Forms.Button btnOpenWimExp;
        private System.Windows.Forms.TextBox txtExportTo;
        private System.Windows.Forms.Button btnExportTo;
        private System.Windows.Forms.CheckBox chkVerifyExport;
        private System.Windows.Forms.CheckBox chkOpenNewFormInfo;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.CheckBox chkBoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompress;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResetOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Splitter;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSizeSplit;
        private System.Windows.Forms.TextBox txtSplitTo;
        private System.Windows.Forms.TextBox txtOpenSplit;
        private System.Windows.Forms.Button btnSplitTo;
        private System.Windows.Forms.Button btnOpenSplit;
        private System.Windows.Forms.CheckBox chkVerifySplit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage mount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown cbbMoutIndex;
        private System.Windows.Forms.TextBox txtMountFrom;
        private System.Windows.Forms.Button btnOpenWimMount;
        private System.Windows.Forms.TextBox txtMountTo;
        private System.Windows.Forms.Button btnMountTo;
        private System.Windows.Forms.CheckBox chkCheckIntegrityMount;
        private System.Windows.Forms.CheckBox chkOptimizeMount;
        private System.Windows.Forms.CheckBox chkReadOnlyMout;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkAppendUnmount;
        private System.Windows.Forms.CheckBox chkCheckIntegrityUnmount;
        private System.Windows.Forms.CheckBox chkCommitUnmount;
        private System.Windows.Forms.Button btnUnmout;
    }
}

