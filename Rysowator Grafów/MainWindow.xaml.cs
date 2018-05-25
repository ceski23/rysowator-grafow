using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;
using Svg;

namespace Rysowator_Grafów
{
    public partial class MainWindow
    {
        private readonly SvgDocument _edgesSvg;
        private readonly SvgDocument _verticesSvg;
        
        public MainWindow()
        {
            InitializeComponent();
            
            
            var fileDialog = new OpenFileDialog
            {
                Filter = "Obrazek z grafem|*.svg"
            };

            if (fileDialog.ShowDialog() == true)
            {
                _edgesSvg = SvgDocument.Open(fileDialog.FileName);
                _verticesSvg = SvgDocument.Open(fileDialog.FileName);
            }
            else Close();
        }

        
        private static List<List<int>> GetColorings()
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Plik z kolorowaniami|*.txt"
            };

            return fileDialog.ShowDialog() == true ? 
                JsonConvert.DeserializeObject<List<List<int>>>(File.ReadAllText(fileDialog.FileName)) : new List<List<int>>();
        }



        private static SvgDocument ColorizeEdges(SvgDocument svgDocument, List<int> coloring)
        {
            for (var i = 0; i < coloring.Count; i++)
            {
                var edge = svgDocument.GetElementById($"e{i+1}");
                if (edge != null)
                {
                    edge.Stroke = new SvgColourServer(GetColor(coloring[i]));
                }
            }

            return svgDocument;
        }
        
        private static SvgDocument ColorizeVertices(SvgDocument svgDocument, List<int> coloring)
        {
            for (var i = 0; i < coloring.Count; i++)
            {
                var vertex = svgDocument.GetElementById($"v{i+1}");
                if (vertex != null)
                {
                    vertex.Fill = new SvgColourServer(GetColor(coloring[i]));
                }
            }

            return svgDocument;
        }
        
        
        private async void VerticesButton_OnClick(object sender, RoutedEventArgs e)
        {
            VerticesButton.IsEnabled = false;
            EdgesButton.IsEnabled = false;
            
            var colorings = GetColorings();
            
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (var i = 0; i < colorings.Count; ++i)
                {
                    await Task.Run(() =>
                    {
                        var bitmap = ColorizeVertices(_verticesSvg, colorings[i]).Draw();
                        bitmap.Save($"{dialog.SelectedPath}/graph_vertices_{i+1}.png", ImageFormat.Png);
                    });
                    
                    var progress = (i + 1) * (colorings.Count / 100);

                    ProgressBar.Value = progress;
                }
            }
            
            VerticesButton.IsEnabled = true;
            EdgesButton.IsEnabled = true;
        }
        
        private async void EdgesButton_OnClick(object sender, RoutedEventArgs e)
        {
            VerticesButton.IsEnabled = false;
            EdgesButton.IsEnabled = false;
            
            var colorings = GetColorings();
            
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (var i = 0; i < colorings.Count; ++i)
                {
                    await Task.Run(() =>
                    {
                        var bitmap = ColorizeEdges(_edgesSvg, colorings[i]).Draw();
                        bitmap.Save($"{dialog.SelectedPath}/graph_edges_{i+1}.png", ImageFormat.Png);
                    });
                    
                    var progress = (i + 1) * (colorings.Count / 100);

                    ProgressBar.Value = progress;
                }
            }
            
            VerticesButton.IsEnabled = true;
            EdgesButton.IsEnabled = true;
        }


        private static Color GetColor(int n)
        {
            Color[] colors =
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Orange,
                Color.BlueViolet,
                Color.Chartreuse,
                Color.DeepPink
            };

            return colors[n];
        }
    }
}