using System;

namespace DatabaseModels
{
    /// <summary>
    /// Сущность пользователь
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// ИД пользователя
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
