
// ---- C# II (Dor Ben Dor) ----
//  Layan Metanes + Liron Rotman
// -----------------------------
using GenericHW;

class DiceInt : Dice<int>
{
    public int Scalar { get; set; }
    public override int BaseDie { get; set; }

    public DiceInt(int x, int y) : base(y)
    {
        this.Scalar = x;
    }

    public override int Roll()
    {
        int result = 0;
        Random rnd = new Random();
        for (int i = 0; i < this.Scalar; i++)
        {
            result += rnd.Next(1, base.BaseDie + 1);
        }
        return result;
    }

    public override string ToString()
    {
        return $"Dice({Scalar}d,{BaseDie})";
    }

    public override bool Equals(object? obj)
    {
        DiceInt d = (DiceInt)obj;
        return Scalar == d.Scalar && BaseDie == d.BaseDie;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}


