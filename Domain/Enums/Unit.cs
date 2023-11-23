using System;

namespace CourseWork.Domain.Enums
{
    public enum Unit
    {
        Gram, Milliliter, Piece, TeaSpoon, TableSpoon, Optional, Taste
    }

    public static class UnitExtension
    {
        public static string ToRussian(this Unit unit)
        {
            return unit switch
            {
                Unit.Gram => "гр",
                Unit.Milliliter => "мл",
                Unit.Piece => "шт",
                Unit.TeaSpoon => "ч.л.",
                Unit.TableSpoon => "ст.л.",
                Unit.Optional => "По желанию",
                Unit.Taste => "По вкусу",
                _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
            };
        }
    }
}