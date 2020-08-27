using BlazorTODOList.Models.Models;
using System.Collections.Generic;

namespace BlazorTODOList.Services.Services.Repository
{
    public interface IRepository
    {
        /// <summary>
        /// Получить список дел
        /// </summary>
        /// <returns></returns>
        IEnumerable<TodoItem> GetAllItems();
        /// <summary>
        /// Добавить дело в список
        /// </summary>
        /// <param name="todoName"></param>
        void AddTodo(TodoItem addItem);
        /// <summary>
        /// Изменить дело
        /// </summary>
        /// <param name="item"></param>
        void ValueChanged(TodoItem changedItem);
        /// <summary>
        /// Удалить дело из списка
        /// </summary>
        /// <param name="id"></param>
        void DeleteItem(int id);
    }
}
