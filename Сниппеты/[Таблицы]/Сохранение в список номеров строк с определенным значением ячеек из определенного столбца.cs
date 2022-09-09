// берем из переменной текст, по которому будут искаться номера строк
var textContains = project.Variables["peremennaya"].Value;
// задаем таблицу, в которой будем искать
var sourceTable = project.Tables["Таблица1"];

// Номер столбца, по которому ищем (отсчет от 0!!!)
var searchColIndex = 2;

// Ищем в каждой строчке в таблице
for(int rowIndex = 0; rowIndex < sourceTable.RowCount; rowIndex++)
{
    // Читаем строку из таблицы 
    var cells = sourceTable.GetRow(rowIndex).ToArray();
   // if (cells[searchColIndex].Contains(textContains)) // ищет по логике "содержит"
	if (cells[searchColIndex] == textContains) // ищет по логике "равно"
    {
        project.Lists["Список"].Add(rowIndex + 1); // если отмечено "Первая строка - Заголовки" в настройках таблицы
        // project.Lists["Список"].Add(rowIndex); // если НЕ отмечено "Первая строка - Заголовки" в настройках таблицы
    }
}
