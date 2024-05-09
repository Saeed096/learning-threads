namespace learning
{
    internal static class Program
    {
        public static T First<T>(this IEnumerable<T> sequence)  // check caller implement ienumerable of which type >> then assign this type in T 
        {
            foreach (T element in sequence)
                return element;
            throw new InvalidOperationException("No elements!");
        }
        
        static void print ()
        {
            Console.WriteLine("ss");
        }
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");
            //  Console.WriteLine(Thread.CurrentThread);

            //  Thread t = new Thread(print);
            //  t.Start();
            //  bool blocked = (Thread.CurrentThread.ThreadState & ThreadState.WaitSleepJoin) != 0;
            //  Console.WriteLine($"block status is :{blocked} ");
            //  Console.WriteLine(t.Join(200000));  // not a must to wait for 20 sec >> if func in thread finished quickly blocking will be over       // return false >> waiting time was useless as thread didnot finish its work also , return true >> waiting useful as it finishes ....   // here main thread is blocked till child is continued or 20 sec pass which faster
            ////  Thread.Sleep(5000);              // a must to wait for 5 sec
            //  Console.WriteLine("sd");


            // new Thread(print).Start(); // no ref for this thread

            //  //Thread t2 = new Thread (print);     // to send param u can use thread start deleg which allow u only to refer for a func no param and no return , or use deleg from parameterized thread start >> allow to refer for a func takes one parameter from class obj >> also not good enough as it is only allow 1 param and u have to cast obj then... >> best sol to use lambda exp >> send whatever u want

            //  for (int i = 0; i < 10; i++)
            //  {
            //     // int temp = i;
            //      new Thread(() => Console.Write(i)).Start();
            //  }

            //  Thread worker = new Thread(() => Console.ReadLine());
            //  if (args.Length > 0)      // that means  false >> args length = 0 >> thread will be foreg.. by def >> no termination before readline and vice versa
            //      worker.IsBackground = true;
            //  worker.Start();

            // Console.WriteLine($"is current thread is pool thread? {Thread.CurrentThread.IsThreadPoolThread}");


            // Task.Run(() => Console.ReadLine());

            //  Task.Run(() => Console.WriteLine("Foo"));
            //  //Console.ReadLine();
            //  Console.WriteLine("after");        // may be printed bef foo , if read line >> foo 99% will be executed first as u write and device read that may take time which is enough for child thread to be executed

            //  Task.Run(() => Console.WriteLine("hot task"));   // start immediately
            //  Task t3 = new Task(()=>Console.WriteLine("cold task"));   // must call start 
            //  t3.Start();  

            //Task task = Task.Run(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Foo");
            //});
            //Console.WriteLine(task.IsCompleted); // False
            //task.Wait(); // Blocks until task is complete
            //Console.WriteLine(task.IsCompleted); // true

            //var tcs = new TaskCompletionSource<int>();

            //Task.Delay(5000).GetAwaiter().OnCompleted(() => Console.WriteLine(42));

            // extension method
            Console.WriteLine("Seattle".First()); // S


            // anonymous type
            int Age = 23;
            var dude = new { Name = "Bob", Age, Age.ToString().Length };  // identify >> prop age = age , prop length = age.tostring().length
            Console.WriteLine(dude.Length);
            Console.WriteLine(Age.ToString().Length);

            var a1 = new { X = 2, Y = 4 };
            var a2 = new { X = 2, Y = 4 };
            Console.WriteLine(a1.Equals(a2));    // data comparison   // inside equals >> obj == obj should be ref comp >> false????
            Console.WriteLine(a1.GetType() == a2.GetType());   // type comparison
            Console.WriteLine(a1 == a2); // ref comp..


            var a3 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };  // immutable 
            var a4 = a3 with { E = 10 };                     // only way to update
            Console.WriteLine(a4);


            dynamic d = 10;
            d = "saeed";          // valid >> d.t >> detected in r.t
            Console.WriteLine(d);
            //Console.WriteLine(d.gettype);       // err?????


            var v = 9;  // must initialize
            //v = "sa";       // invalid >> d.t detected in c.t 
        }
    }
}
