using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeTarefas.Enums
{
    public enum TaskStatus
    {
       [Description("To do")]
       toDo = 1,
       [Description("In progress")]
       inProgress = 2,
       [Description("Completed")]
       completed = 3
    }
}