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
    /// �p�� BMI ���Ŀ�J �w�����G ���T��BMI
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
        // �|�ˤ��J��p�ƲĤG
        Assert.That(result, Is.EqualTo(22.86).Within(0.01));
    }

    /// <summary>
    /// �p�� BMI ���Ŀ�J �w�����G �ߥX���H�s�ҥ~
    /// </summary>
    [Test]
    public void When_Calculator_BMI_ZeroHeight_Expected_ThrowsDivideByZeroException()
    {
        // Arrange
        // �魫
        double weight = 70;
        // �������s
        double height = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculatorService.BMI(weight, height));
    }

    /// <summary>
    /// �p�� BMI �魫���t�� �w�����G �ߥX�ѼƶW�X�d��ҥ~
    /// </summary>
    [Test]
    public void When_Calculator_BMI_NegativeWeight_Expected_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        double weight = -70;
        // �������s
        double height = 175;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => _calculatorService.BMI(weight, height));
    }
}
