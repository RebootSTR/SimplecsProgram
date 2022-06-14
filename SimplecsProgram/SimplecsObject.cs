using System.Collections.Generic;

namespace SimplecsProgram
{
    public class SimplecsObject
    {
        public List<float> args ;
        public List<List<float>> limits ;
        public List<float> limitValues ;
        
        public List<float> basis ;
        public List<int> basisIndexes ;

        public SimplecsObject(List<float> args, List<List<float>> limits, List<float> limitValues, bool isCanon)
        {
            this.args = args;
            this.limits = limits;
            this.limitValues = limitValues;
            if (!isCanon)
            {
                doCanon();
            }
            
            var basises = new List<float>();
            var basisIndexes = new List<int>();
            for (int i = 0; i < limits.Count; i++)
            {
                basises.Add(0);
                basisIndexes.Add(args.Count - limits.Count + i);
            }
            basis = basises;
            this.basisIndexes = basisIndexes;
        }
        
        public SimplecsObject(
            List<float> args, 
            List<List<float>> limits, 
            List<float> limitValues, 
            bool isCanon, 
            List<float> basis,
            List<int> basisInds): this(args, limits, limitValues, isCanon)
        {
            this.basis = basis;
            this.basisIndexes = basisInds;
        }
        
        private void doCanon()
        {
            for (int i = 0; i < limits.Count; i++)
            {
                args.Add(0);
            }

            for (int i = 0; i < limits.Count; i++)
            {
                for (int j = 0; j < limits.Count; j++)
                {
                    float toAdd = i == j ? 1 : 0;
                    limits[i].Add(toAdd);
                }
            }
        }
        
        
        public float getAlpha(int index)
        {
            float alpha = -args[index];
            for (int i = 0; i < limits.Count; i++)
            {
                alpha += basis[i] * limits[i][index];
            }
            return alpha;
        }
        
        
        public float getK(int column, int row)
        {
            return limitValues[row] / limits[row][column];
        }
        
        public float getX(int index)
        {
            for (int i = 0; i < limitValues.Count; i++)
            {
                if (basisIndexes[i] == index)
                {
                    return limitValues[i];
                }
            }
            return 0;
        }
        
        public float getF()
        {
            float f = 0;
            for (int i = 0; i < limitValues.Count; i++)
            {
                f += basis[i] * limitValues[i];
            }
            return f;
        }
    }
}
