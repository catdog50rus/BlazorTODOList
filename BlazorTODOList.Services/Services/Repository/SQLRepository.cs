using BlazorTODOList.Models.Models;
using BlazorTODOList.Services.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTODOList.Services.Services.Repository
{
    /// <summary>
    /// Обработка контекста БД
    /// </summary>
    public class SQLRepository : IRepository
    {
        private readonly DB _context;

        public SQLRepository(DB context)
        {
            _context = context;
        }

        #region Интерфейс

        /// <summary>
        /// Добавить дело в список
        /// </summary>
        /// <param name="todoName"></param>
        public void AddTodo(TodoItem addItem)
        {
            if(addItem != null)
            {
                _context.TodoItems.Add(addItem);
                SaveChanges();
            }
            
        }

        /// <summary>
        /// Удалить дело из списка
        /// </summary>
        /// <param name="id"></param>
        public void DeleteItem(int id)
        {
            var item = _context.TodoItems.Find(id);
            if(item != null)
            {
                _context.TodoItems.Remove(item);
                SaveChanges();
            }
        }

        /// <summary>
        /// Получить список дел
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TodoItem> GetAllItems()
        {
            return _context.TodoItems;
        }

        /// <summary>
        /// Изменить дело
        /// </summary>
        /// <param name="item"></param>
        public void ValueChanged(TodoItem changedItem)
        {
            //Вносим изменения в дело
            var item = _context.TodoItems.Attach(changedItem);
            //Применяем изменения
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            SaveChanges();
        }

        #endregion

        /// <summary>
        /// Запись в БД
        /// </summary>
        private void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}
