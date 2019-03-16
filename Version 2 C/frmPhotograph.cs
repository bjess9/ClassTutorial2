namespace Version_2_C
{
    sealed partial class frmPhotograph : Version_2_C.frmWork
    {
        private frmPhotograph()
        {
            InitializeComponent();
        }

        public static void Run(clsPhotograph prPhotograph)
        {
            Instance.SetDetails(prPhotograph);
        }

        public static readonly frmPhotograph Instance = new frmPhotograph();

        protected override void updateForm()
        {
            base.updateForm();
            clsPhotograph lcWork = (clsPhotograph)this._Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsPhotograph lcWork = (clsPhotograph)_Work;
            lcWork.Width = float.Parse(txtWidth.Text);
            lcWork.Height = float.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }
    }
}

