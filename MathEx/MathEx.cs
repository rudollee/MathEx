using System;

namespace MathExtention
{
    public static class MathEx
    {
		/// <summary>
		/// Round Number by Custom Interval
		/// </summary>
		/// <param name="d0">Primitive</param>
		/// <param name="di">Interval</param>
		/// <returns></returns>
		public static double RoundEx(double d0, double di)
		{
			di = 1 / di;
			return Math.Round(d0 * di) / di;
		}

		/// <summary>
		/// Round Number by Custom Interval
		/// </summary>
		/// <param name="d0">Primitive</param>
		/// <param name="di">Interval</param>
		/// <returns></returns>
		public static decimal RoundEx(decimal d0, decimal di)
		{
			di = 1 / di;
			return Math.Round(d0 * di) / di;
		}

		/// <summary>
		/// Ceiling Number by Custom Interval
		/// </summary>
		/// <param name="d0">Primitive</param>
		/// <param name="di">Interval</param>
		/// <returns></returns>
		public static double CeilingEx(double d0, double di)
		{
			di = 1 / di;
			return (d0 > 0 ? Math.Ceiling(d0 * di) : Math.Floor(d0 * di)) / di;
		}

		/// <summary>
		/// Ceiling Number by Custom Interval
		/// </summary>
		/// <param name="d0">Primitive</param>
		/// <param name="di">Interval</param>
		/// <returns></returns>
		public static decimal CeilingEx(decimal d0, decimal di)
		{
			di = 1 / di;
			return (d0 > 0 ? Math.Ceiling(d0 * di) : Math.Floor(d0 * di)) / di;
		}
	}
}
