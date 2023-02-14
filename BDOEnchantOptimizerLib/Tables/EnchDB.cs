using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib.Tables
{

    public sealed class EnchDB
    {
        private static EnchDB instance = null;
        private static readonly object padlock = new object();

        private List<EnchantTable> enchantTables = new List<EnchantTable>();
        public List<EnchantTable> EnchantTables { get => enchantTables; set => enchantTables = value; }

        public EnchDB()
        {
            Init();            
        }

        private void Init()
        {
            GenerateArmorTable();
            GenerateWeaponTable();
            GenerateAccessoryTable();
            CalcAllTables();           
        }

        private void CalcAllTables()
        {
            foreach(var x in EnchantTables)
            {
                x.CalcAllRows();
            }
        }

        private void GenerateAccessoryTable()
        {
            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.25, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.5, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.405, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.3, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.2, CapChance = 0.90 },
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.25, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.5, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.405, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.3, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.2, CapChance = 0.90 },
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.3, SoftcapChance = 0.72, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.5, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.405, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.3, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.2, CapChance = 0.90 },
                }
            });
        }

        private void GenerateWeaponTable()
        {

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Orange,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.13080, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.10624, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.034, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.0051, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.002, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });
        }

        private void GenerateArmorTable()
        {

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade = Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 1 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });
        }

        public static EnchDB Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new EnchDB();
                    }
                    return instance;
                }
            }
        }
    }





















    /*
    public class EnchDB
    {
        private List<EnchantTable> enchantTables;

        public List<EnchantTable> EnchantTables { get => enchantTables; set => enchantTables = value; }


        public EnchDB()
        {

            //Armor

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade=Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Armor,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0.2564, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.17245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.07695, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.0625, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.05, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.0286, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });


            //Weapon

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Weapon,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 6, StartChance = 1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 7, StartChance = 0, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 8, StartChance = 0.7, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 9, StartChance = 0.2041, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 10, StartChance = 0.1429, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 11, StartChance = 0.10, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 12, StartChance = 0.0667, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 13, StartChance = 0.04, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 14, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 15, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 16, StartChance = 0.1176, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 17, StartChance = 0.07687, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 18, StartChance = 0.06245, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 19, StartChance = 0.02, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 20, StartChance = 0.003, SoftcapChance = 0.7, CapChance = 0.90 }
                }
            });


            //Accessories

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Yellow,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.25, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.7, CapChance = 0.90 },
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Blue,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.25, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.7, CapChance = 0.90 },
                }
            });

            enchantTables.Add(new EnchantTable()
            {
                ItemType = ItemType.Accessory,
                Grade = Grade.Green,
                ChancePerFsConvertionConstant = 0.1,
                ChancePerFsOverSoftcapConvertionConstant = 0.02,
                enchantTableRows = new List<EnchantTableRow>()
                {
                    new EnchantTableRow { Level = 1, StartChance = 0.3, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 2, StartChance = 0.1, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 3, StartChance = 0.075, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 4, StartChance = 0.025, SoftcapChance = 0.7, CapChance = 0.90 },
                    new EnchantTableRow { Level = 5, StartChance = 0.005, SoftcapChance = 0.7, CapChance = 0.90 },
                }
            });
        }

    }
    */

}
