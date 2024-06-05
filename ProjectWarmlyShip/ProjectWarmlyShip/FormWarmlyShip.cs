using ProjectWarmlyShip.Drawnings;
using ProjectWarmlyShip.MovementStrategy;

namespace ProjectWarmlyShip
{
    public partial class FormWarmlyShip : Form
    {
        private DrawningShip? _drawningShip;
        private AbstractStrategy? _strategy;
        /// <summary>
        /// Получение объекта
        /// </summary>
        public DrawningShip SetShip
        {
            set
            {
                _drawningShip = value;
                _drawningShip.SetPictureSize(pictureBoxWarmlyShip.Width, pictureBoxWarmlyShip.Height);
                comboBoxStrategy.Enabled = true;
                Draw();
            }
        }
        public FormWarmlyShip()
        {
            InitializeComponent();
            _strategy = null;
        }
        private void Draw()
        {
            if (_drawningShip == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxWarmlyShip.Width, pictureBoxWarmlyShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningShip.DrawTransport(gr);
            pictureBoxWarmlyShip.Image = bmp;
        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawningShip == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningShip.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningShip.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningShip.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningShip.MoveTransport(DirectionType.Right);
                    break;
            }
            if (result)
            {
                Draw();
            }
        }
        private void buttonStrategyStep_Click(object sender, EventArgs e)
        {
            if (_drawningShip == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _strategy = comboBoxStrategy.SelectedIndex switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null,
                };
                if (_strategy == null)
                {
                    return;
                }
                _strategy.SetData(new MoveableShip(_drawningShip),
                pictureBoxWarmlyShip.Width, pictureBoxWarmlyShip.Height);
            }
            if (_strategy == null)
            {
                return;
            }
            comboBoxStrategy.Enabled = false;
            _strategy.MakeStep();
            Draw();
            if (_strategy.GetStatus == StrategyStatus.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _strategy = null;
            }
        }
    }
}
