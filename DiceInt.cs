
// ---- C# II (Dor Ben Dor) ----
//  Layan Metanes + Liron Rotman
// -----------------------------
using GenericHW;

class DiceInt : Dice<int>
{
    public int Scalar { get; set; }
    public int BaseDie { get; set; }
    public int Modifier { get; set; }

    public DiceInt(int x, int y) : base(x, y)
    {

    }

    public override int Roll()
    {
        int result = 0;
        Random rnd = new Random();
        for (int i = 0; i < base.Scalar; i++)
        {
            result += rnd.Next(1, base.BaseDie + 1);
        }
        result += Modifier;
        return result;
    }

    public override string ToString()
    {
        return $"Dice({Scalar}d,{BaseDie},{Modifier})";
    }

    public override bool Equals(object? obj)
    {
        DiceInt d = (DiceInt)obj;
        return Scalar == d.Scalar && BaseDie == d.BaseDie && Modifier == d.Modifier;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}


