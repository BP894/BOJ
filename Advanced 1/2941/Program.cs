namespace _2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            int count = 0;

            for(int i = 0; i < input.Length; i++)
            {
                //01. c=, c-   
                if (input[i].Equals('c'))
                {
                    // IndexOutofRange 예방
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('='))
                        {
                            count++;
                            i++;
                            continue;
                        }

                        if (input[i + 1].Equals('-'))
                        {
                            count++;
                            i++;
                            continue;
                        }
                    }
                }

                //02. dz=, d-
                if (input[i].Equals('d'))
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('z'))
                        {
                            if (i < input.Length - 2)
                            {
                                if (input[i + 2].Equals('='))
                                {
                                    count++;
                                    i += 2;
                                    continue;
                                } 
                            }
                        }
                        if (input[i + 1].Equals('-'))
                        {
                            count++;
                            i++;
                            continue;
                        } 
                    }
                }
                //03. lj
                if (input[i].Equals('l'))
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('j'))
                        {
                            count++;
                            i++;
                            continue;
                        } 
                    }
                }
                //04. nj
                if (input[i].Equals('n'))
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('j'))
                        {
                            count++;
                            i++;
                            continue;
                        } 
                    }
                }
                //05. s=
                if (input[i].Equals('s'))
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('='))
                        {
                            count++;
                            i++;
                            continue;
                        } 
                    }
                }
                //06. z=
                if (input[i].Equals('z'))
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i + 1].Equals('='))
                        {
                            count++;
                            i++;
                            continue;
                        } 
                    }
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}