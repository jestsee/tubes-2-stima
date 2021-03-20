using System;
using System.Linq;

using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;

namespace tubes2stima
{
    class Visualization
    {
        public void highlightRouteBFS(List<int> path, Graph g,
            System.Windows.Forms.Form form,
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer,
            Microsoft.Msagl.Drawing.Graph graph)
        {
            for (int i = 0; i < path.Count; i++)
            {
                string node = g.getDictionary()[path.ElementAt(i)];

                // change shape
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(node);
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Crimson;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }

        public void highlightRouteDFS(List<string> route, Graph g,
            System.Windows.Forms.Form form,
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer,
            Microsoft.Msagl.Drawing.Graph graph)
        {
            for (int i = 0; i < route.Count; i++)
            {
                // change shape
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(route.ElementAt(i));
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Crimson;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }

        public void drawGraph(string[] result,
            System.Windows.Forms.Form form,
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer,
            Microsoft.Msagl.Drawing.Graph graph)
        {
            List<string> list = new List<string>(result);
            var n = list.Count;


            for (int i = 0; i < n; i += 2)
            {
                var Edge = graph.AddEdge(list.ElementAt(i), list.ElementAt(i + 1));

                // undirect graph
                Edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                Edge.Attr.ArrowheadAtSource = ArrowStyle.None;

                // change shape
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(list.ElementAt(i));
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.AntiqueWhite;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

                Microsoft.Msagl.Drawing.Node c1 = graph.FindNode(list.ElementAt(i + 1));
                c1.Attr.FillColor = Microsoft.Msagl.Drawing.Color.AntiqueWhite;
                c1.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }
    }
}
