using MyTestTask.Docsvision.Logic;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace MyTestTask.Docsvision
{
    /// <summary>
    /// Форма подключение к DV
    /// </summary>
    public partial class ConnectingToDocsvision : Form
    {
        private readonly ConnectingToDocsvisionLogic _connectingToDocsvisionLogic = new ConnectingToDocsvisionLogic();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public ConnectingToDocsvision()
        {
            InitializeComponent();
            connectAddress.Text = ConfigurationManager.AppSettings["connectAddress"];
            baseName.Text = ConfigurationManager.AppSettings["baseName"];  
        }

        /// <summary>
        /// Создание карточки
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CreateCard_Click(object sender, EventArgs e)
        {
            _connectingToDocsvisionLogic.CreateCard();
        }

        /// <summary>
        /// Подключение к базе DV
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var address = connectAddress.Text;
            var nameBase = baseName.Text;
            CreateCard.Enabled = _connectingToDocsvisionLogic.Connect(address, nameBase);        
        }

        /// <summary>
        /// Изменение поля - Адрес
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void connectAddress_TextChanged(object sender, EventArgs e)
        {
            CreateCard.Enabled = false;
        }

        /// <summary>
        /// Изменения поля - Имя базы
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void baseName_TextChanged(object sender, EventArgs e)
        {
            CreateCard.Enabled = false;
        }
    }
}
