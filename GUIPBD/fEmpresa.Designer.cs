
namespace GUIPBD
{
    partial class fEmpresa
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
            System.Windows.Forms.Label idEmpresaLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmpresa));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progBasDatDataSet = new GUIPBD.ProgBasDatDataSet();
            this.idEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.empresaTableAdapter = new GUIPBD.ProgBasDatDataSetTableAdapters.EmpresaTableAdapter();
            this.tableAdapterManager = new GUIPBD.ProgBasDatDataSetTableAdapters.TableAdapterManager();
            this.empresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.empresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idEmpresaLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBasDatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).BeginInit();
            this.empresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idEmpresaLabel
            // 
            idEmpresaLabel.AutoSize = true;
            idEmpresaLabel.Location = new System.Drawing.Point(33, 18);
            idEmpresaLabel.Name = "idEmpresaLabel";
            idEmpresaLabel.Size = new System.Drawing.Size(63, 13);
            idEmpresaLabel.TabIndex = 3;
            idEmpresaLabel.Text = "Id Empresa:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(33, 64);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 4;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(816, 100);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(206, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 73);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(109, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 73);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(12, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(91, 73);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Controls.Add(razonSocialLabel);
            this.pnlDetalles.Controls.Add(this.razonSocialTextBox);
            this.pnlDetalles.Controls.Add(idEmpresaLabel);
            this.pnlDetalles.Controls.Add(this.idEmpresaTextBox);
            this.pnlDetalles.Controls.Add(this.btnCancelar);
            this.pnlDetalles.Controls.Add(this.btnGuardar);
            this.pnlDetalles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalles.Location = new System.Drawing.Point(0, 401);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(816, 88);
            this.pnlDetalles.TabIndex = 1;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(112, 61);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(412, 20);
            this.razonSocialTextBox.TabIndex = 5;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.progBasDatDataSet;
            // 
            // progBasDatDataSet
            // 
            this.progBasDatDataSet.DataSetName = "ProgBasDatDataSet";
            this.progBasDatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idEmpresaTextBox
            // 
            this.idEmpresaTextBox.AllowDrop = true;
            this.idEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "IdEmpresa", true));
            this.idEmpresaTextBox.Enabled = false;
            this.idEmpresaTextBox.Location = new System.Drawing.Point(102, 15);
            this.idEmpresaTextBox.Name = "idEmpresaTextBox";
            this.idEmpresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEmpresaTextBox.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(713, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 73);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(616, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 73);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUIPBD.ProgBasDatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresaBindingNavigator
            // 
            this.empresaBindingNavigator.AddNewItem = null;
            this.empresaBindingNavigator.BindingSource = this.empresaBindingSource;
            this.empresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empresaBindingNavigator.DeleteItem = null;
            this.empresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.empresaBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.empresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empresaBindingNavigator.Name = "empresaBindingNavigator";
            this.empresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empresaBindingNavigator.Size = new System.Drawing.Size(816, 25);
            this.empresaBindingNavigator.TabIndex = 2;
            this.empresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // empresaDataGridView
            // 
            this.empresaDataGridView.AllowUserToAddRows = false;
            this.empresaDataGridView.AllowUserToDeleteRows = false;
            this.empresaDataGridView.AllowUserToOrderColumns = true;
            this.empresaDataGridView.AutoGenerateColumns = false;
            this.empresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.empresaDataGridView.DataSource = this.empresaBindingSource;
            this.empresaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresaDataGridView.Location = new System.Drawing.Point(0, 125);
            this.empresaDataGridView.Name = "empresaDataGridView";
            this.empresaDataGridView.ReadOnly = true;
            this.empresaDataGridView.Size = new System.Drawing.Size(816, 276);
            this.empresaDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmpresa";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmpresa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial";
            this.dataGridViewTextBoxColumn2.HeaderText = "RazonSocial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.empresaDataGridView);
            this.Controls.Add(this.empresaBindingNavigator);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.pnlBotones);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.fEmpresa_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBasDatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).EndInit();
            this.empresaBindingNavigator.ResumeLayout(false);
            this.empresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private ProgBasDatDataSet progBasDatDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private ProgBasDatDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private ProgBasDatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empresaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView empresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox idEmpresaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}