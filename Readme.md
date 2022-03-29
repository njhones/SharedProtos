Scheduling Shared Proto Files
========================================

Add the proto files to the Protos folder. 


Use the protoc tool to generate the .cs files

``` ps
protoc --proto_path=. --csharp_out=. --csharp_opt=file_extension=.cs [foo.proto]
```

Increase the package version in the nuspec file

Create the package using nuget tool

``` ps
nuget.exe pack Carvana.Sched.Protos.nuspec
```

