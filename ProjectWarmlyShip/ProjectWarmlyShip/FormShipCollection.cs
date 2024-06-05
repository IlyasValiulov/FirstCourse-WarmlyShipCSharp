using Microsoft.Extensions.Logging;
using ProjectWarmlyShip.CollectionGenericObjects;
using ProjectWarmlyShip.Drawnings;
using ProjectWarmlyShip.Exceptions;

namespace ProjectWarmlyShip;

public partial class FormShipCollection : Form
{
    private AbstractCompany? _company = null;
    private readonly StorageCollection<DrawningShip> _storageCollection;
    private readonly ILogger _logger;
    public FormShipCollection(ILogger<FormShipCollection> logger)
    {
        InitializeComponent();
        _storageCollection = new();
        _logger = logger;
        _logger.LogInformation("Форма загрузилась");
    }
    private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        panelCompanyTools.Enabled = false;
    }
    private void buttonAddShip_Click(object sender, EventArgs e)
    {
        FormShipConfig form = new();
        form.Show();
        form.AddEvent(SetShip);
    }
    private void SetShip(DrawningShip? ship)
    {
        try
        {
            if (_company == null || ship == null)
            {
                return;
            }
            if (_company + ship != -1)
            {
                MessageBox.Show("Объект добавлен");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Добавлен объект: " + ship.GetDataForSave());
            }
        }
        catch (ObjectNotFoundException) { }
        catch (CollectionOverflowException ex)
        {
            MessageBox.Show("Не удалось добавить объект");
            _logger.LogError("Ошибка: {Message}", ex.Message);
        }
        catch (ObjectIsEqualException ex)
        {
            MessageBox.Show("Не удалось добавить объект");
            _logger.LogError("Ошибка: {Message}", ex.Message);
        }
    }
    private void buttonRemoveShip_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maskedTextBox.Text) || _company == null)
        {
            return;
        }
        if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }
        int pos = Convert.ToInt32(maskedTextBox.Text);
        try
        {
            if (_company - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Удален объект по позиции " + pos);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Не удалось удалить объект");
            _logger.LogError("Ошибка: {Message}", ex.Message);
        }
    }
    private void buttonGoToCheck_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }
        DrawningShip? ship = null;
        int counter = 100;
        try
        {
            while (ship == null)
            {
                ship = _company.GetRandomObject();
                counter--;
                if (counter <= 0)
                {
                    break;
                }
            }
            FormWarmlyShip form = new()
            {
                SetShip = ship
            };
            form.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }
        pictureBox.Image = _company.Show();
    }
    private void buttonCollectionAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
        {
            MessageBox.Show("Не все данные заполнены", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        try
        {
            CollectionType collectionType = CollectionType.None;
            if (radioButtonMassive.Checked)
            {
                collectionType = CollectionType.Massive;
            }
            else if (radioButtonList.Checked)
            {
                collectionType = CollectionType.List;
            }
            _storageCollection.AddCollection(textBoxCollectionName.Text, collectionType);
            RerfreshListBoxItems();
            _logger.LogInformation("Коллекция добавлена " + textBoxCollectionName.Text);
        }
        catch (Exception ex)
        {
            _logger.LogError("Ошибка: {Message}", ex.Message);
        }
    }
    private void RerfreshListBoxItems()
    {
        listBoxCollection.Items.Clear();
        for (int i = 0; i < _storageCollection.Keys?.Count; ++i)
        {
            string? colName = _storageCollection.Keys?[i].Name;
            if (!string.IsNullOrEmpty(colName))
            {
                listBoxCollection.Items.Add(colName);
            }
        }
    }
    private void buttonCollectionDel_Click(object sender, EventArgs e)
    {
        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана");
            return;
        }
        try
        {
            if (MessageBox.Show("Удалить коллекцию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            _storageCollection.DelCollection(listBoxCollection.SelectedItem.ToString());
            RerfreshListBoxItems();
            _logger.LogInformation("Коллекция: " + listBoxCollection.SelectedItem.ToString() + " удалена");
        }
        catch (Exception ex)
        {
            _logger.LogError("Ошибка: {Message}", ex.Message);
        }
    }
    private void buttonCreateCompany_Click(object sender, EventArgs e)
    {
        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана");
            return;
        }
        ICollectionGenericObjects<DrawningShip>? collection =
            _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty];
        if (collection == null)
        {
            MessageBox.Show("Коллекция не проинициализирована");
            return;
        }
        switch (comboBoxSelectorCompany.Text)
        {
            case "Хранилище":
                _company = new ShipPortService(pictureBox.Width, pictureBox.Height, collection);
                break;
        }
        panelCompanyTools.Enabled = true;
        RerfreshListBoxItems();
    }
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _storageCollection.SaveData(saveFileDialog.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logger.LogInformation("Сохранение в файл: {filename}", saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }
        }
    }
    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _storageCollection.LoadData(openFileDialog.FileName);
                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RerfreshListBoxItems();
                _logger.LogInformation("Загрузка из файла: {filename}", openFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }
        }
    }
    private void buttonSortByType_Click(object sender, EventArgs e)
    {
        CompareShip(new DrawningShipCompareByType());
    }
    private void buttonByColor_Click(object sender, EventArgs e)
    {
        CompareShip(new DrawningShipCompareByColor());
    }
    private void CompareShip(IComparer<DrawningShip?> comparer)
    {
        if (_company == null)
        {
            return;
        }
        _company.Sort(comparer);
        pictureBox.Image = _company.Show();
    }

}

