using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace FileSearcher
{
    public partial class MainForm : Form
    {
        private ISearcher searcher;
        private string path;
        private delegate void AddToTreeDelegate(string file);
        AddToTreeDelegate addToTreeDelegate;

        public MainForm()
        {
            addToTreeDelegate = AddToTree;
            searcher = new Searcher();
            searcher.Found += OnFound;
            InitializeComponent();

            Snapshot snapshot = Snapshot.Deserialize("parameters.xml");
            PathTextBox.Text = snapshot.Path;
            searchPatternTextBox.Text = snapshot.Pattern;
            insideTextTextBox.Text = snapshot.InsideText;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            path = PathTextBox.Text;

            if (searchPatternTextBox.Text.Contains("\\"))
            {
                MessageBox.Show("Mask contains forbidden symbols!");
            }
            else
            {
                if (Directory.Exists(path))
                {
                    ResultTreeView.Nodes.Clear();
                    ResultTreeView.Nodes.Add(new TreeNode(new DirectoryInfo(PathTextBox.Text).Name));

                    searcher.StartSearch(path, searchPatternTextBox.Text, insideTextTextBox.Text);
                }
                else
                    MessageBox.Show("Path not found!");
            }
        }

        private void pauseToolButton_Click(object sender, EventArgs e)
        {
            searcher.Pause();
        }

        private void continueToolButton_Click(object sender, EventArgs e)
        {
            searcher.Continue();
        }

        private void stoplStripButton_Click(object sender, EventArgs e)
        {
            searcher.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTimeStatusLabel.Text = searcher.ElapsedTime;
            filesFoundStatusLabel.Text = $"Files found: {searcher.FilesFound}";
            CurrentFileStatusLabel.Text = searcher.CurrentFile;
        }

        private void OnFound(string file)
        {
            ResultTreeView.BeginInvoke(addToTreeDelegate, file);
        }

        private void AddToTree(string file)
        {
            TreeNode currentNode = ResultTreeView.TopNode;
            Stack<string> splitedPath = SplitPath(file, path);
            bool isFolderFound;
            while (splitedPath.Count > 0)
            {
                isFolderFound = false;
                foreach (TreeNode node in currentNode.Nodes)
                {
                    if (node.Text == splitedPath.Peek())
                    {
                        currentNode = node;
                        splitedPath.Pop();
                        isFolderFound = true;
                        break;
                    }
                }

                if (isFolderFound == false)
                {
                    TreeNode newNode = new TreeNode(splitedPath.Pop());
                    currentNode.Nodes.Add(newNode);
                    currentNode = newNode;
                }
            }
        }

        private Stack<string> SplitPath(string path, string splitTo)
        {
            DirectoryInfo _path = new DirectoryInfo(path);
            DirectoryInfo _splitTo = new DirectoryInfo(splitTo);

            Stack<string> splitedPath = new Stack<string>();

            while (_path.FullName != _splitTo.FullName && _path.Parent != null)
            {
                splitedPath.Push(_path.Name);
                _path = new DirectoryInfo(_path.Parent.FullName);
            }

            return splitedPath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            searcher.Stop();
            Snapshot snapshot = new Snapshot(PathTextBox.Text, searchPatternTextBox.Text, insideTextTextBox.Text);
            snapshot.Serialize("parameters.xml");
        }
    }
}