using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{

    /// <summary>
    /// интерфейс объекта, способного к выполнению в реде модели
    /// </summary>
    interface IRunable
    {
        /// <summary>
        /// результат расчета, позволяет указать логическое значение, сообщение и числовоой результат
        /// </summary>
        TSimResult Result { get; set; }

        /// <summary>
        /// запуск расчета N раз
        /// </summary>
        /// <param name="N">количество шагов расчета</param>
        void Run(int N=1);
        /// <summary>
        /// запуск расчета 1 раз
        /// </summary>
        void RunOnce();
        /// <summary>
        /// запуск расчета в первый раз, если необходимо
        /// </summary>
        void RunFirst();
    }
}
