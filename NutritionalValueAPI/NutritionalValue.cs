namespace NutritionalValueAPI
{
    public class NutritionalValue
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Weight { get; set; } = 0;
        public int Kcal { get; set; } = 0;
        public int MacroCarbohydratesWhole { get; set; } = 0;
        public int MacroCarbohydratesSugar { get; set; } = 0;
        public int MacroCarbohydratesWFiber { get; set; } = 0;
        public int MacroProteins { get; set; } = 0;
        public int MacroFat { get; set; } = 0;
        public int VitaminA { get; set; } = 0;
        public int VitaminB1 { get; set; } = 0;
        public int VitaminB2 { get; set; } = 0;
        public int VitaminB3 { get; set; } = 0;
        public int VitaminB5 { get; set; } = 0;
        public int VitaminB6 { get; set; } = 0;
        public int VitaminB7 { get; set; } = 0;
        public int VitaminB9 { get; set; } = 0;
        public int VitaminB12 { get; set; } = 0;
        public int VitaminC { get; set; } = 0;
        public int VitaminD { get; set; } = 0;
        public int VitaminE { get; set; } = 0;
        public int VitaminK { get; set; } = 0;
        public int MineralsCalcium { get; set; } = 0;
        public int MineralsCopper { get; set; } = 0;
        public int MineralsFluoride { get; set; } = 0;
        public int MineralsIron { get; set; } = 0;
        public int MineralsMagnesium { get; set; } = 0;
        public int MineralsPhosphorus { get; set; } = 0;
        public int MineralsPptassium { get; set; } = 0;
        public int MineralsSelenium { get; set; } = 0;
        public int MineralsSodium { get; set; } = 0;
        public int MineralsZinc { get; set; } = 0;
        public string ImageUrl { get; set; } = string.Empty;

    }
}