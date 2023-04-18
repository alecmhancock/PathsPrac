using System;
namespace PathsPrac
{
	public class PointRetrieval
	{
		public PointRetrieval()
		{
		}
        // need to convert output to tuples, joy oh joy
        public static Tuple<double, double> FindNortheasternMostPoint(List<Tuple<double, double>> coordinates)
        {
            double maxLat = double.MinValue;
            double maxLon = double.MinValue;
            foreach (Tuple<double, double> coord in coordinates)
            {
                double lat = coord.Item1;
                double lon = coord.Item2;
                if (lat > maxLat)
                {
                    maxLat = lat;
                }
                if (lon > maxLon)
                {
                    maxLon = lon;
                }
            }
            return Tuple.Create(maxLat, maxLon);
        }
        public static Tuple<double, double> FindNorthwesternMostPoint(List<Tuple<double, double>> coordinates)
        {
            double maxLat = double.MinValue;
            double minLon = double.MaxValue;
            foreach (Tuple<double, double> coord in coordinates)
            {
                double lat = coord.Item1;
                double lon = coord.Item2;
                if (lat > maxLat)
                {
                    maxLat = lat;
                }
                if (lon < minLon)
                {
                    minLon = lon;
                }
            }
            return Tuple.Create(maxLat, minLon);
        }

        public static Tuple<double, double> FindSoutheasternMostPoint(List<Tuple<double, double>> coordinates)
        {
            double minLat = double.MaxValue;
            double maxLon = double.MinValue;
            foreach (Tuple<double, double> coord in coordinates)
            {
                double lat = coord.Item1;
                double lon = coord.Item2;
                if (lat < minLat)
                {
                    minLat = lat;
                }
                if (lon > maxLon)
                {
                    maxLon = lon;
                }
            }
            return Tuple.Create(minLat, maxLon);
        }

        public static Tuple<double, double> FindSouthwesternMostPoint(List<Tuple<double, double>> coordinates)
        {
            double minLat = double.MaxValue;
            double minLon = double.MaxValue;
            foreach (Tuple<double, double> coord in coordinates)
            {
                double lat = coord.Item1;
                double lon = coord.Item2;
                if (lat < minLat)
                {
                    minLat = lat;
                }
                if (lon < minLon)
                {
                    minLon = lon;
                }
            }
            return Tuple.Create(minLat, minLon);
        }

        // 3rd point logic, haversine formula


    }
}

