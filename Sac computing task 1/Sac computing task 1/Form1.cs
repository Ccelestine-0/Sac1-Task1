namespace Sac_computing_task_1
{
    public partial class Form1 : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void resetInputs()
        {
            numPrice.Value = 0;
            numAge.Value = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int age = (int)numAge.Value;
            float purchasedPrice = (float)numPrice.Value;
            float total = 0f;

            if (age == 0 | purchasedPrice == 0.0)
            {
                lblOutput.Text = "Enter Valid Price or Year";
            }
            else
            {
                float currentValue = CalculateCurrentValue(purchasedPrice, age);
                total += currentValue;
                lblOutput.Text = $"The textbook is worth {currentValue}.\n The collection so far is worth {total}";
            }

            resetInputs();
        }

        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depreciation = purchasedValue * 0.2f * age;
            if (depreciation > purchasedValue) return 0f;
            return purchasedValue - depreciation;
        }

        private void btnResetClick(object sender, EventArgs e)
        {
            resetInputs();
            lblOutput.Text = "";
        }

        private void InitializeComponent()
        {
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(228, 152);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(180, 31);
            this.numAge.TabIndex = 0;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(228, 269);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(180, 31);
            this.numPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "How Old is the Textbook?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "How much did you pay for it?";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(610, 101);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(59, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(button1_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(559, 346);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(145, 34);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "End the Quote";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(963, 530);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numAge);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private NumericUpDown numAge;
        private NumericUpDown numPrice;
        private Label label1;
        private Label label2;
        private Label lblOutput;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Button btnEnd;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}










