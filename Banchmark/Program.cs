using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace Banchmark
{
    [RankColumn]
    [MemoryDiagnoser]
    public class Test
    {
        private static readonly int size = 1_000_000;
        private static List<int> arr = Enumerable.Range(0, size).ToList();
        [Benchmark]
        public int SomaFixo()
        {
            var soma = 0;
            for (int i = 0; i < size; i++)
            {
                soma += i;
            }
            return soma;
        }

        [Benchmark]
        public int SomaFor()
        {
            var soma = 0;
            for (int i = 0; i <arr.Count; i++)
            {
                soma += arr[i];
            }
            return soma;
        }
        [Benchmark]
        public int SomaForEach()
        {
            var soma = 0;
            arr.ForEach(x => soma += x);
            return soma;
        }
        /*[Benchmark]
        public int SomaArraySum()
        {
            return arr.Sum(x => x);
        }*/
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            var resultado = BenchmarkRunner.Run<Test>();
            /*var teste = new Test();
            Console.WriteLine(teste.SomaArraySum());                
            Console.WriteLine(teste.SomaFor());                
            Console.WriteLine(teste.SomaForEach());
            Console.ReadKey();*/
        }
    }
}