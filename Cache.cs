namespace CalculationSimulation
{
    /// <summary>
    /// This class acts as a cache of already calculated results
    /// </summary>
    public class Cache
    {
        #region Instance fields
        private int[,] cacheValues;
        #endregion

        #region Constructor
        public static class CacheSettings
        {
            public const int DimensionX = 10;
            public const int DimensionY = 10;
            public const int CalculateNoValue = -1;
        }
        public Cache()
        {
            // Create a 5x5 cache of results
            cacheValues = new int[CacheSettings.DimensionX, CacheSettings.DimensionY];

            for (int x = 0; x < CacheSettings.DimensionX; x++)
            {
                for (int y = 0; y < CacheSettings.DimensionY; y++)
                {
                    cacheValues[x, y] = CacheSettings.CalculateNoValue; // -1 means "no result stored"
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Look up the value stored in cell [x,y]
        /// </summary>
        public int Lookup(int x, int y)
        {
            return cacheValues[x, y];
        }

        /// <summary>
        /// Stores the given value in cell [x,y]
        /// </summary>
        public void Insert(int x, int y, int value)
        {
            cacheValues[x, y] = value;
        } 
        #endregion
    }
}
