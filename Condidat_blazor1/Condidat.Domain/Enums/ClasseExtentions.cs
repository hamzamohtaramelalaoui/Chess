namespace Condidat.Domain.Enums;
public static class EnumExtensions
{
    public static string ToDescriptionString(this Situation val)
    {
        return val switch
        {
            Situation.Veuf => "veuf(ve)",
            Situation.Marié => "Marié(e)",
            _ => throw new ArgumentOutOfRangeException(nameof(val), val, null)
        };
    }

    public static string ToDescriptionString(this Sexe val)
    {
        return val switch
        {
            Sexe.Masculin => "Masculin",
            Sexe.Féminin => "Féminin",
            _ => throw new ArgumentOutOfRangeException(nameof(val), val, null)
        };
    }
}
