using System.Collections.Generic;

namespace ProjectList
{/*
    在给定的网格中，每个单元格可以有以下三个值之一：

	值 0 代表空单元格；
	值 1 代表新鲜橘子；
	值 2 代表腐烂的橘子。

每分钟，任何与腐烂的橘子（在 4 个正方向上）相邻的新鲜橘子都会腐烂。

返回直到单元格中没有新鲜橘子为止所必须经过的最小分钟数。如果不可能，返回 -1。

示例 1：

输入：[[2,1,1],[1,1,0],[0,1,1]]
输出：4

示例 2：

输入：[[2,1,1],[0,1,1],[1,0,1]]
输出：-1
解释：左下角的橘子（第 2 行， 第 0 列）永远不会腐烂，因为腐烂只会发生在 4 个正向上。

示例 3：

输入：[[0,2]]
输出：0
解释：因为 0 分钟时已经没有新鲜橘子了，所以答案就是 0 。

提示：

	1 <= grid.length <= 10
	1 <= grid[0].length <= 10
	grid[i][j] 仅为 0、1 或 2

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/rotting-oranges
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 *
 * */

    public class RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            int[] dr = new int[] { -1, 0, 1, 0 };
            int[] dc = new int[] { 0, -1, 0, 1 };
            
            int R = grid.Length, L = grid[0].Length;
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int empty = 0;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    switch (grid[i][j])
                    {
                        case 2:
                            int index = i * L + j;
                            queue.Enqueue(index);
                            dic.Add(index, 0);
                            break;
                        case 0:
                            empty++;
                            break;
                        default:
                            break;
                    }
                }
            }
            int res = 0;
            while (queue.Count > 0)
            {
                int index = queue.Dequeue();
                int r = index / L, l = index % L;
                for (int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i];
                    int nc = l + dc[i];
                    if (nr >= 0 && nr < R && nc >= 0 && nc < L && grid[nr][ nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        int nindex = nr * L + nc;
                        queue.Enqueue(nindex);
                        dic.Add(nindex, dic[index] + 1);
                        res = dic[nindex];
                    }
                }
            }

            return R*L-empty == dic.Count ? res : -1;
        }
    }
}