namespace App.Services;

public class CalculatorService : ICalculatorService
{
    public double BMI(double weight, double heightInCm)
    {
        // 檢查體重是否為負值
        if (weight < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(weight), "Weight cannot be negative.");
        }

        // 檢查身高是否為零
        if (heightInCm <= 0)
        {
            throw new DivideByZeroException("Height cannot be zero.");
        }

        // 將身高轉換為米
        double heightInM = heightInCm / 100;

        // 計算BMI
        return weight / (heightInM * heightInM);
    }
}
