using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace PaintSourceWPF
{
    
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool Brush = true;                      //Uses either Brush or Eraser. Default is Brush
        private Shapes DrawingShapes = new Shapes();    //Stores all the drawing data
        private bool IsPainting = false;                //Is the mouse currently down (PAINTING)
        private bool IsEraseing = false;                 //Is the mouse currently down (ERASEING)
        private Point LastPos = new Point(0, 0);        //Last Position, used to cut down on repative data.
        private Color CurrentColour = Color.FromRgb(100, 100, 100);      //Deafult Colour
        private float CurrentWidth = 2;                 //Deafult Pen width
        private int ShapeNum = 0;                       //record the shapes so they can be drawn sepratley.
        private Point MouseLoc = new Point(0, 0);       //Record the mouse position
        private bool IsMouseing = false;                //Draw the mouse?
        private Brush sfondo;
        private Ellipse ell;

        public MainWindow()
        {
            InitializeComponent();
            Spessore.Text = CurrentWidth.ToString();
            sfondo = paintSurface.Background;
        }
        private void Canvas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("mouse down");
            //If we're painting...
            if (Brush)
            {
                //set it to mouse down, illatrate the shape being drawn and reset the last position
                IsPainting = true;
                ShapeNum++;
                LastPos = new Point(0,0);
            }
            //but if we're eraseing...
            else
            {
                IsEraseing = true;
            }
        }

        private void Canvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MouseLoc.X = e.GetPosition(paintSurface).X;
            MouseLoc.Y = e.GetPosition(paintSurface).Y;

                //PAINTING
            if (IsPainting)
            {
                //check its not at the same place it was last time, saves on recording more data.
                if (LastPos != MouseLoc )
                {
                    if(LastPos.X != 0 && LastPos.Y != 0)
                        Disegna(MouseLoc);
                    //set this position as the last positon
                    LastPos = MouseLoc;
                    //store the position, width, colour and shape relation data
                    DrawingShapes.NewShape(LastPos, CurrentWidth, CurrentColour, ShapeNum);
                }
            }
            if (IsEraseing)
            {
                //Remove any point within a certain distance of the mouse
                List<Shape> lineeDaCancellare =   DrawingShapes.RemoveShape(MouseLoc, 5);
                Cancella(lineeDaCancellare);
            }
            //If mouse is on the panel, draw the mouse
            if (IsMouseing)
            {
                Canvas.SetTop(ell, e.GetPosition(paintSurface).Y - CurrentWidth / 2 +1);
                Canvas.SetLeft(ell, e.GetPosition(paintSurface).X - CurrentWidth / 2 +1);
            }

        }

        private void Cancella(List<Shape> lineeDaCancellare)
        {
            for (int i = 0; i < lineeDaCancellare.Count; i += 2)
                for (int j = 0; j < paintSurface.Children.Count; j++)
                {
                    UIElement elem = paintSurface.Children[j];
                    if (lineeDaCancellare[i].Location.X == (elem as Line).X1 &&
                        lineeDaCancellare[i].Location.Y == (elem as Line).Y1 &&
                        lineeDaCancellare[i + 1].Location.X == (elem as Line).X2 &&
                        lineeDaCancellare[i + 1].Location.Y == (elem as Line).Y2)
                    {
                        paintSurface.Children.RemoveAt(j);
                        break;
                    }
                }
        }

        private void Disegna(Point mouseLoc)
        {
            if (IsPainting)
            {
                if (LastPos != MouseLoc)
                {
                    Line line = new Line();
                    line.StrokeThickness = CurrentWidth;
                    line.Stroke = new SolidColorBrush(CurrentColour);
                    line.StrokeEndLineCap = PenLineCap.Round;
                    line.StrokeStartLineCap = PenLineCap.Round;
                    line.X1 = LastPos.X;
                    line.Y1 = LastPos.Y;
                    line.X2 = MouseLoc.X;
                    line.Y2 = MouseLoc.Y;
                    paintSurface.Children.Add(line);
                }
            }
        }

        private void Canvas_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (IsPainting)
            {
                //Finished Painting.
                IsPainting = false;
            }
            if (IsEraseing)
            {
                //Finished Earsing.
                IsEraseing = false;
            }
        }

        //DRAWING FUNCTION
        private void Paint()
        {
            //DRAW THE LINES
            for (int i = 0; i < DrawingShapes.NumberOfShapes() - 1; i++)
            {
                Shape T = DrawingShapes.GetShape(i);
                Shape T1 = DrawingShapes.GetShape(i + 1);
                //make sure shape the two ajoining shape numbers are part of the same shape
                if (T.ShapeNumber == T1.ShapeNumber)
                {
                    Line line = new Line();
                    line.StrokeThickness = T.Width;
                    line.Stroke = new SolidColorBrush(T.Colour);
                    line.StrokeEndLineCap = PenLineCap.Round;
                    line.StrokeStartLineCap = PenLineCap.Round;
                    line.X1 = T.Location.X;
                    line.Y1 = T.Location.Y;
                    line.X2 = T1.Location.X;
                    line.Y2 = T1.Location.Y;
                    paintSurface.Children.Add(line);
                }
            }
        }
        private void Operazione_Click(object sender, RoutedEventArgs e)
        {
            //Go from the BRUSH to the ERASER
            Brush = !Brush;
        }

        private void Colore_Click(object sender, RoutedEventArgs e)
        {
            FinestraColore fc = new FinestraColore();
            bool? result=fc.ShowDialog();
            //True: l'utente seleziona un file e clicca OK
            if (result == true)
            {
                CurrentColour = fc.GetColore();
            }
            else
            {
                //l'utente ha annullato
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            //Reset the list, removeing all shapes.
            DrawingShapes = new Shapes();
            paintSurface.Children.Clear();
        }

        private void Spessore_LostFocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Spessore_LostFocu");
            int dim;
            try
            {
                dim = Convert.ToInt32(Spessore.Text);
                if (dim > 0 && dim < 41)
                    CurrentWidth = dim;
            }
            catch { MessageBox.Show("Errore"); }
        }

        private void Spessore_MouseLeave(object sender, MouseEventArgs e)
        {
            Spessore_LostFocus(null, null);
        }

        private void Apri_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".sha"; // Default file extension
            dlg.Filter = "Shape documents (.sha)|*.sha"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                SerializzatoreBINARY serBin = new SerializzatoreBINARY(filename, DrawingShapes);
                Clear_Click(null,null);
                DrawingShapes = (Shapes)serBin.DeSerializza();
                Paint();
            }
        }

        private void Salva_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".sha"; // Default file extension
            dlg.Filter = "Shape documents (.sha)|*.sha"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                SerializzatoreBINARY serBin = new SerializzatoreBINARY(filename, DrawingShapes);
                serBin.Serializza();
            }
        }

        private void paintSurface_MouseEnter(object sender, MouseEventArgs e)
        {
            //Hide the mouse cursor and tell the re-drawing function to draw the mouse
            paintSurface.Cursor = Cursors.None;
            IsMouseing = true;

            ell = new Ellipse();
            ell.Width = CurrentWidth;
            ell.Height = CurrentWidth;
            ell.Stroke = new SolidColorBrush(Color.FromRgb(10, 10, 10));
            Canvas.SetTop(ell, e.GetPosition(paintSurface).Y - CurrentWidth / 2 + 1);
            Canvas.SetLeft(ell, e.GetPosition(paintSurface).X - CurrentWidth / 2 + 1);
            paintSurface.Children.Add(ell);
        }

        private void paintSurface_MouseLeave(object sender, MouseEventArgs e)
        {
            //show the mouse, tell the re-drawing function to stop drawing it and force the panel to re-draw.
            paintSurface.Cursor = Cursors.Arrow;
            IsMouseing = false;
            paintSurface.Children.Remove(ell);
            ell = null;
        }
    }


    public class SerializzatoreBINARY 
    {
        string nomeFile;
        object tipoDato;

        public SerializzatoreBINARY(string nome, object tDato)
        {
            nomeFile = nome;
            tipoDato = tDato;
        }
        public void Serializza()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nomeFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tipoDato);
            stream.Close();
        }

        public object DeSerializza()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nomeFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            tipoDato = formatter.Deserialize(stream);
            stream.Close();
            return tipoDato;
        }
    }


    [Serializable()]
    public class Shape : ISerializable
    {
        public Point Location;          //position of the point
        public float Width;             //width of the line
        public Color Colour;            //colour of the line
        public int ShapeNumber;         //part of which shape it belongs to

        //CONSTRUCTOR
        public Shape(Point L, float W, Color C, int S)
        {
            Location = L;               //Stores the Location
            Width = W;                  //Stores the width
            Colour = C;                 //Stores the colour
            ShapeNumber = S;            //Stores the shape number
        }
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Loc", Location, typeof(Point));
            info.AddValue("Wit", Width, typeof(float));
            info.AddValue("Num", ShapeNumber, typeof(int));
            info.AddValue("A", Colour.A, typeof(byte));
            info.AddValue("R", Colour.R, typeof(byte));
            info.AddValue("G", Colour.G, typeof(byte));
            info.AddValue("B", Colour.B, typeof(byte));
        }

        // The special constructor is used to deserialize values.
        public Shape(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            Location = (Point)info.GetValue("Loc", typeof(Point));
            Width = (float)info.GetValue("Wit", typeof(float));
            ShapeNumber = (int)info.GetValue("Num", typeof(int));
            byte A = (byte)info.GetValue("A", typeof(byte));
            byte R = (byte)info.GetValue("R", typeof(byte));
            byte G = (byte)info.GetValue("G", typeof(byte));
            byte B = (byte)info.GetValue("B", typeof(byte));
            Colour = Color.FromArgb(A, R, G, B);
        }
    }

    [Serializable()]
    public class Shapes
    {
        private List<Shape> _Shapes;    //Stores all the shapes

        public Shapes()
        {
            _Shapes = new List<Shape>();
        }
        //Returns the number of shapes being stored.
        public int NumberOfShapes()
        {
            return _Shapes.Count;
        }
        //Add a shape to the database, recording its position, width, colour and shape relation information
        public void NewShape(Point L, float W, Color C, int S)
        {
            _Shapes.Add(new Shape(L, W, C, S));
        }
        //returns a shape of the requested data.
        public Shape GetShape(int Index)
        {
            return _Shapes[Index];
        }
        //Removes any point data within a certain threshold of a point.
        public List<Shape> RemoveShape(Point L, float threshold)
        {
            List<Shape> CoppieShape= new List<Shape>();
            for (int i = 0; i < _Shapes.Count; i++)
            {
                //Finds if a point is within a certain distance of the point to remove.
                if ((Math.Abs(L.X - _Shapes[i].Location.X) < threshold) && (Math.Abs(L.Y - _Shapes[i].Location.Y) < threshold))
                {
                    if (i != 0 && _Shapes[i - 1].ShapeNumber == _Shapes[i].ShapeNumber)
                    {
                        CoppieShape.Add(_Shapes[i - 1]);
                        CoppieShape.Add(_Shapes[i]);
                    }
                    if (i < _Shapes.Count-1 && _Shapes[i].ShapeNumber == _Shapes[i+1].ShapeNumber)
                    {
                        CoppieShape.Add(_Shapes[i]);
                        CoppieShape.Add(_Shapes[i+1]);
                    }
                    //removes all data for that number
                    _Shapes.RemoveAt(i);

                    //goes through the rest of the data and adds an extra 1 to defined them as a seprate shape and shuffles on the effect.
                    for (int n = i; n < _Shapes.Count; n++)
                    {
                        _Shapes[n].ShapeNumber += 1;
                    }
                    //Go back a step so we dont miss a point.
                    i -= 1;
                }
            }
            return CoppieShape;
        }
    }

}
