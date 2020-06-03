﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Stats
    {
        private static Stats instance;
        private static List<int> FPList;
        private static List<int> HPList;
        private static List<int> Stamina;
        private static List<int> soul;
        public Stats(){
            soul = new List<int> { 0, 673, 690, 707, 724, 741, 758, 775, 793, 811, 829, 847, 1039, 1238, 1445, 1660, 1883, 2114, 2353, 2601, 2857, 3122, 3396, 3678, 3970, 4271, 4581, 4900, 5229, 5567, 5915, 6273, 6641, 7019, 7407, 7805, 8214, 8634, 9064, 9505, 9957, 10420, 10894, 11379, 11876, 12384, 12904, 13436, 13979, 14535, 15103, 15683, 16275, 16880, 17497, 18127, 18770, 19426, 20095, 20777, 21472, 22181, 22904, 23640, 24390, 25154, 25932, 26724, 27530, 28351, 29186, 30036, 30901, 31780, 32675, 33585, 34510, 35450, 36406, 37377, 38364, 39367, 40386, 41421, 42472, 43539, 44623, 45724, 46841, 47975, 49126, 50294, 51479, 52681, 53901, 55138, 56393, 57666, 58956, 60265, 61592, 62937, 64300, 65682, 67082, 68501, 69939, 71396, 72872, 74367, 75881, 77415, 78969, 80542, 82135, 83748, 85381, 87034, 88707, 90401, 92115, 93850, 95606, 97382, 99180, 100999, 102839, 104700, 106583, 108487, 110413, 112361, 114331, 116323, 118337, 120373, 122432, 124514, 126618, 128745, 130895, 133068, 135264, 137483, 139726, 141992 };
            HPList = new List<int> { 0, 0, 301, 305, 311, 320, 331, 345, 362, 381, 403, 427, 454, 483, 515, 550, 594, 638, 681, 723, 764, 804, 842, 879, 914, 947, 977, 1000, 1019, 1038, 1056, 1074, 1092, 1109, 1125, 1141, 1157, 1172, 1186, 1200, 1213, 1226, 1238, 1249, 1260, 1269, 1278, 1285, 1292, 1297, 1300, 1302, 1304, 1307, 1309, 1312, 1314, 1316, 1319, 1321, 1323, 1326, 1328, 1330, 1333, 1335, 1337, 1340, 1342, 1344, 1346, 1348, 1351, 1353, 1355, 1357, 1359, 1361, 1363, 1365, 1367, 1369, 1371, 1373, 1375, 1377, 1379, 1381, 1383, 1385, 1386, 1388, 1390, 1391, 1393, 1395, 1396, 1397, 1399, 1400 };
            FPList = new List<int> { 0, 50, 53, 58, 62, 67, 72, 77, 82, 87, 93, 98, 103, 109, 114, 120, 124, 130, 136, 143, 150, 157, 165, 173, 181, 189, 198, 206, 215, 224, 233, 242, 251, 260, 270, 280, 283, 286, 289, 293, 296, 299, 302, 305, 309, 312, 315, 318, 320, 323, 326, 329, 332, 334, 337, 339, 342, 344, 346, 348, 350, 352, 355, 358, 361, 364, 366, 369, 372, 375, 377, 380, 383, 385, 388, 391, 394, 396, 399, 402, 404, 407, 409, 412, 415, 417, 420, 422, 425, 427, 430, 432, 434, 437, 439, 441, 444, 446, 448, 450 };
            Stamina = new List<int> { 0, 81, 82, 83, 84, 85, 86, 87, 88, 90, 94, 95, 97, 98, 100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 125, 127, 129, 132, 134, 136, 139, 141, 144, 146, 149, 152, 154, 157, 160, 160, 160, 160, 160, 160, 161, 161, 161, 161, 161, 161, 162, 162, 162, 162, 162, 162, 163, 163, 163, 163, 163, 163, 164, 164, 164, 164, 164, 164, 165, 165, 165, 165, 165, 165, 166, 166, 166, 166, 166, 166, 167, 167, 167, 167, 167, 167, 168, 168, 168, 168, 168, 168, 169, 169, 169, 169, 169, 170 };

    }
        public static Stats getInstance()
        {
            if (instance == null)
            {
                instance = new Stats();
            }
            return instance;

        }

        //CALCULATORS
        public int calculateSouls(int current, int target)
        {
            //Adjust to list index
            current--;
            target++;

            int souls = 0;

            for (int i = 1; i < target; i++)
            {
                souls += soul[current];
                current++;
            }

            return souls;
        }
        public int soulsToNextLevel(int level)
        {
            return soul[level];
        }
        public int calculateHP(int level)
        {
            return HPList[level];
        }
        public int calculateFP(int level)
        {
            return FPList[level];
        }
        public int calculateStamina(int level)
        {
            return Stamina[level];
        }
    }
}
