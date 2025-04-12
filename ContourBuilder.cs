using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GM3
{
    public class ContourBuilder
    {
        public  List<Point> defaultContour = new List<Point>();
        private List<Point> afterAnimationContour = new List<Point>();
        internal void ContourPointsFill()
        {
            defaultContour.Add(new Point(374.5, 78.5));
            defaultContour.Add(new Point(372, 100));
            defaultContour.Add(new Point(360, 123));
            defaultContour.Add(new Point(350, 130));

            defaultContour.Add(new Point(350, 130));
            defaultContour.Add(new Point(347, 130));
            defaultContour.Add(new Point(336, 150));
            defaultContour.Add(new Point(338, 160));

            defaultContour.Add(new Point(338, 160));
            defaultContour.Add(new Point(340, 240));
            defaultContour.Add(new Point(304, 300));
            defaultContour.Add(new Point(270, 320));

            defaultContour.Add(new Point(270, 320));
            defaultContour.Add(new Point(250, 330));
            defaultContour.Add(new Point(242, 356));
            defaultContour.Add(new Point(248.5, 378.5));

            //

            defaultContour.Add(new Point(374.5, 78.5));
            defaultContour.Add(new Point(369, 93));
            defaultContour.Add(new Point(357, 120));
            defaultContour.Add(new Point(347, 127));

            defaultContour.Add(new Point(347, 127));
            defaultContour.Add(new Point(344, 127));
            defaultContour.Add(new Point(333, 147));
            defaultContour.Add(new Point(335, 157));

            defaultContour.Add(new Point(335, 157));
            defaultContour.Add(new Point(337, 237));
            defaultContour.Add(new Point(301, 297));
            defaultContour.Add(new Point(267, 317));

            defaultContour.Add(new Point(267, 317));
            defaultContour.Add(new Point(247, 327));
            defaultContour.Add(new Point(239, 353));
            defaultContour.Add(new Point(248.5, 378.5));

            //

            defaultContour.Add(new Point(237, 334.5));
            defaultContour.Add(new Point(230, 346));
            defaultContour.Add(new Point(210, 350));
            defaultContour.Add(new Point(200.5, 342.5));

            defaultContour.Add(new Point(237, 334.5));
            defaultContour.Add(new Point(227, 343));
            defaultContour.Add(new Point(207, 347));
            defaultContour.Add(new Point(200.5, 342.5));

            //

            defaultContour.Add(new Point(264, 396));
            defaultContour.Add(new Point(244, 400));
            defaultContour.Add(new Point(227, 392));
            defaultContour.Add(new Point(221, 382));

            defaultContour.Add(new Point(221, 382));
            defaultContour.Add(new Point(210, 363));
            defaultContour.Add(new Point(190, 347));
            defaultContour.Add(new Point(185, 350));

            defaultContour.Add(new Point(264, 396));
            defaultContour.Add(new Point(244, 395));
            defaultContour.Add(new Point(227, 387));
            defaultContour.Add(new Point(221, 377));

            defaultContour.Add(new Point(221, 377));
            defaultContour.Add(new Point(210, 358));
            defaultContour.Add(new Point(190, 342));
            defaultContour.Add(new Point(185, 350));

            //

            defaultContour.Add(new Point(182, 350));
            defaultContour.Add(new Point(140, 360));
            defaultContour.Add(new Point(65, 300));
            defaultContour.Add(new Point(60, 260));

            defaultContour.Add(new Point(60, 260));
            defaultContour.Add(new Point(57, 226));
            defaultContour.Add(new Point(43, 196));
            defaultContour.Add(new Point(30, 190));

            defaultContour.Add(new Point(30, 190));
            defaultContour.Add(new Point(26, 191));
            defaultContour.Add(new Point(24, 187));
            defaultContour.Add(new Point(25, 185));

            defaultContour.Add(new Point(182, 350));
            defaultContour.Add(new Point(143, 355));
            defaultContour.Add(new Point(68, 295));
            defaultContour.Add(new Point(62, 255));

            defaultContour.Add(new Point(62, 255));
            defaultContour.Add(new Point(60, 221));
            defaultContour.Add(new Point(46, 191));
            defaultContour.Add(new Point(32, 187));

            defaultContour.Add(new Point(32, 187));
            defaultContour.Add(new Point(26, 188));
            defaultContour.Add(new Point(24, 184));
            defaultContour.Add(new Point(25, 185));


            //
            defaultContour.Add(new Point(24, 178));
            defaultContour.Add(new Point(39, 183));
            defaultContour.Add(new Point(54, 188));
            defaultContour.Add(new Point(59, 203));

            defaultContour.Add(new Point(24, 178));
            defaultContour.Add(new Point(39, 178));
            defaultContour.Add(new Point(54, 183));
            defaultContour.Add(new Point(59, 203));

            //

            defaultContour.Add(new Point(30, 171));
            defaultContour.Add(new Point(50, 176));
            defaultContour.Add(new Point(62, 181));
            defaultContour.Add(new Point(65, 188));

            defaultContour.Add(new Point(65, 188));
            defaultContour.Add(new Point(70, 192));
            defaultContour.Add(new Point(88, 205));
            defaultContour.Add(new Point(96, 202));

            defaultContour.Add(new Point(96, 202));
            defaultContour.Add(new Point(110, 200));
            defaultContour.Add(new Point(112, 201));
            defaultContour.Add(new Point(116, 203));

            defaultContour.Add(new Point(30, 171));
            defaultContour.Add(new Point(50, 172));
            defaultContour.Add(new Point(62, 177));
            defaultContour.Add(new Point(65, 182));

            defaultContour.Add(new Point(65, 182));
            defaultContour.Add(new Point(70, 188));
            defaultContour.Add(new Point(88, 201));
            defaultContour.Add(new Point(96, 198));

            defaultContour.Add(new Point(96, 198));
            defaultContour.Add(new Point(108, 196));
            defaultContour.Add(new Point(112, 197));
            defaultContour.Add(new Point(116, 203));

            //

            defaultContour.Add(new Point(130, 210));
            defaultContour.Add(new Point(158, 200));
            defaultContour.Add(new Point(178, 195));
            defaultContour.Add(new Point(198, 212));

            defaultContour.Add(new Point(198, 212));
            defaultContour.Add(new Point(195, 212));
            defaultContour.Add(new Point(177, 222));
            defaultContour.Add(new Point(165, 237));

            defaultContour.Add(new Point(165, 237));
            defaultContour.Add(new Point(158, 244));
            defaultContour.Add(new Point(142, 249));
            defaultContour.Add(new Point(136, 228));

            defaultContour.Add(new Point(130, 210));
            defaultContour.Add(new Point(158, 196));
            defaultContour.Add(new Point(178, 191));
            defaultContour.Add(new Point(202, 212));

            defaultContour.Add(new Point(202, 212));
            defaultContour.Add(new Point(195, 216));
            defaultContour.Add(new Point(177, 226));
            defaultContour.Add(new Point(165, 241));

            defaultContour.Add(new Point(165, 241));
            defaultContour.Add(new Point(158, 248));
            defaultContour.Add(new Point(142, 253));
            defaultContour.Add(new Point(136, 228));

            //

            defaultContour.Add(new Point(190, 230));
            defaultContour.Add(new Point(230, 230));
            defaultContour.Add(new Point(303, 185));
            defaultContour.Add(new Point(306, 165));

            defaultContour.Add(new Point(306, 165));
            defaultContour.Add(new Point(310, 150));
            defaultContour.Add(new Point(306, 140));
            defaultContour.Add(new Point(290, 130));

            defaultContour.Add(new Point(290, 130));
            defaultContour.Add(new Point(260, 105));
            defaultContour.Add(new Point(268, 95));
            defaultContour.Add(new Point(266, 80));

            defaultContour.Add(new Point(266, 80));
            defaultContour.Add(new Point(269, 95));
            defaultContour.Add(new Point(278, 100));
            defaultContour.Add(new Point(286, 99));

            defaultContour.Add(new Point(286, 99));
            defaultContour.Add(new Point(308, 97));
            defaultContour.Add(new Point(313, 99));
            defaultContour.Add(new Point(318, 109));

            defaultContour.Add(new Point(318, 109));
            defaultContour.Add(new Point(323, 99));
            defaultContour.Add(new Point(328, 97));
            defaultContour.Add(new Point(346, 99));

            defaultContour.Add(new Point(346, 99));
            defaultContour.Add(new Point(352, 100));
            defaultContour.Add(new Point(360, 95));
            defaultContour.Add(new Point(366, 80));

            ////
            defaultContour.Add(new Point(190, 230));
            defaultContour.Add(new Point(230, 226));
            defaultContour.Add(new Point(303, 181));
            defaultContour.Add(new Point(306, 161));

            defaultContour.Add(new Point(306, 161));
            defaultContour.Add(new Point(310, 146));
            defaultContour.Add(new Point(306, 136));
            defaultContour.Add(new Point(290, 126));

            defaultContour.Add(new Point(290, 126));
            defaultContour.Add(new Point(260, 101));
            defaultContour.Add(new Point(268, 91));
            defaultContour.Add(new Point(266, 76));

            defaultContour.Add(new Point(266, 76));
            defaultContour.Add(new Point(269, 91));
            defaultContour.Add(new Point(278, 96));
            defaultContour.Add(new Point(286, 95));

            defaultContour.Add(new Point(286, 95));
            defaultContour.Add(new Point(308, 94));
            defaultContour.Add(new Point(313, 95));
            defaultContour.Add(new Point(318, 109));

            defaultContour.Add(new Point(318, 105));
            defaultContour.Add(new Point(323, 95));
            defaultContour.Add(new Point(328, 93));
            defaultContour.Add(new Point(346, 95));

            defaultContour.Add(new Point(346, 95));
            defaultContour.Add(new Point(352, 96));
            defaultContour.Add(new Point(360, 91));
            defaultContour.Add(new Point(366, 80));

            //

            defaultContour.Add(new Point(75, 230));
            defaultContour.Add(new Point(81, 227));
            defaultContour.Add(new Point(85, 230));
            defaultContour.Add(new Point(83, 233));

            defaultContour.Add(new Point(83, 233));
            defaultContour.Add(new Point(80, 245));
            defaultContour.Add(new Point(73, 240));
            defaultContour.Add(new Point(75, 230));

            defaultContour.Add(new Point(76, 233));
            defaultContour.Add(new Point(79, 237));
            defaultContour.Add(new Point(77, 235));
            defaultContour.Add(new Point(76, 233));
        }
        internal void SecondContourPointsFill()
        {
            int x0 = 80;
            int y0 = 80;
            
          for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 68; j++)
                {

                    if (i == 0)
                    {
                        afterAnimationContour.Add(new Point(x0 + j * 5, y0 + j * 5));
                        if (j % 4 == 0 && j > 0)
                            afterAnimationContour[j] = afterAnimationContour[j - 1];
                    }
                    if (i == 1)
                    {
                        afterAnimationContour.Add(new Point(x0 + 67 * 5, y0 + 67 * 5 - j * 5));

                        if (j % 4 == 0)
                            afterAnimationContour[68+j] = afterAnimationContour[68+j - 1];
                    }
                    if(i == 2)
                    {
                        afterAnimationContour.Add(new Point(x0 + 67 * 5 - j * 5, y0));
                        if (j % 4 == 0)
                            afterAnimationContour[136+j] = afterAnimationContour[136+j - 1];
                    }
                    
                   
                }
            }
         
        }

        public void BezierOrder3(Canvas drawingSheet, BrushConverter brushConverter, bool drawCharactLines)
        {

            if (drawingSheet.Children.Count != 0)
                drawingSheet.Children.Clear();


            for (int j = 0; j < defaultContour.Count; j += 4)
            {
                int lineId = j / 4;

                Path path = new Path
                {
                    Stroke = (Brush)brushConverter.ConvertFrom("#5E35B1"),
                    StrokeThickness = 2,
                    Tag = lineId
                };

                PathGeometry geometry = new PathGeometry();
                PathFigure figure = new PathFigure
                {
                    StartPoint = new Point(defaultContour[j].X, defaultContour[j].Y)
                };



                PolyLineSegment bezierCurve = new PolyLineSegment();


                Point p0 = defaultContour[j];
                Point p1 = defaultContour[j + 1];
                Point p2 = defaultContour[j + 2];
                Point p3 = defaultContour[j + 3];

                double step = 0.01;
                for (double t = 0; t <= 1; t += step)
                {
                    // Обчислення координат точки на кривій Безьє за формулою
                    double x = Math.Pow(1 - t, 3) * p0.X +
                               3 * Math.Pow(1 - t, 2) * t * p1.X +
                               3 * (1 - t) * Math.Pow(t, 2) * p2.X +
                               Math.Pow(t, 3) * p3.X;

                    double y = Math.Pow(1 - t, 3) * p0.Y +
                               3 * Math.Pow(1 - t, 2) * t * p1.Y +
                               3 * (1 - t) * Math.Pow(t, 2) * p2.Y +
                               Math.Pow(t, 3) * p3.Y;


                    bezierCurve.Points.Add(new Point(x, y));
                }


                bezierCurve.Points.Add(new Point(defaultContour[j + 3].X, defaultContour[j + 3].Y));
                figure.Segments.Add(bezierCurve);
                geometry.Figures.Add(figure);
                path.Data = geometry;
                drawingSheet.Children.Add(path);


                if (drawCharactLines)
                {
                    DrawControlPointsAndLines(drawingSheet, brushConverter, j, lineId);
                }
            }
        }

        private void DrawControlPointsAndLines(Canvas drawingSheet,BrushConverter brushConverter,int startIndex, int lineId)
        {
            for (int i = 0; i < 4; i++)
            {
                Brush color = (i == 1 || i == 2) ? (Brush)brushConverter.ConvertFrom("#E36386") : (Brush)brushConverter.ConvertFrom("#A7DBF0");
                Pointer(drawingSheet,defaultContour[startIndex + i], color, lineId);
            }

            for (int i = 0; i < 3; i++)
            {
                Liner(drawingSheet,defaultContour[startIndex + i],defaultContour[startIndex + i + 1], (Brush)brushConverter.ConvertFrom("#F2AAAB"), lineId);
            }
        }

        private void Pointer(Canvas drawingSheet, Point point, Brush color, int lineId)
        {
            Rectangle rectangle = new Rectangle
            {
                Fill = color,
                Width = 6,
                Height = 6,
                Tag = lineId
            };

            Canvas.SetLeft(rectangle, point.X - 3);
            Canvas.SetTop(rectangle, point.Y - 3);
            drawingSheet.Children.Add(rectangle);
        }

        private void Liner(Canvas drawingSheet, Point start, Point end, Brush color, int lineId)
        {
            Line line = new Line
            {
                X1 = start.X,
                Y1 = start.Y,
                X2 = end.X,
                Y2 = end.Y,
                Stroke = color,
                StrokeThickness = 1,
                Tag = lineId
            };
            drawingSheet.Children.Add(line);
        }
        private void UpdateLine(Path path, int index)
        {

            PathGeometry geometry = new PathGeometry();
            PathFigure figure = new PathFigure
            {
                StartPoint = defaultContour[index]
            };


            PolyLineSegment polyLineSegment = new PolyLineSegment();
            Point p0 = defaultContour[index];
            Point p1 = defaultContour[index + 1];
            Point p2 = defaultContour[index + 2];
            Point p3 = defaultContour[index + 3];

            double step = 0.01;
            for (double t = 0; t <= 1; t += step)
            {
                // Обчислення координат точки на кривій Безьє за формулою
                double x = Math.Pow(1 - t, 3) * p0.X +
                           3 * Math.Pow(1 - t, 2) * t * p1.X +
                           3 * (1 - t) * Math.Pow(t, 2) * p2.X +
                           Math.Pow(t, 3) * p3.X;

                double y = Math.Pow(1 - t, 3) * p0.Y +
                           3 * Math.Pow(1 - t, 2) * t * p1.Y +
                           3 * (1 - t) * Math.Pow(t, 2) * p2.Y +
                           Math.Pow(t, 3) * p3.Y;


                polyLineSegment.Points.Add(new Point(x, y));
            }


            figure.Segments.Add(polyLineSegment);
            geometry.Figures.Add(figure);

            path.Data = geometry;
        }

        public void RedrawDeformedLines(Canvas drawingSheet, BrushConverter brushConverter, List<Rectangle> trasitedPoints)
        {
            var indices = trasitedPoints
                .Select(point => drawingSheet.Children.OfType<Rectangle>().ToList().IndexOf(point) / 4 * 4)
                .Distinct();

            foreach (var lineStartId in indices)
            {
                if (lineStartId < 0 || lineStartId + 3 >= defaultContour.Count) continue;

                Path deformedLine = drawingSheet.Children.OfType<Path>().ElementAt(lineStartId / 4);

                UpdateLine(deformedLine, lineStartId);
                RedrawCharacteristicLines(drawingSheet, brushConverter, lineStartId);

            }
        }

        private void RedrawCharacteristicLines(Canvas drawingSheet, BrushConverter brushConverter, int lineStartId)
        {
            var linesToRemove = drawingSheet.Children.OfType<Line>()
                .Where(line => line.Tag != null && (int)line.Tag == lineStartId / 4)
                .ToList();

            foreach (var line in linesToRemove)
            {
                drawingSheet.Children.Remove(line);
            }

            if (lineStartId + 3 >= defaultContour.Count) return;

            for (int i = 0; i < 3; i++)
            {
                Liner(drawingSheet,
                   defaultContour[lineStartId + i],
                    defaultContour[lineStartId + i + 1],
                    (Brush)brushConverter.ConvertFrom("#F2AAAB"),
                    lineStartId / 4
                );
            }
        }

        public void Move(Canvas drawingSheet, BrushConverter brushConverter, bool displayLines, double x, double y)
        {
           
            for (int i = 0; i < defaultContour.Count; i++)
            {
                defaultContour[i] = new Point(
                   defaultContour[i].X + x,
                    defaultContour[i].Y + y
                );
            }
            BezierOrder3(drawingSheet,  brushConverter,  displayLines);
        }
        public void Rotate(Canvas drawingSheet, BrushConverter brushConverter, bool displayLines, double x, double y, double alpha)
        {
            alpha = alpha * Math.PI / 180;

            for (int i = 0; i < defaultContour.Count; i++)
            {
                defaultContour[i] = new Point(
                    (defaultContour[i].X - x) * Math.Cos(alpha) - Math.Sin(alpha) * (defaultContour[i].Y - y) + x,
                    (defaultContour[i].X - x) * Math.Sin(alpha) + Math.Cos(alpha) * (defaultContour[i].Y - y) + y
                );
            }
            BezierOrder3(drawingSheet, brushConverter, displayLines);
        }

        public void Animation(Canvas drawingSheet, BrushConverter brush, bool displayLines)
        {
          

            var dT = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(16) };
            double t = 0, d = 2.0;

            dT.Tick += (_, __) =>
            {
                double p = Math.Min((t += 0.016) / d, 1);

                for (int i = 0; i < defaultContour.Count; i++)
                    defaultContour[i] = Point.Add(defaultContour[i],
                        new Vector(afterAnimationContour[i].X - defaultContour[i].X,
                                   afterAnimationContour[i].Y - defaultContour[i].Y) * p);

                drawingSheet.Children.Clear();
                BezierOrder3(drawingSheet, brush, displayLines);

                if (p >= 0.5) dT.Stop();
            };

            dT.Start();
        }
    }
}
