//wap with a static class  math function  that contains different function of math like square cube  linear regression  polynomial regression and implement them
using System;
static class MathFunctions
{
    public static double Square(double x)
    {
        return x * x;
    }

    public static double Cube(double x)
    {
        return x * x * x;
    }

    public static (double slope, double intercept) LinearRegression(double[] x, double[] y)
    {
        int n = x.Length;
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }

        double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        double intercept = (sumY - slope * sumX) / n;

        return (slope, intercept);
    }

    public static double[] PolynomialRegression(double[] x, double[] y, int degree)
    {
        int n = x.Length;
        double[] coefficients = new double[degree + 1];

        // Create the Vandermonde matrix
        double[,] vandermonde = new double[n, degree + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= degree; j++)
            {
                vandermonde[i, j] = Math.Pow(x[i], j);
            }
        }

        // Solve the normal equations
        for (int j = 0; j <= degree; j++)
        {
            for (int k = 0; k <= degree; k++)
            {
                coefficients[j] += vandermonde[j, k] * y[k];
            }
        }

        return coefficients;
    }
}
