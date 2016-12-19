using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestLocker
{
    internal class CityBlock
    {
        private readonly int _x;
        private readonly int _y;
        private readonly bool _isLocker;
        private readonly CityBlock _neighbor;

        public CityBlock(int x, int y, bool isLocker)
        {
            this._x = x;
            this._y = y;
            this._isLocker = isLocker;
        }

        public CityBlock(int x, int y, bool isLocker, CityBlock neighbor)
        {
            this._x = x;
            this._y = y;
            this._isLocker = isLocker;
            this._neighbor = neighbor;
        }


        internal int X
        {
            get { return _x; }
        }

        internal int Y
        {
            get { return _y; }
        }

        internal bool IsLocker
        {
            get { return _isLocker; }
        }

        internal CityBlock Neighbor
        {
            get { return _neighbor; }
        }
    }
}
