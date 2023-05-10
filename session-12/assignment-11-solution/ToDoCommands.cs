//using assignment_11_solution.Data;
using assignment_11_solution.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    public static class ToDoCommands
    {
        public static string Help()
        {
            var sb = new StringBuilder();
            sb.AppendLine($@"todo help
todo list
todo add ""item name""
todo complete ""item name""
todo incomplete ""item name""");
            return sb.ToString();
        }

        public static string Add(string description)
        {
            int changes = 0;

            using (var ctx = new ToDoContext())
            {
                ctx.ToDos.Add(new ToDo { Description = description });

                try
                {
                    changes = ctx.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var err in ex.EntityValidationErrors)
                    {
                        foreach (var e in err.ValidationErrors)
                        {
                            Console.WriteLine(e.ErrorMessage);
                        }
                    }
                }
            }

            return changes == 1
                ? $"Item '{description}' added successfully"
                : $"Item '{description}' could not be added";
        }

        public static string Complete(string description)
        {
            int changes = 0;

            using (var ctx = new ToDoContext())
            {
                var todo = ctx.ToDos
                    .FirstOrDefault(t => t.Description == description && !t.IsComplete);
                if (todo != null) todo.IsComplete = true;
                changes = ctx.SaveChanges();
            }

            return changes == 1
                ? $"Item '{description}' marked as complete"
                : $"Item '{description}' could not be marked as complete";
        }

        public static string Incomplete(string description)
        {
            int changes = 0;

            using (var ctx = new ToDoContext())
            {
                var todo = ctx.ToDos
                    .FirstOrDefault(t => t.Description == description && t.IsComplete);
                if (todo != null) todo.IsComplete = true;
                changes = ctx.SaveChanges();
            }

            return changes == 1
                ? $"Item '{description}' marked as incomplete"
                : $"Item '{description}' could not be marked as incomplete";
        }

        public static string List()
        {
            var sb = new StringBuilder();
            using (var ctx = new ToDoContext())
            {
                var incompleteItems = ctx.ToDos.ToList();
                foreach (var item in incompleteItems)
                {
                    sb.AppendLine($"{(item.IsComplete ? "x" : "-")} {item.Description}");
                }
            }
            return sb.ToString();
        }
    }
}
