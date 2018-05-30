using System;
using System.Collections.Generic;

namespace TextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed cursus viverra lobortis. Proin mi ante, gravida ut felis quis, pulvinar suscipit neque. Sed rhoncus turpis vitae iaculis sagittis. Phasellus vel justo nulla. Quisque bibendum erat venenatis neque dignissim elementum. In neque risus, semper eget aliquet ac, pretium feugiat urna. Donec ac congue dolor. Curabitur tempor libero lacus, sed interdum tortor vestibulum non. Phasellus non nulla pulvinar ex tempor fringilla quis in nisi. Nulla eget rutrum justo, sit amet dignissim nisi. Etiam sit amet quam quis enim lobortis ullamcorper. Fusce nibh dui, pellentesque nec nulla vitae, porta pretium sapien. Morbi bibendum lorem ex, et accumsan orci mattis vulputate.";

            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
