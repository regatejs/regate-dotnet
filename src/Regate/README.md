To create a version:

1. Open `Regate.nuspec` and change the version.
2. In the command line, run the following command:
   ```
   nuget pack
   ```

3. It will create a file like `Regate.0.3.0.nupkg` based on your version.
4. Run the following command:
   ```
   nuget push Regate.0.3.0.nupkg -Source https://api.nuget.org/v3/index.json
   ```