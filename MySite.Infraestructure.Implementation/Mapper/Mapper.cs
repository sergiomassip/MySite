using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Implementation.Mapper
{
    public abstract class Mapper
    {
        public virtual IEnumerable<TOutput> GetCollection<TInput, TOutput>(IEnumerable<TInput> source)
            where TInput : class
            where TOutput : class
        {
            if (source == null) { yield break; }

            foreach (var item in source)
            {
                yield return Get<TInput, TOutput>(item);
            }
        }

        public abstract TOutput Get<TInput, TOutput>(TInput source)
            where TInput : class
            where TOutput : class;
    }
}
