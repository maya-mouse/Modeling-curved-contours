
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GM3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool displayControlPointsAndLines = false;
        private Rectangle activeControlPoint;
        private Point activeControlPointData;
        private bool isMovingPoint = false;
        private Point initialMousePosition;
        private ContourBuilder contourManager = new ContourBuilder();
        BrushConverter colorConverter = new BrushConverter();

        public MainWindow()
        {
            InitializeComponent();
            contourManager.ContourPointsFill();
            contourManager.SecondContourPointsFill();
       
        }

        private void CanvasLoaded(object sender, RoutedEventArgs e)
            => contourManager.BezierOrder3(drawingSheet, colorConverter, displayControlPointsAndLines);

        private void CheckboxValueChanged(object sender, RoutedEventArgs e)
        {
            displayControlPointsAndLines = !displayControlPointsAndLines;
            contourManager.BezierOrder3(drawingSheet, colorConverter, displayControlPointsAndLines);
        }

        private bool WhereIsMyMouse(Point mousePosition, Rectangle controlPoint)
        {
            double controlPointLeft = Canvas.GetLeft(controlPoint) - 3;
            double controlPointRight = controlPointLeft + controlPoint.Width + 3;
            double controlPointTop = Canvas.GetTop(controlPoint) - 3;
            double controlPointBottom = controlPointTop + controlPoint.Height + 3;

            return mousePosition.X > controlPointLeft && mousePosition.X < controlPointRight &&
                   mousePosition.Y > controlPointTop && mousePosition.Y < controlPointBottom;
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(drawingSheet);
            foreach (UIElement element in drawingSheet.Children)
            {
                if (element is Rectangle controlPoint && WhereIsMyMouse(mousePosition, controlPoint))
                {
                    activeControlPoint = controlPoint;
                    activeControlPointData = new Point(Canvas.GetLeft(controlPoint), Canvas.GetTop(controlPoint));
                    initialMousePosition = mousePosition;
                    isMovingPoint = true;
                    controlPoint.CaptureMouse();
                    return;
                }
            }
        }

        private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!isMovingPoint) return;

            isMovingPoint = false;
            if (activeControlPoint != null)
            {
                activeControlPoint.ReleaseMouseCapture();
                activeControlPoint = null;
                activeControlPointData = new Point();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
           if (!isMovingPoint || activeControlPoint == null) return;

            Point mousePosition = e.GetPosition(drawingSheet);

            double dx = mousePosition.X - initialMousePosition.X;
            double dy = mousePosition.Y - initialMousePosition.Y;

            Point currentControlPointData = new Point(
                Canvas.GetLeft(activeControlPoint),
                Canvas.GetTop(activeControlPoint)
            );

            var relatedControlPoints = drawingSheet.Children.OfType<Rectangle>()
                .Where(cp =>
                    Math.Abs(Canvas.GetLeft(cp) - currentControlPointData.X) < 0.001 &&
                    Math.Abs(Canvas.GetTop(cp) - currentControlPointData.Y) < 0.001)
                .ToList();

            foreach (var point in relatedControlPoints)
            {
                Canvas.SetLeft(point, Canvas.GetLeft(point) + dx);
                Canvas.SetTop(point, Canvas.GetTop(point) + dy);

                int index = drawingSheet.Children.OfType<Rectangle>().ToList().IndexOf(point);
                if (index >= 0 && index < contourManager.defaultContour.Count)
                {
                    contourManager.defaultContour[index] = new Point(
                        Canvas.GetLeft(point),
                        Canvas.GetTop(point)
                    );

                 
                }
            }

            initialMousePosition = mousePosition;
         
            contourManager.RedrawDeformedLines(drawingSheet, colorConverter, relatedControlPoints);

        }
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(XInput.Text, out double x);
            double.TryParse(YInput.Text, out double y);

            contourManager.Move(drawingSheet, colorConverter, displayControlPointsAndLines, x, y);
        }

        private void Rotate_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(XInput.Text, out double x);
            double.TryParse(YInput.Text, out double y);
            double.TryParse(RotationAngleInput.Text, out double a);
            contourManager.Rotate(drawingSheet, colorConverter, displayControlPointsAndLines, x, y, a);
        }

        private void Animation_Click(object sender, RoutedEventArgs e)
        {   
            contourManager.Animation(drawingSheet, colorConverter, displayControlPointsAndLines);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            contourManager.defaultContour.Clear();
            contourManager.ContourPointsFill();
            contourManager.BezierOrder3(drawingSheet, colorConverter, displayControlPointsAndLines);
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}