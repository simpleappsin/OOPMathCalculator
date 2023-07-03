using OOPMathCalculator;

ICalculate squareManager = new SquareManager();
ICalculate triangleManager = new TriangleManager();
ICalculate sphereManager = new SpeherManager();

Calculator calc = new Calculator();
calc.DoCalculate(triangleManager);