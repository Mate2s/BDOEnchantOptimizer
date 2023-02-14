using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDOEnchantOptimizerLib.Tables;

namespace BDOEnchantOptimizerLib
{
    public class BDOEnchantOptimizer
    {
        EnchDB enchTable1 = new EnchDB();

        Item item;
        int memoryFragment_price;
        int blackStone_price;


        Item failstackItem;
        Item fsItem15plus;
        double fSBlackstone_price;
        FSRow[] fSTable;
        EnchRow[] enchTable;

        double[] acessory_price;
        double[] armor_price;

        int fSArmorLvl = 16;

        int fSArmorLvlMax = 16;

        double enchfrompri;
        double enchfromduo;
        double enchfromtri;
        double croneStoneCounter;

        double itemCostLvlDown;

        double marketMarginWithPack = 0.848;
        double marketMarginWithoutPack = 0.65;

        List<AcessoryGroup> accessoryGroup;
        List<ItemLvl> fSArmorLvlGroup;
        List<AcessoryGroup> fSArmorGroup;

        AcessoryGroup FSArmor;

        int failstackStart = 0;
        int failstackEnd = 500;

        bool useFsAccessory = true;
        bool useFsItem15plus = true;

        bool croneStoneEnch = false;
        double cronstoneValue = 2000000;
        double betterBlackstone_price = 2250000;

        bool valuePack = true;
        double margin = 0.848;

        int permanentFreeStartFS = 3;
        public bool ValuePack
        {
            get { return valuePack; }
            set
            {
                valuePack = value;
                if (value)
                    margin = marketMarginWithPack;
                else
                    margin = marketMarginWithoutPack;
            }
        }

        public string ResultBest { get; private set; }
        public EnchRow BestRow { get; private set; }
        public Item EnchItem { get; private set; }
        public bool UseFsItem15plus { get => useFsItem15plus; set => useFsItem15plus = value; }
        public bool UseFsAccessory { get => useFsAccessory; set => useFsAccessory = value; }
        public int MemoryFragment_price { get => memoryFragment_price; set => memoryFragment_price = value; }
        public Item Item { get => item; set => item = value; }
        public EnchDB EnchTable1 { get => enchTable1; set => enchTable1 = value; }
        public int BlackStone_price { get => blackStone_price; set => blackStone_price = value; }
        public Item FailstackItem { get => failstackItem; set => failstackItem = value; }
        public Item FsItem15plus { get => fsItem15plus; set => fsItem15plus = value; }
        public double[] Acessory_price { get => acessory_price; set => acessory_price = value; }
        public double[] Armor_price { get => armor_price; set => armor_price = value; }
        public int FSArmorLvlMax { get => fSArmorLvlMax; set => fSArmorLvlMax = value; }
        public double CroneStoneCounter { get => croneStoneCounter; set => croneStoneCounter = value; }
        public double ItemCostLvlDown { get => itemCostLvlDown; set => itemCostLvlDown = value; }
        public List<AcessoryGroup> AccessoryGroup { get => accessoryGroup; set => accessoryGroup = value; }
        public List<ItemLvl> FSArmorLvlGroup { get => fSArmorLvlGroup; set => fSArmorLvlGroup = value; }
        public List<AcessoryGroup> FSArmorGroup { get => fSArmorGroup; set => fSArmorGroup = value; }
        public int FailstackStart { get => failstackStart; set => failstackStart = value; }
        public int FailstackEnd { get => failstackEnd; set => failstackEnd = value; }
        public bool CroneStoneEnch { get => croneStoneEnch; set => croneStoneEnch = value; }
        public double BetterBlackstone_price { get => betterBlackstone_price; set => betterBlackstone_price = value; }
        public int PermanentFreeStartFS { get => permanentFreeStartFS; set => permanentFreeStartFS = value; }
        public FSRow[] FSTable { get => fSTable; set => fSTable = value; }
        public EnchRow[] EnchTable { get => enchTable; set => enchTable = value; }
        public double FSBlackstone_price { get => fSBlackstone_price; set => fSBlackstone_price = value; }

        public BDOEnchantOptimizer()
        {
            initFSTable();
            initEnchTable();        

            accessoryGroup = new List<AcessoryGroup>();
            accessoryGroup.Add(new AcessoryGroup("cheapest30", 29000, 75000, 336000, 1069000, 2300000, 4500000));
            accessoryGroup.Add(new AcessoryGroup("belt35", 35000, 105000, 385000, 1546468, 3200000, 6300000));
            accessoryGroup.Add(new AcessoryGroup("neck50", 50000, 150000, 672215, 2138867, 4500000, 8900000));

            acessory_price = new double[6];
            armor_price = new double[21];

            fSArmorLvlGroup = new List<ItemLvl>();
            fSArmorLvlGroup.Add(ItemLvl.PRI);
            fSArmorLvlGroup.Add(ItemLvl.DUO);
            fSArmorLvlGroup.Add(ItemLvl.TRI);
            fSArmorLvlGroup.Add(ItemLvl.TET);

            fSArmorLvl = 16;

            fSArmorGroup = new List<AcessoryGroup>();
            fSArmorGroup.Add(new AcessoryGroup("Armor of Hercules", 60000, 43000000, 67000000, 122000000, 330000000, 2000000000));
            fSArmorGroup.Add(new AcessoryGroup("Luck", 50000, 26600000, 60000000, 117000000, 315000000, 2000000000));
            fSArmorGroup.Add(new AcessoryGroup("heve", 618000, 45200000, 62500000, 134000000, 600000000, 3800000000));


            //FSBlackstone_price = 200000;
            failstackItem = new Item(fSBlackstone_price, 15 - 1, Grade.Green, ItemType.Armor);
            fsItem15plus = new Item(26000, 16, Grade.Green, ItemType.Armor);

        }

        private void initEnchTable()
        {
            enchTable = new EnchRow[failstackEnd - failstackStart + 1];
            for (int failstacks = failstackStart; failstacks <= failstackEnd; failstacks++)
            {
                enchTable[failstacks] = new EnchRow();
            }
        }

        private void initFSTable()
        {
            failstackStart = 0;
            fSTable = new FSRow[failstackEnd - failstackStart + 1];
            for (int failstacks = failstackStart; failstacks <= failstackEnd; failstacks++)
            {
                fSTable[failstacks] = new FSRow();
            }
            fSTable[0].TotalFsPrice = 0;
        }

        public double CalculateBestEnch(Item enchItem)
        {
            double bestvalue = 9999999999999999999;
            string stringbestvalue = "";
            string introduce = "for lvl " + (enchItem.Lvl + 1) + " u need:\n";
            StringBuilder sb = new StringBuilder();            
            EnchRow bestRow = new EnchRow();

            for (int failstacks = 0; failstacks < failstackEnd; failstacks++)
            {
                
                double numberOfTryToSuccessWithCS = (double)(1 / GetTableByType(enchItem.ItemType, enchItem.Grade).GetChance(failstacks, enchItem.Lvl + 1));     
                double numberOfTryToSuccess = GetNumberOfAttemptsToSuccessWithFloatingFS(failstacks, enchItem);

                if (enchItem.ItemType == ItemType.Accessory)
                {
                    double currentEnchCost = blackStone_price + enchItem.Price;
                    double AccessoryCostToSuccess = 0;
                    double AccessoryCostToSuccessWithoutCS = (numberOfTryToSuccess - 1) * (double)enchItem.Price + numberOfTryToSuccess * blackStone_price;
                    double AccessoryCostToSuccessWithCSNotDownGrade = numberOfTryToSuccessWithCS * blackStone_price;
                    double AccessoryCostToSuccessWithCSDownGrade = (numberOfTryToSuccessWithCS - 1) * enchItem.Price + (numberOfTryToSuccessWithCS - 1) * blackStone_price - margin * itemCostLvlDown * (numberOfTryToSuccessWithCS - 1);
                    double AccessoryCostToSuccessWithCS = 0.7 * AccessoryCostToSuccessWithCSNotDownGrade + 0.3 * AccessoryCostToSuccessWithCSDownGrade;
                    double failstackscost = fSTable[failstacks].TotalFsPrice; //doupravit pro presne failstackovani-done-ne uplne
                    string output = " ";
                    double totalcostWithoutCS = 0;
                    double totalcost = 0;
                    double totalcostWithCS = 0;
                    bool cronestone = false;

                    totalcostWithCS = failstackscost + AccessoryCostToSuccessWithCS + (croneStoneCounter * numberOfTryToSuccessWithCS * cronstoneValue);
                    totalcostWithoutCS = failstackscost + (double)AccessoryCostToSuccessWithoutCS;

                    if (totalcostWithCS <= totalcostWithoutCS)
                    {
                        totalcost = totalcostWithCS;
                        AccessoryCostToSuccess = AccessoryCostToSuccessWithCS;
                        output = " | CroneStone used";
                        cronestone = true;
                    }
                    else
                    {
                        totalcost = totalcostWithoutCS;
                        AccessoryCostToSuccess = (double)AccessoryCostToSuccessWithoutCS;
                        output = " ";
                        cronestone = false;
                    }

                    enchTable[failstacks] = new EnchRow()
                    {
                        Failstack = failstacks,
                        BlackstoneCost = AccessoryCostToSuccess,
                        Cronestone = cronestone,
                        CountOfTry = numberOfTryToSuccess,
                        DurabilityDown = 0,
                        FsCost = failstackscost,
                        TotalCost = totalcost,
                        TotalCostWithoutFs = (totalcost - failstackscost)
                    };

                    sb.Append("\r\n" + "Failstacks: " + failstacks + " | numberOfTryToSuccess: " + numberOfTryToSuccess +
                              " | failstackcost: " + failstackscost.ToString() + " | AccessoryCostToSuccess: " + AccessoryCostToSuccess
                              + " | cost without fs: " + (totalcost - failstackscost) + output + " | total cost: " + totalcost);

                    if (totalcost < bestvalue)
                    {
                        bestvalue = totalcost;
                        stringbestvalue = "Failstacks: " + failstacks + " | numberOfTryToSuccess: " + numberOfTryToSuccess +
                                          " | failstackcost: " + failstackscost.ToString() + " | AccessoryCostToSuccess: " + AccessoryCostToSuccess
                                          + " | cost without fs: " + (totalcost - failstackscost) + output + " | total cost: " + totalcost;
                        bestRow = new EnchRow()
                        {
                            Failstack = failstacks,
                            BlackstoneCost = AccessoryCostToSuccess,
                            Cronestone = cronestone,
                            CountOfTry = numberOfTryToSuccess,
                            DurabilityDown = 0,
                            FsCost = failstackscost,
                            TotalCost = totalcost,
                            TotalCostWithoutFs = (totalcost - failstackscost)
                        };
                    }
                }
                else
                {
                    double durabilitydown = DorabilityDown(enchItem.Grade, numberOfTryToSuccess, enchItem.Lvl);
                    double repairCostwithArmor = Math.Ceiling(durabilitydown / 10) * enchItem.Price;
                    double repairCostCombineArmorMF = durabilitydown / 10 * enchItem.Price +
                                                      Math.Ceiling((double)((int)durabilitydown % 10) /
                                                                   MemoryFragmentValue(enchItem.Grade)) *
                                                      memoryFragment_price;
                    double repairCostwithMF = Math.Ceiling(durabilitydown / MemoryFragmentValue(enchItem.Grade)) *
                                              memoryFragment_price;
                    double bestcostrepair = Math.Min(Math.Min(repairCostwithArmor, repairCostCombineArmorMF),
                        repairCostwithMF);
                    string output = "";
                    string bestRepairType = "";

                    if (bestcostrepair == repairCostCombineArmorMF)
                        bestRepairType = "armor/weapon +0 + last step with MF";
                    if (bestcostrepair == repairCostwithMF)
                        bestRepairType = "Memory Fragment";
                    if (bestcostrepair == repairCostwithArmor)
                        bestRepairType = "armor/weapon +0";
                    output = output + bestcostrepair;


                    double BlackstoneCostToSuccess = numberOfTryToSuccess * blackStone_price;
                    double BlackstoneCostToSuccessWithCS = numberOfTryToSuccessWithCS * blackStone_price;
                    double failstackscost = fSTable[failstacks].TotalFsPrice; //doupravit pro presne failstackovani-done-ne uplne
                    double totalcost = 0;
                    double croneStoneCost = croneStoneCounter * cronstoneValue;
                    double orangeweaponCSCost17 = itemCostLvlDown / 3.593345075;
                    double orangeweaponCSCost18 = itemCostLvlDown / 1.8659094;
                    double orangeweaponCSCost19 = itemCostLvlDown / 1.449370448979;

                    if (enchItem.Lvl >= 17)
                        if (croneStoneEnch)
                        {
                            totalcost = bestcostrepair + failstackscost + BlackstoneCostToSuccessWithCS +
                                        croneStoneCost * numberOfTryToSuccessWithCS;
                        }
                        else
                        {
                            if (enchItem.Lvl == 17)
                            {
                                double enchnumberduo = numberOfTryToSuccess;
                                double enchfromduo = bestcostrepair + failstackscost + BlackstoneCostToSuccess +
                                                     (enchnumberduo - 1) * enchfrompri;
                                totalcost = enchfromduo;
                            }
                            if (enchItem.Lvl == 18)
                            {
                                double enchnumbertri = numberOfTryToSuccess;
                                double enchfromtri = bestcostrepair + failstackscost + BlackstoneCostToSuccess +
                                                     (enchnumbertri - 1) * enchfromduo;
                                totalcost = enchfromtri;
                            }
                            if (enchItem.Lvl == 19)
                            {
                                double enchnumbertet = numberOfTryToSuccess;
                                double enchfromtet = bestcostrepair + failstackscost + BlackstoneCostToSuccess +
                                                     (enchnumbertet - 1) * enchfromtri;
                                totalcost = enchfromtet;
                            }
                        }
                    else
                    {
                        if (croneStoneEnch)
                            totalcost = bestcostrepair + failstackscost + BlackstoneCostToSuccessWithCS +
                                        croneStoneCost * numberOfTryToSuccessWithCS;
                        else
                            totalcost = bestcostrepair + failstackscost + BlackstoneCostToSuccess;
                    }

                    enchTable[failstacks] = new EnchRow()
                    {
                        Failstack = failstacks,
                        BlackstoneCost = croneStoneEnch ? BlackstoneCostToSuccessWithCS : BlackstoneCostToSuccess,
                        Cronestone = croneStoneEnch,
                        CountOfTry = croneStoneEnch ? numberOfTryToSuccessWithCS : numberOfTryToSuccess,
                        DurabilityDown = durabilitydown,
                        FsCost = failstackscost,
                        TotalCost = totalcost,
                        TotalCostWithoutFs = (totalcost - failstackscost),
                        RepairType = bestRepairType
                    };

                    sb.Append("\r\n" + "Failstacks: " + failstacks + " | total cost: " + totalcost +
                                          " | cost without fs: " + (totalcost - failstackscost) + " | numberOfTryToSuccess: " +
                                          numberOfTryToSuccess + " | durabilitydown: " + durabilitydown.ToString() +
                                          " | failstackcost: " + failstackscost.ToString() +
                                          " | BlackstoneCostToSuccess: " + BlackstoneCostToSuccess + output);

                    if (totalcost < bestvalue)
                    {
                        bestvalue = totalcost;
                        stringbestvalue = "Failstacks: " + failstacks + " | total cost: " + totalcost +
                                          " | cost without fs: " + (totalcost - failstackscost) + " | numberOfTryToSuccess: " +
                                          numberOfTryToSuccess;
                        bestRow = new EnchRow()
                        {
                            Failstack = failstacks,
                            BlackstoneCost = croneStoneEnch ? BlackstoneCostToSuccessWithCS : BlackstoneCostToSuccess,
                            Cronestone = croneStoneEnch,
                            CountOfTry = croneStoneEnch ? numberOfTryToSuccessWithCS : numberOfTryToSuccess,
                            DurabilityDown = 0,
                            FsCost = failstackscost,
                            TotalCost = totalcost,
                            TotalCostWithoutFs = (totalcost - failstackscost),
                            RepairType = bestRepairType
                        };
                    }
                }
            }


            ResultBest = introduce + stringbestvalue;
            BestRow = bestRow;
            EnchItem = enchItem;         
            return bestvalue;
        }

        private double GetNumberOfAttemptsToSuccessWithFloatingFS(int failstacks, Item enchItem)
        {
            //old
            //vazeny prumer pokusů - correct testing by simulations- maybe not wait :D precision can be better but its good enough
            //numberof try very precise
            //GetTableByType(enchItem.ItemType, enchItem.Grade).GetChance(failstacks, enchItem.Lvl);

            double numberOfTryToSuccess = 1 / GetTableByType(enchItem.ItemType, enchItem.Grade).GetChance(failstacks, enchItem.Lvl + 1);
            decimal help = 0;
            decimal value = (decimal)numberOfTryToSuccess;
            decimal totalvalue = 0;
            double jump = GetJumpCount(enchItem);
                        
            value = 1;
            for (var i = 0; i < numberOfTryToSuccess + 20; i++)
            {
                help = help + value * (decimal)GetTableByType(enchItem.ItemType, enchItem.Grade).GetChance((int)(failstacks + i * jump), enchItem.Lvl + 1);
                totalvalue += value;
                value = value * (decimal)(1 - GetTableByType(enchItem.ItemType, enchItem.Grade).GetChance((int)(failstacks + i * jump), enchItem.Lvl + 1));
            }

            numberOfTryToSuccess = (double)(1 / (help / totalvalue));
            return numberOfTryToSuccess;
        }

        private double GetJumpCount(Item enchItem)
        {
            if (enchItem.ItemType == ItemType.Armor || enchItem.ItemType == ItemType.Weapon)
            {
                if (enchItem.Lvl < 15)
                    return 1;
                if (enchItem.Lvl == 15)
                    return 2;
                if (enchItem.Lvl == Convert.ToInt32(ItemLvl.PRI))
                    return 3;
                if (enchItem.Lvl == Convert.ToInt32(ItemLvl.DUO))
                    return 4;
                if (enchItem.Lvl == Convert.ToInt32(ItemLvl.TRI))
                    return 5;
                if (enchItem.Lvl == Convert.ToInt32(ItemLvl.TET))
                    return 6;
            }

            return 1;
        }

        private double DorabilityDown(Grade itemGrade, double numberOfTryToSuccess, int itemlvl)
        {
            if (itemGrade == Grade.Green)
                if (itemlvl >= 15)
                    return (numberOfTryToSuccess - 1) * 10;
                else
                    return (numberOfTryToSuccess - 1) * 5;

            if (itemGrade == Grade.Blue)
                if (itemlvl >= 15)
                    return (numberOfTryToSuccess - 1) * 10;
                else
                    return (numberOfTryToSuccess - 1) * 5;

            if (itemGrade == Grade.Yellow)
                if (itemlvl >= 15)
                    return (numberOfTryToSuccess - 1) * 10;
                else
                    return (numberOfTryToSuccess - 1) * 5;

            if (itemGrade == Grade.Orange)
                if (itemlvl >= 15)
                    return (numberOfTryToSuccess - 1) * 20;
                else
                    return (numberOfTryToSuccess - 1) * 10;

            return (numberOfTryToSuccess - 1) * 10;
        }

        public FSRow[] CalculateFs()
        {
            //double totalPriceFS = 0;
            double itemForFS_price = fSBlackstone_price;
            Item fsitem14 = new Item(12900, 14, Grade.Green, ItemType.Armor);

            fsTableReset();

            //start failstacks from blackspirit with Black Stones
            additionaEnchanceChanceBS(itemForFS_price);

            //celkova cena pri pouziti armoru +14
            calculateFsforArmor14(itemForFS_price, fsitem14);

            //celkova cena pri pouziti accessory
            //itemlvlaccessory 0-TET;            
            if (useFsAccessory)
            {
                calculateFsforAccessorries();
            }

            //celkova cena pri pouziti itemu nad +15
            //fsItemOver15
            if (useFsItem15plus)
            {
                calculateFsforItemOver15();
            }

            return fSTable;
            /*vyresit
            fsTableControl.ReportFS(FSTable);
            */
        }

        private void calculateFsforItemOver15()
        {
            for (int failstacks = failstackStart; failstacks < (failstackEnd - (fSArmorLvlMax - 13)); failstacks++)
            {
                for (fSArmorLvl = 16; fSArmorLvl <= fSArmorLvlMax; fSArmorLvl++)
                {
                    Item fsitemOver15 = new Item(armor_price[fSArmorLvl], fSArmorLvl, fsItem15plus.Grade, fsItem15plus.ItemType);
                    double totalPriceFS = fSTable[failstacks + 1].TotalFsPrice;
                    fsitemOver15.Lvl = fSArmorLvl;

                    double failstackchance15plus;
                    double enchChance;

                    failstackchance15plus = 1 - GetTableByType(fsitemOver15.ItemType, fsitemOver15.Grade).GetChance((int)(failstacks), fSArmorLvl + 1);
                    enchChance = GetTableByType(fsitemOver15.ItemType, fsitemOver15.Grade).GetChance((int)(failstacks), fSArmorLvl + 1);

                    double enchCount15plus = 1 / failstackchance15plus;
                    double durabilitydown = DorabilityDown(fsitemOver15.Grade, 1 + 1, fSArmorLvl);
                    double repairCostwithArmor = (durabilitydown / 10) * armor_price[0];
                    double repairCostwithMF = (durabilitydown / MemoryFragmentValue(fsitemOver15.Grade)) *
                                              memoryFragment_price;
                    double bestcostrepair = Math.Min(repairCostwithArmor, repairCostwithMF);
                    double chanceForSuccessfulEnch = enchCount15plus * enchChance;
                    // double priceForSuccessfulEnch = chanceForSuccessfulEnch * (armor_price[FSArmorLvl + 1] * margin - armor_price[FSArmorLvl]);
                    //double priceForUnSuccessfulEnch = enchCount15plus * (armor_price[FSArmorLvl] - armor_price[FSArmorLvl - 1] * margin);

                    //ok neprodejne duo :(
                    double totalPricePRI;
                    double totalPriceDUOplus;

                    totalPricePRI = 1 * (fSTable[failstacks].TotalFsPrice + betterBlackstone_price + bestcostrepair) +
                        ((1 - failstackchance15plus) / failstackchance15plus) * (fSTable[failstacks].TotalFsPrice + betterBlackstone_price
                        - (armor_price[fSArmorLvl + 1] * margin - armor_price[fSArmorLvl]));


                    totalPriceDUOplus = 1 * (fSTable[failstacks].TotalFsPrice + betterBlackstone_price + bestcostrepair + armor_price[fSArmorLvl] - armor_price[fSArmorLvl - 1] * margin) +
                        ((1 - failstackchance15plus) / failstackchance15plus) * (fSTable[failstacks].TotalFsPrice + betterBlackstone_price
                        - (armor_price[fSArmorLvl + 1] * margin - armor_price[fSArmorLvl]));

                    int jump = fSArmorLvl - 13;

                    totalPriceFS = fSArmorLvl <= 16 ? totalPricePRI : totalPriceDUOplus;
                    if (totalPriceFS < fSTable[failstacks + jump].TotalFsPrice)
                    {
                        for (int i = jump; i > 0; i--)
                        {
                            if (fSTable[failstacks + i].TotalFsPrice > totalPriceFS)
                                fSTable[failstacks + i] = new FSRow(failstacks + i, failstacks, fsitemOver15, enchCount15plus, totalPriceFS);
                        }
                    }
                }
            }
        }

        private void calculateFsforAccessorries()
        {
            for (int failstacks = failstackStart; failstacks < failstackEnd; failstacks++)
            {
                Item fsItemAccessory;
                double oldTotalPriceFS = fSTable[failstacks].TotalFsPrice;
                for (int lvl = 0; lvl < 5; lvl++)
                {
                    fsItemAccessory = new Item(acessory_price[lvl], lvl, Grade.Green, ItemType.Accessory);

                    double failstackchanceaccessory;
                    failstackchanceaccessory = 1 - GetTableByType(fsItemAccessory.ItemType, fsItemAccessory.Grade).GetChance((int)(failstacks), lvl + 1);

                    double enchchanceaccessory;
                    enchchanceaccessory = GetTableByType(fsItemAccessory.ItemType, fsItemAccessory.Grade).GetChance((int)(failstacks), lvl + 1);

                    double enchCountAtLvlAcessory = 1 / failstackchanceaccessory;
                    double chanceForSuccessfulEnch = enchCountAtLvlAcessory * enchchanceaccessory;
                    double priceCurrentEnchAcessory = enchCountAtLvlAcessory * (acessory_price[lvl] + acessory_price[0]);
                    double priceForSuccessfulEnch = chanceForSuccessfulEnch * acessory_price[lvl + 1];
                    double priceForSuccessfulEnchWithMargin = priceForSuccessfulEnch * margin;
                    double totalPriceAccessory = enchCountAtLvlAcessory * oldTotalPriceFS + priceCurrentEnchAcessory - priceForSuccessfulEnchWithMargin;

                    if (totalPriceAccessory < fSTable[failstacks + 1].TotalFsPrice)
                    {
                        fSTable[failstacks + 1] = new FSRow(failstacks + 1, failstacks, fsItemAccessory, enchCountAtLvlAcessory, totalPriceAccessory);
                    }
                }
            }
        }

        private void calculateFsforArmor14(double itemForFS_price, Item fsitem14)
        {
            for (int failstacks = failstackStart; failstacks < failstackEnd; failstacks++)
            {
                double oldTotalPriceFS = fSTable[failstacks].TotalFsPrice;
                double failstackchance;
                failstackchance = 1 - GetTableByType(failstackItem.ItemType, failstackItem.Grade).GetChance((int)(failstacks), failstackItem.Lvl + 1);
                double enchCountAtLvl = 1 / failstackchance;
                double durabilitydown = DorabilityDown(fsitem14.Grade, 1 + 1, fsitem14.Lvl);
                double repairCostwithArmor = (durabilitydown / 10.0) * fsitem14.Price;
                double repairCostwithMF = (durabilitydown / MemoryFragmentValue(fsitem14.Grade)) *
                                          memoryFragment_price;
                double bestcostrepair = Math.Min(repairCostwithArmor, repairCostwithMF);
                double downgrade_cost = 100000;

                //celkova cena pri pouziti armoru
                double totalPriceFS = 1 * (fSTable[failstacks].TotalFsPrice + itemForFS_price + bestcostrepair) + ((1 - failstackchance) / failstackchance) * (fSTable[failstacks].TotalFsPrice + itemForFS_price + downgrade_cost);
                if (permanentFreeStartFS > failstacks)
                {
                    totalPriceFS = 0;
                }
                //FSTable[failstacks + 1] = new FSRow(failstacks + 1, failstacks, failstackItem, enchCountAtLvl, totalPriceFS);

                if (totalPriceFS < fSTable[failstacks + 1].TotalFsPrice)
                {
                    fSTable[failstacks + 1] = new FSRow(failstacks + 1, failstacks, failstackItem, enchCountAtLvl, totalPriceFS);
                }
            }
        }

        private void additionaEnchanceChanceBS(double itemForFS_price)
        {
            Item item = new Item(0, 0, Grade.Orange, ItemType.Armor);
            fSTable[5 + permanentFreeStartFS] = new FSRow(5 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 5);
            fSTable[10 + permanentFreeStartFS] = new FSRow(10 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 12);
            fSTable[15 + permanentFreeStartFS] = new FSRow(15 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 21);
            fSTable[20 + permanentFreeStartFS] = new FSRow(20 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 33);
            fSTable[25 + permanentFreeStartFS] = new FSRow(25 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 53);
            fSTable[30 + permanentFreeStartFS] = new FSRow(30 + permanentFreeStartFS, 0, item, 1, itemForFS_price * 84);
        }

        private void fsTableReset()
        {
            for (int failstacks = failstackStart; failstacks <= failstackEnd; failstacks++)
            {
                fSTable[failstacks].TotalFsPrice = double.MaxValue;
            }
            fSTable[0].TotalFsPrice = 0;
        }


        private int MemoryFragmentValue(Grade itemGrade)
        {
            if (itemGrade == Grade.White) return 10;
            if (itemGrade == Grade.Blue) return 2;
            return itemGrade == Grade.Green ? 5 : 1;
        }

        public double GetStartChanceByType(ItemType itemType, Grade grade, int lvl)
        {
            return GetTableByType(itemType, grade).enchantTableRows.Where(x => x.Level == lvl).SingleOrDefault().StartChance;
        }

        public EnchantTable GetTableByType(ItemType itemtype, Grade grade)
        {
            var tables = from x in EnchDB.Instance.EnchantTables
                         where x.ItemType == itemtype && x.Grade == grade
                         select x;
            var table = tables.SingleOrDefault();

            return table as EnchantTable;
        }

        public double GetChancePerFSByType(ItemType itemType, Grade grade, int lvl)
        {
            return GetTableByType(itemType, grade).enchantTableRows.Where(x => x.Level == lvl).SingleOrDefault().ChancePerFS;
        }

        public int GetSoftcapFailstackTableByType(ItemType itemType, Grade grade, int lvl)
        {
            return GetTableByType(itemType, grade).enchantTableRows.Where(x => x.Level == lvl).SingleOrDefault().SoftcapFS;
        }

        public void Calculate()
        {
            CalculateFs();
            //calculateBestEnch();
            if (item.ItemType != ItemType.Accessory)
            {
                enchfrompri = CalculateBestEnch(new Item(item.Price, 16, item.Grade, item.ItemType));
                enchfromduo = CalculateBestEnch(new Item(item.Price, 17, item.Grade, item.ItemType));
                enchfromtri = CalculateBestEnch(new Item(item.Price, 18, item.Grade, item.ItemType));
            }
            CalculateBestEnch(item);
        }
    }
}

