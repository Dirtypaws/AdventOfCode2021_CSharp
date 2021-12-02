using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AOC.Tests
{
    public abstract class DataFile<T> : IEnumerable<object[]>
    {
        public abstract string Filename { get; }

        protected IEnumerable<object[]> Data
        {
            get
            {
                using var stream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream(Filename);
                if (stream == null)
                    throw new ArgumentOutOfRangeException(nameof(stream), $"Could not find embedded resource");

                using var reader = new StreamReader(stream, Encoding.UTF8);
                var result = new List<T>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;

                    result.Add(Transform(line));
                }

                yield return new object[]
                {
                    result.ToArray()
                };
            }
        }

        public abstract T Transform(string line);

        public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}