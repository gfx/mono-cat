
monocat: Cat.exe
	PATH=/bin:/usr/bin AS="$(AS) -arch i386" CC="$(CC) -arch i386" mkbundle -o $@ $<

Cat.exe: Cat.cs
	mcs -r:Mono.Posix -o $@ $<


