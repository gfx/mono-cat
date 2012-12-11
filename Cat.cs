using System;
using Mono.Unix.Native;

public class Cat {
    public static void Main(string[] argv) {
        foreach (var file in argv) {
            var fp = Stdlib.fopen(file, "r");
            Int32 c;
            while ( (c = Stdlib.fgetc(fp)) != Stdlib.EOF ) {
                Stdlib.putchar(c);
            }
            Stdlib.fclose(fp);
        }
    }
}
