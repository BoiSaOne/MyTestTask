using DocsVision.BackOffice.ObjectModel;
using MyTestTask.Docsvision.Helpers;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MyTestTask.Docsvision.Logic
{
    /// <summary>
    /// Логика для работы с подключением к DV
    /// </summary>
    internal class ConnectingToDocsvisionLogic
    {
        private Helper _helper;

        /// <summary>
        /// Подключение к базе DV
        /// </summary>
        /// <param name="address">Адрес подключения</param>
        /// <param name="baseName">Имя базы</param>
        /// <returns>Удалось подключиться - Истина</returns>
        internal bool Connect(string address, string baseName)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Поле адрес не должно быть пустым");
                return false;
            }

            try
            {
                _helper = new Helper(address, baseName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;             
            }

            return true;
        }

        /// <summary>
        /// Создание карточки
        /// </summary>
        internal void CreateCard()
        {
            Document document = _helper.DocumentService.CreateDocument();
            document.Description = $"Создали обработкой {Assembly.GetEntryAssembly().FullName}";
            _helper.ObjectContext.SaveObject(document);
            MessageBox.Show($"Добавили новый документ в {DateTime.Now}");
        }
    }
}
