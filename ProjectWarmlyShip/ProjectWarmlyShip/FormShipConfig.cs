using ProjectWarmlyShip.Drawnings;
using ProjectWarmlyShip.Entities;

namespace ProjectWarmlyShip;

public partial class FormShipConfig : Form
{
    private DrawningShip? _ship = null;
    private event Action<DrawningShip>? ShipDelegate;
    public FormShipConfig()
    {
        InitializeComponent();
        panelRed.MouseDown += Panel_MouseDown;
        panelGreen.MouseDown += Panel_MouseDown;
        panelBlue.MouseDown += Panel_MouseDown;
        panelYellow.MouseDown += Panel_MouseDown;
        panelWhite.MouseDown += Panel_MouseDown;
        panelGrey.MouseDown += Panel_MouseDown;
        panelBlack.MouseDown += Panel_MouseDown;
        panelPurple.MouseDown += Panel_MouseDown;
        // TODO buttonCancel.Click привязать анонимный метод через lambda с закрытием формы
        buttonCancel.Click += (sender, e) => Close();
    }
    public void AddEvent(Action<DrawningShip> shipDelegate)
    {
        if (ShipDelegate == null)
        {
            ShipDelegate = shipDelegate;
        }
        else
        {
            ShipDelegate += shipDelegate;
        }
    }
    private void DrawObject()
    {
        Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
        Graphics gr = Graphics.FromImage(bmp);
        _ship?.SetPictureSize(pictureBoxObject.Width, pictureBoxObject.Height);
        _ship?.SetPosition(5, 5);
        _ship?.DrawTransport(gr);
        pictureBoxObject.Image = bmp;
    }
    private void labelObject_MouseDown(object sender, MouseEventArgs e)
    {
        (sender as Label)?.DoDragDrop((sender as Label)?.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
    }
    private void panelObject_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.Text) ?? false)
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
    private void panelObject_DragDrop(object sender, DragEventArgs e)
    {
        switch (e.Data?.GetData(DataFormats.Text)?.ToString())
        {
            case "labelSimpleObject":
                _ship = new DrawningShip((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White);
                break;
            case "labelModifiedObject":
                _ship = new DrawningWarmlyShip((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value,
                            Color.White, Color.Black, checkBoxPipes.Checked, checkBoxFuelTank.Checked);
                break;
        }
        labelBodyColor.BackColor = Color.Empty;
        labelAdditionalColor.BackColor = Color.Empty;
        DrawObject();
    }
    private void Panel_MouseDown(object? sender, MouseEventArgs e)
    {
        // TODO отправка цвета в Drag&Drop
        (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
    }
    // TODO Реализовать логику смены цветов: основного и дополнительного (для продвинутого объекта)
    private void labelBodyColor_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(typeof(Color)))
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
    private void labelBodyColor_DragDrop(object sender, DragEventArgs e)
    {
        if (_ship != null)
        {
            _ship.EntityShip.setBodyColor((Color)e.Data.GetData(typeof(Color)));
            DrawObject();
        }
    }
    private void labelAdditionalColor_DragEnter(object sender, DragEventArgs e)
    {
        if (_ship is DrawningWarmlyShip)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }

    private void labelAdditionalColor_DragDrop(object sender, DragEventArgs e)
    {
        if (_ship.EntityShip is EntityWarmlyShip _warmlyship)
        {
            _warmlyship.setAdditionalColor((Color)e.Data.GetData(typeof(Color)));
        }
        DrawObject();
    }
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (_ship != null)
        {
            ShipDelegate?.Invoke(_ship);
            Close();
        }
    }
}
