using System;
using System.Collections.Generic;

namespace SimplecsProgram
{
    public static class SimplecsCalc
    {
        public static SimplecsObject calculateMin(SimplecsObject simplecsObject)
        {
            int maxAplhaInd = 0;
            float maxAlpha = 0;
            for (int i = 0; i < simplecsObject.args.Count; i++)
            {
                var alpha = simplecsObject.getAlpha(i);
                if (alpha > maxAlpha)
                {
                    maxAlpha = alpha;
                    maxAplhaInd = i;
                }
            }
            if (maxAlpha <= 0) throw new AlreadySolvedException();

            int kInd = -1;
            float minK = float.MaxValue;
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                var k = simplecsObject.getK(maxAplhaInd, i);
                if (k < minK && k >= 0)
                {
                    minK = k;
                    kInd = i;
                }
            }
            if (kInd == -1) throw new NoResultException();

            var basis = simplecsObject.limits[kInd][maxAplhaInd];

            var newB = new List<float>();
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                if (i == kInd)
                {
                    newB.Add(simplecsObject.limitValues[i] / basis);
                }
                else
                {
                    newB.Add(simplecsObject.limitValues[i] -
                             (simplecsObject.limitValues[kInd] * simplecsObject.limits[i][maxAplhaInd]) / basis);
                }
            }

            var newBasis = new List<float>();
            var newBasisInds = new List<int>();
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                if (i == kInd)
                {
                    newBasis.Add(simplecsObject.args[maxAplhaInd]);
                    newBasisInds.Add(maxAplhaInd);
                }
                else
                {
                    newBasis.Add(simplecsObject.basis[i]);
                    newBasisInds.Add(simplecsObject.basisIndexes[i]);
                }
            }

            var newLimits = new List<List<float>>();
            for (int row = 0; row < simplecsObject.limits.Count; row++)
            {
                newLimits.Add(new List<float>());
                for (int column = 0; column < simplecsObject.args.Count; column++)
                {
                    var element = simplecsObject.limits[row][column];
                    if (row == kInd)
                    {
                        newLimits[row].Add(element / basis);
                    }
                    else
                    {
                        newLimits[row].Add(element -
                                           (simplecsObject.limits[kInd][column] * simplecsObject.limits[row][maxAplhaInd]) /
                                           basis);
                    }
                }
            }

            return new SimplecsObject(
                simplecsObject.args,
                newLimits,
                newB,
                true,
                newBasis,
                newBasisInds
            );
        }

        public static SimplecsObject calculateMax(SimplecsObject simplecsObject)
        {
            int minAplhaInd = 0;
            float minAlpha = 0;
            for (int i = 0; i < simplecsObject.args.Count; i++)
            {
                var alpha = simplecsObject.getAlpha(i);
                if (alpha < minAlpha)
                {
                    minAlpha = alpha;
                    minAplhaInd = i;
                }
            }
            if (minAlpha >= 0) throw new AlreadySolvedException();

            int kInd = -1;
            float minK = float.MaxValue;
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                var k = simplecsObject.getK(minAplhaInd, i);
                if (k < minK && k >= 0)
                {
                    minK = k;
                    kInd = i;
                }
            }
            if (kInd == -1) throw new NoResultException();

            var basis = simplecsObject.limits[kInd][minAplhaInd];

            var newB = new List<float>();
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                if (i == kInd)
                {
                    newB.Add(simplecsObject.limitValues[i] / basis);
                }
                else
                {
                    newB.Add(simplecsObject.limitValues[i] -
                             (simplecsObject.limitValues[kInd] * simplecsObject.limits[i][minAplhaInd]) / basis);
                }
            }

            var newBasis = new List<float>();
            var newBasisInds = new List<int>();
            for (int i = 0; i < simplecsObject.limits.Count; i++)
            {
                if (i == kInd)
                {
                    newBasis.Add(simplecsObject.args[minAplhaInd]);
                    newBasisInds.Add(minAplhaInd);
                }
                else
                {
                    newBasis.Add(simplecsObject.basis[i]);
                    newBasisInds.Add(simplecsObject.basisIndexes[i]);
                }
            }

            var newLimits = new List<List<float>>();
            for (int row = 0; row < simplecsObject.limits.Count; row++)
            {
                newLimits.Add(new List<float>());
                for (int column = 0; column < simplecsObject.args.Count; column++)
                {
                    var element = simplecsObject.limits[row][column];
                    if (row == kInd)
                    {
                        newLimits[row].Add(element / basis);
                    }
                    else
                    {
                        newLimits[row].Add(element -
                                           (simplecsObject.limits[kInd][column] * simplecsObject.limits[row][minAplhaInd]) /
                                           basis);
                    }
                }
            }

            return new SimplecsObject(
                simplecsObject.args,
                newLimits,
                newB,
                true,
                newBasis,
                newBasisInds
            );
        }
    }
}
