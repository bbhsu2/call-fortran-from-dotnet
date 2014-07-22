#Calling Fortran Assemblies from .NET

##C\#
![image](https://raw.github.com/bbhsu2/call-fortran-from-dotnet/master/assets/csharp.png)

##F\#
![image](https://raw.github.com/bbhsu2/call-fortran-from-dotnet/master/assets/fsharp.png)


This is featured code from the blog post titled: [Calling Fortran assemblies from .NET](http://letsthinkabout.us/post/calling-fortran-assemblies-from-net)

In here, I include calling a Fortran dll from C# and F#.  The dll is already built but if you'd like to, you can build it like this:

``gfortran -c myfile1.f90``

``gfortran -c myfile2.f90``

then

``gfortran -shared -o -mydll.dll myfile1.o myfile2.o``

I highlight everything else in the blog post!

##Enjoy!

&copy; 2014 All Good People LLC