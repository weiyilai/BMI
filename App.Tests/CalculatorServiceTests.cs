using App.Services;

namespace App.Tests;

[TestFixture]
public class CalculatorServiceTests
{
    private CalculatorService _calculatorService;

    [SetUp]
    public void Setup()
    {
        _calculatorService = new CalculatorService();
    }

    /// <summary>
    /// 計算 BMI 有效輸入 預期結果 正確的BMI
    /// </summary>
    [Test]
    public void When_Calculator_BMI_ValidInputs_Expected_CorrectBMI()
    {
        // Arrange
        double weight = 70;
        double height = 175;

        // Act
        double result = _calculatorService.BMI(weight, height);

        // Assert
        // 四捨五入到小數第二
        Assert.That(result, Is.EqualTo(22.86).Within(0.01));
    }

    /// <summary>
    /// 計算 BMI 有效輸入 預期結果 拋出除以零例外
    /// </summary>
    [Test]
    public void When_Calculator_BMI_ZeroHeight_Expected_ThrowsDivideByZeroException()
    {
        // Arrange
        // 體重
        double weight = 70;
        // 身高為零
        double height = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculatorService.BMI(weight, height));
    }

    /// <summary>
    /// 計算 BMI 體重為負數 預期結果 拋出參數超出範圍例外
    /// </summary>
    [Test]
    public void When_Calculator_BMI_NegativeWeight_Expected_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        double weight = -70;
        // 身高為零
        double height = 175;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => _calculatorService.BMI(weight, height));
    }
}
