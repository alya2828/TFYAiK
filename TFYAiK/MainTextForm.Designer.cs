namespace TFYAiK
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.lineNumberRichTextBox = new System.Windows.Forms.RichTextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьМасштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьМасштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.cutButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.openNewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            resources.ApplyResources(this.mainSplitContainer.Panel1, "mainSplitContainer.Panel1");
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainSplitContainer.Panel1.Controls.Add(this.textBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.lineNumberRichTextBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainSplitContainer.Panel2.Controls.Add(this.debugLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.debugTextBox);
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Name = "textBox";
            this.textBox.VScroll += new System.EventHandler(this.textBox_VScroll);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lineNumberRichTextBox
            // 
            resources.ApplyResources(this.lineNumberRichTextBox, "lineNumberRichTextBox");
            this.lineNumberRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lineNumberRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberRichTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lineNumberRichTextBox.Name = "lineNumberRichTextBox";
            this.lineNumberRichTextBox.ReadOnly = true;
            // 
            // debugLabel
            // 
            resources.ApplyResources(this.debugLabel, "debugLabel");
            this.debugLabel.Name = "debugLabel";
            // 
            // debugTextBox
            // 
            resources.ApplyResources(this.debugTextBox, "debugTextBox");
            this.debugTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.debugTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.файлToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            resources.ApplyResources(this.создатьToolStripMenuItem, "создатьToolStripMenuItem");
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            resources.ApplyResources(this.сохранитьКакToolStripMenuItem, "сохранитьКакToolStripMenuItem");
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            resources.ApplyResources(this.правкаToolStripMenuItem, "правкаToolStripMenuItem");
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            resources.ApplyResources(this.отменитьToolStripMenuItem, "отменитьToolStripMenuItem");
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            resources.ApplyResources(this.повторитьToolStripMenuItem, "повторитьToolStripMenuItem");
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            resources.ApplyResources(this.вырезатьToolStripMenuItem, "вырезатьToolStripMenuItem");
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            resources.ApplyResources(this.копироватьToolStripMenuItem, "копироватьToolStripMenuItem");
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            resources.ApplyResources(this.вставитьToolStripMenuItem, "вставитьToolStripMenuItem");
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            resources.ApplyResources(this.удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            resources.ApplyResources(this.выделитьВсеToolStripMenuItem, "выделитьВсеToolStripMenuItem");
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem,
            this.текстовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            resources.ApplyResources(this.текстToolStripMenuItem, "текстToolStripMenuItem");
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            resources.ApplyResources(this.постановкаЗадачиToolStripMenuItem, "постановкаЗадачиToolStripMenuItem");
            this.постановкаЗадачиToolStripMenuItem.Click += new System.EventHandler(this.постановкаЗадачиToolStripMenuItem_Click);
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            resources.ApplyResources(this.грамматикаToolStripMenuItem, "грамматикаToolStripMenuItem");
            this.грамматикаToolStripMenuItem.Click += new System.EventHandler(this.грамматикаToolStripMenuItem_Click);
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            this.классификацияГрамматикиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            resources.ApplyResources(this.классификацияГрамматикиToolStripMenuItem, "классификацияГрамматикиToolStripMenuItem");
            this.классификацияГрамматикиToolStripMenuItem.Click += new System.EventHandler(this.классификацияГрамматикиToolStripMenuItem_Click);
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            resources.ApplyResources(this.методАнализаToolStripMenuItem, "методАнализаToolStripMenuItem");
            this.методАнализаToolStripMenuItem.Click += new System.EventHandler(this.методАнализаToolStripMenuItem_Click);
            // 
            // диагностикаИНейтрализацияОшибокToolStripMenuItem
            // 
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Name = "диагностикаИНейтрализацияОшибокToolStripMenuItem";
            resources.ApplyResources(this.диагностикаИНейтрализацияОшибокToolStripMenuItem, "диагностикаИНейтрализацияОшибокToolStripMenuItem");
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Click += new System.EventHandler(this.диагностикаИНейтрализацияОшибокToolStripMenuItem_Click);
            // 
            // текстовыйПримерToolStripMenuItem
            // 
            this.текстовыйПримерToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.текстовыйПримерToolStripMenuItem.Name = "текстовыйПримерToolStripMenuItem";
            resources.ApplyResources(this.текстовыйПримерToolStripMenuItem, "текстовыйПримерToolStripMenuItem");
            this.текстовыйПримерToolStripMenuItem.Click += new System.EventHandler(this.тестовыйПримерToolStripMenuItem_Click);
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            resources.ApplyResources(this.списокЛитературыToolStripMenuItem, "списокЛитературыToolStripMenuItem");
            this.списокЛитературыToolStripMenuItem.Click += new System.EventHandler(this.списокЛитературыToolStripMenuItem_Click);
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            resources.ApplyResources(this.исходныйКодПрограммыToolStripMenuItem, "исходныйКодПрограммыToolStripMenuItem");
            this.исходныйКодПрограммыToolStripMenuItem.Click += new System.EventHandler(this.исходныйКодПрограммыToolStripMenuItem_Click);
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            resources.ApplyResources(this.пускToolStripMenuItem, "пускToolStripMenuItem");
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.ПускToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьМасштабToolStripMenuItem,
            this.уменьшитьМасштабToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            resources.ApplyResources(this.видToolStripMenuItem, "видToolStripMenuItem");
            // 
            // увеличитьМасштабToolStripMenuItem
            // 
            this.увеличитьМасштабToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.увеличитьМасштабToolStripMenuItem.Name = "увеличитьМасштабToolStripMenuItem";
            resources.ApplyResources(this.увеличитьМасштабToolStripMenuItem, "увеличитьМасштабToolStripMenuItem");
            this.увеличитьМасштабToolStripMenuItem.Click += new System.EventHandler(this.УвеличитьМасштабToolStripMenuItem_Click);
            // 
            // уменьшитьМасштабToolStripMenuItem
            // 
            this.уменьшитьМасштабToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.уменьшитьМасштабToolStripMenuItem.Name = "уменьшитьМасштабToolStripMenuItem";
            resources.ApplyResources(this.уменьшитьМасштабToolStripMenuItem, "уменьшитьМасштабToolStripMenuItem");
            this.уменьшитьМасштабToolStripMenuItem.Click += new System.EventHandler(this.УменьшитьМасштабToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            // 
            // вызовСправкиToolStripMenuItem
            // 
            this.вызовСправкиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            resources.ApplyResources(this.вызовСправкиToolStripMenuItem, "вызовСправкиToolStripMenuItem");
            this.вызовСправкиToolStripMenuItem.Click += new System.EventHandler(this.вызовСправкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cutButton
            // 
            resources.ApplyResources(this.cutButton, "cutButton");
            this.cutButton.Name = "cutButton";
            this.cutButton.UseVisualStyleBackColor = true;
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // copyButton
            // 
            resources.ApplyResources(this.copyButton, "copyButton");
            this.copyButton.Name = "copyButton";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pasteButton, "pasteButton");
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.UseVisualStyleBackColor = false;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // undoButton
            // 
            resources.ApplyResources(this.undoButton, "undoButton");
            this.undoButton.Name = "undoButton";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.redoButton, "redoButton");
            this.redoButton.Name = "redoButton";
            this.redoButton.UseVisualStyleBackColor = false;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // createNewButton
            // 
            resources.ApplyResources(this.createNewButton, "createNewButton");
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // openNewButton
            // 
            resources.ApplyResources(this.openNewButton, "openNewButton");
            this.openNewButton.Name = "openNewButton";
            this.openNewButton.UseVisualStyleBackColor = true;
            this.openNewButton.Click += new System.EventHandler(this.openNewButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.openNewButton);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИНейтрализацияОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.RichTextBox lineNumberRichTextBox;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьМасштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьМасштабToolStripMenuItem;
        private System.Windows.Forms.Button openNewButton;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

