namespace Extension_Methods {
    internal class Program {
        static void Main(string[] args) {
            var str = "this is a test.";

            str.Debug("str is");

            var i = 12;
                i.Debug("i is");

            i.Cubed().Debug("I Cubed");

            i.Func().Debug($"f({i}) =");
        }
    }
}

