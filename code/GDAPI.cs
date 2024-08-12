using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace GDDownloader
{
    internal class GDDownloaderConsole
    {
        public async Task SearchAndDownloadVersionAsync(string version, string downloadPath)
        {
            string downloadUrl = await FindDownloadLinkAsync(version);

            if (string.IsNullOrEmpty(downloadUrl))
            {
                Console.WriteLine($"Could not find a download link for version {version}.");
                return;
            }

            using (var httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(downloadUrl);
                    response.EnsureSuccessStatusCode();

                    // Download the content
                    string tempPath = Path.Combine(downloadPath, $"GD{version}.zip");
                    using (var fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await response.Content.CopyToAsync(fileStream);
                    }

                    // Extract the ZIP file
                    string extractPath = Path.Combine(downloadPath, $"GD{version}");
                    ZipFile.ExtractToDirectory(tempPath, extractPath);

                    // Move all files, including DLLs, to the root of GD{version} folder
                    MoveFilesToRoot(extractPath);

                    // Rename the main executable to GD{version}.exe
                    RenameExecutable(extractPath, version);

                    File.Delete(tempPath); // Clean up the original ZIP file

                    Console.WriteLine($"Version {version} downloaded, extracted, and organized successfully at {extractPath}");
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }

        private async Task<string> FindDownloadLinkAsync(string version)
        {
            // Example of using HtmlAgilityPack to search for the download link
            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync("https://example.com/search?q=Geometry+Dash+" + version);

            // Navigate the HTML to find the link (this is an example and will need to be adapted)
            var linkNode = doc.DocumentNode.SelectSingleNode("//a[contains(@href, 'download')]");

            if (linkNode != null)
            {
                return linkNode.GetAttributeValue("href", string.Empty);
            }

            return null;
        }

        private void MoveFilesToRoot(string rootPath)
        {
            var allFiles = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (var file in allFiles)
            {
                string fileName = Path.GetFileName(file);
                string destinationPath = Path.Combine(rootPath, fileName);

                // If the file is in a subfolder, move it to the root
                if (!file.Equals(destinationPath, StringComparison.OrdinalIgnoreCase))
                {
                    File.Move(file, destinationPath, true);
                }
            }

            // Clean up empty directories
            foreach (var directory in Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories))
            {
                if (!Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    Directory.Delete(directory);
                }
            }
        }

        private void RenameExecutable(string rootPath, string version)
        {
            var exeFiles = Directory.GetFiles(rootPath, "*.exe", SearchOption.TopDirectoryOnly);

            if (exeFiles.Length == 1)
            {
                string exeFilePath = exeFiles[0];
                string newExeFilePath = Path.Combine(rootPath, $"GD{version}.exe");

                File.Move(exeFilePath, newExeFilePath);
                Console.WriteLine($"Renamed executable to {newExeFilePath}");
            }
            else
            {
                Console.WriteLine("No .exe file found or multiple .exe files found in the root directory.");
            }
        }
    }
}
