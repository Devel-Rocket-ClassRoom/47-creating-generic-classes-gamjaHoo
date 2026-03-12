using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConverter
{
    internal class Converter<TInput, TOutput>
    {
        private Func<TInput, TOutput> _func;
        public Converter(Func<TInput, TOutput> func)
        {
            this._func = func;
        }

        public TOutput Convert(TInput input)
        {
            return _func(input);
        }

        public TOutput[] ConvertAll(TInput[] input)
        {
            TOutput[] outputs = new TOutput[input.Length];
            for(int i = 0;  i < input.Length; i++)
            {
                outputs[i] = _func(input[i]);
            }
            return outputs;
        }
    }
}
