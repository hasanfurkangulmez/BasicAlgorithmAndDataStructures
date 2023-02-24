using System;

namespace BasicAlgorithmAndDataStructures.BasicMatrixApps
{
    internal class Matrix
    {

        public Matrix()
        {
            int[,] X = BottomTriangleMatrix(3);
            //Print(Create());
            //Print(OnesMatrixCreate(3, 3));
            //Print(DiagonalMatrixCreate());
            //Print(ScalarMatrixCreate());
            //Print(Create(4, 4, 4, 8));
            //Console.WriteLine(IsSquareMatrix(Create(4, 4, 4, 8)));
            //Print(DiagonalMatrixCreate(4, 1, 1));
            //Console.WriteLine(IsUnitMatrix(DiagonalMatrixCreate(4, 1, 1)));
            //var X = DiagonalMatrixCreate(5);
            //Print(X);
            //Print(ListOfDiagonalElements(X));
            //var X = Create(3, 3);
            //Print(X);
            //Print(ListOfDiagonalElements(X));
            //System.Console.WriteLine(TraceOfMatrix(X));
            //Print(X);
            //int[,] T = Transpoz(X);
            //Print(T);
            //Print(X);
            //Print(ReShape(X, 2, 9));
            //int[,] Y = ZeroMatrixCreate(4, 4);
            //Print(X);
            //Print(Y);
            //if (IsEqualTo(X, Y)) Console.WriteLine("Marices Are Equal.");
            //else PrintError("Matrices Aren't Equal!");
            Print(X);
            Console.WriteLine(IsItBottomTriangleMatrix(X));
        }
        /// <summary>
        /// Create matrix
        /// </summary>
        /// <param name="Row">Row Piece</param>
        /// <param name="Col">Col Piece</param>
        /// <param name="MinValue">Minimum Value</param>
        /// <param name="MaxValue">Maximum Value</param>
        /// <returns>Matrix of X</returns>
        public static int[,] Create(int Row = 3, int Col = 3, int MinValue = 1, int MaxValue = 9)
        {
            int[,] X = new int[Row, Col];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    X[i, j] = new Random().Next(MinValue, MaxValue);
            return X;
        }
        /// <summary>
        /// It writes the matrix it receives as a parameter to the screen.
        /// </summary>
        /// <param name="X">Matrix Input</param>
        public static void Print(int[,] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                    Console.Write("{0,5}", X[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Print(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,5}", X[i]);
            Console.WriteLine();
        }
        public static void PrintError(string Message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\a\n{Message}\n\a");
            Console.ResetColor();
        }
        /// <summary>
        /// Create Zero Matrix
        /// </summary>
        /// <param name="Row">Row Piece</param>
        /// <param name="Col">Col Piece</param>
        /// <returns>Zero Matrix of X</returns>
        public static int[,] ZeroMatrixCreate(int Row, int Col)
        {
            return Create(Row, Col, 0, 0);
        }
        /// <summary>
        /// Create Ones Matrix
        /// </summary>
        /// <param name="Row">Row Piece</param>
        /// <param name="Col">Col Piece</param>
        /// <returns>Ones Matrix of X</returns>
        public static int[,] OnesMatrixCreate(int Row, int Col)
        {
            return Create(Row, Col, 1, 1);
        }
        /// <summary>
        /// Diagonal Ones Matrix
        /// </summary>
        /// <param name="Dimensional">Dimensional</param>
        /// <param name="MinValue">Minumum Value</param>
        /// <param name="MaxValue">Maximum Value</param>
        /// <returns>Diagonal Matrix of X</returns>
        public static int[,] DiagonalMatrixCreate(int Dimensional = 3, int MinValue = 1, int MaxValue = 9)
        {
            int[,] X = ZeroMatrixCreate(Dimensional, Dimensional);
            for (int i = 0; i < X.GetLength(0); i++)
                X[i, i] = new Random().Next(MinValue, MaxValue);
            return X;
        }
        /// <summary>
        /// Scalar Ones Matrix
        /// </summary>
        /// <param name="Dimensional">Dimensional</param>
        /// <param name="Scalar">Scalar Value (Value on Diagonals)</param>
        /// <returns>Scalar Matrix of X</returns>
        public static int[,] ScalarMatrixCreate(int Dimensional = 3, int Scalar = 3)
        {
            return DiagonalMatrixCreate(Dimensional, Scalar, Scalar);
        }
        /// <summary>
        /// Is square matrix?
        /// </summary>
        /// <param name="X">Array</param>
        /// <returns>Is square matrix?</returns>
        public static bool IsSquareMatrix(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ? true : false;
        }
        /// <summary>
        /// Unit Matrix Create
        /// </summary>
        /// <param name="Dimensional">Matrix Dimensional</param>
        /// <returns>Unit Matrix Create</returns>
        public static int[,] UnitMatrix(int Dimensional = 3)
        {
            return ScalarMatrixCreate(Dimensional, 1);
        }
        /// <summary>
        /// Is unit matrix?
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Is unit matrix?</returns>
        public static bool IsUnitMatrix(int[,] X)
        {
            bool Checked = true;
            for (int i = 0; (i < X.GetLength(0) && Checked == true); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    //Diagonal(Diyagonal elemanlar dısındaki elemanlar mı?)
                    if (X[i, j] != 0 && i != j)
                    {
                        Checked = false;
                        break;
                    }
                    else
                    {
                        //Diagonal elemanlar 1 mi?
                        if (X[i, i] != 1 && i == j)
                        {
                            Checked = false;
                            break;
                        }
                    }
                }
            }
            return Checked;
        }
        /// <summary>
        /// List of Diagonals Elements
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>List of Diagonals Elements</returns>
        public static int[] ListOfDiagonalElements(int[,] X)
        {
            if (IsSquareMatrix(X))
            {
                int[] FirstDimensional = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                    FirstDimensional[i] = X[i, i];
                return FirstDimensional;
            }
            else
            {
                Console.WriteLine("Please! Enter square matrix!");
                return new int[1];
            }
        }
        /// <summary>
        /// Trace Of Matrix
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Trace Of Matrix</returns>
        public static int TraceOfMatrix(int[,] X)
        {
            int[] DiagonalElements = ListOfDiagonalElements(X);
            int TraceSum = 0;
            if (IsSquareMatrix(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                    TraceSum += X[i, i];
                return TraceSum;
            }
            else
                return TraceSum;
        }
        /// <summary>
        /// Transpoz Of Matrix
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Transpoz Of Matrix</returns>
        public static int[,] Transpoz(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
                for (int j = 0; j < T.GetLength(1); j++)
                    T[i, j] = X[j, i];
            return T;
        }
        public static int[,] ReShape(int[,] X, int NewRow, int NewCol)
        {
            if (X.Length == NewRow * NewCol)
            {
                int[] OneDimensional = new int[X.Length];
                int Counter = 0;
                int[,] ReShapeMatrix = new int[NewRow, NewCol];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        OneDimensional[Counter] = X[i, j];
                        Counter++;
                    }
                }
                Print(OneDimensional);
                Counter = 0;
                for (int i = 0; i < ReShapeMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < NewCol; j++)
                    {
                        ReShapeMatrix[i, j] = OneDimensional[Counter];
                        Counter++;
                    }
                }
                return ReShapeMatrix;
            }
            else
            {
                Console.WriteLine("An error occurred!");
                return new int[1, 1];
            }
        }
        /// <summary>
        /// Matrix compariison (compare to)
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <param name="Y">Matrix</param>
        /// <returns>Is Equal To</returns>
        public static bool IsEqualTo(int[,] X, int[,] Y)
        {
            bool s = true;
            //Check of Dimensional
            if (X.GetLength(0) == Y.GetLength(0) && X.GetLength(1) == Y.GetLength(1))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] != Y[i, j])
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                s = false;
            }
            return s;
        }
        /// <summary>
        /// Determinant
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Result Of Determinant</returns>
        public static int Determinant(int[,] X)
        {
            int D = -1;
            if (IsSquareMatrix(X))
            {
                if (X.Length == 4)
                    D = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                else if (X.Length == 9)
                    D = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                        X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) +
                        X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                else
                    PrintError("No defined size!");
                return D;
            }
            else
            {
                PrintError("It must be a square matrix!");
                return D;
            }
        }
        /// <summary>
        /// Multiplies the matrix by a scalar value.
        /// </summary>
        /// <param name="c">Scalar Value</param>
        /// <param name="X">Matrix</param>
        /// <returns>Multiplication Result.</returns>
        public static int[,] ScalarMultiply(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    X[i, j] = c * X[i, j];
                }
            }
            return X;
        }
        /// <summary>
        /// Matrix Sum
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Matrix Sum</returns>
        public static int MatrixSum(int[,] X)
        {
            int MSum = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    MSum += X[i, j];
                }
            }
            return MSum;
        }
        public static int[,] SymmetricMatrixCreate(int Dimensional = 3, int MinValue = 1, int MaxValue = 9)
        {
            int[,] X = DiagonalMatrixCreate(Dimensional, MinValue, MaxValue);
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    X[i, j] = new Random().Next(MinValue, MaxValue);
                    X[j, i] = X[i, j];
                }
            }
            return X;
        }
        public static bool IsSymmetricMatrix(int[,] X)
        {
            bool Check = true;
            if (IsSquareMatrix(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] != X[j, i] && i != j)
                        {
                            Check = false;
                        }
                    }
                }
                return Check;
            }
            else
                return Check;
        }
        public static bool IsSymmetricMatrixTwo(int[,] X)
        {
            int[,] Y = Transpoz(X);
            return IsEqualTo(X, Y);
        }
        public static bool IsDiagonalMatrix(int[,] X)
        {
            bool Check = true;
            if (IsSquareMatrix(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] != 0 && i != j)
                        {
                            Check = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                PrintError("The matrix isn't squre!");
                Check = false;
            }
            return Check;
        }
        public static int[,] TopTriangleMatrix(int Dimensional = 3, int MinValue = 0, int MaxValue = 9)
        {
            int[,] X = new int[Dimensional, Dimensional];
            //int[,] TopTriangleMatrix = DiagonalMatrixCreate();
            for (int i = 0; i < Dimensional; i++)
                for (int j = i; j < Dimensional; j++)
                    X[i, j] = new Random().Next(MinValue, MaxValue);
            return X;
        }
        public static int[,] BottomTriangleMatrix(int Dimensional = 3, int MinValue = 0, int MaxValue = 9)
        {
            int[,] X = new int[Dimensional, Dimensional];
            //int[,] X = DiagonalMatrixCreate();
            for (int i = 0; i < Dimensional; i++)
                for (int j = 0; j <= i; j++)
                    X[i, j] = new Random().Next(MinValue, MaxValue);
            return X;
        }
        public static bool IsItTopTriangleMatrix(int[,] X)
        {
            bool Check = true;
            for (int i = 1; i < X.GetLength(0); i++)
                for (int j = 0; j < i/*<=i-1*/; j++)
                    if (X[i, j] != 0)//(!(X[i, j]==0))
                    {
                        Check = false;
                        break;
                    }
            return Check;
        }
        /// <summary>
        /// Is it bottom triangle matrix
        /// </summary>
        /// <remarks>Üst üçgen matris kare matris olmalıdır.</remarks>
        /// <returns>True Or False</returns>
        public static bool IsItBottomTriangleMatrix(int[,] X)
        {
            bool Check = true;
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = i + 1; j < X.GetLength(1); j++)
                    if (!(X[i, j] == 0))
                    {
                        Check = false;
                        break;
                    }
            return Check;
        }
    }
}