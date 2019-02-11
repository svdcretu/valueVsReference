using System;


namespace ValueReference.ValueTypesExamples
{
    public class BaseValueTypes
    {
        public void ValueTypeAssignation()
        {
            int x = 10;
            int y = x;
            y = y * 10;

            Console.WriteLine($" ValueTypeAssignation X = {x}, Y = {y}");
        }

        public void ValueTypePassBetweenFunctions()
        {
            int x = 10;
            int valueToAdd = 25;

            IncrementValue1(x);
            IncrementValue2(valueToAdd);

            AddToValue(x, valueToAdd);


            Console.WriteLine($" ValueTypeAssignation X = {x}, valueToAdd = {valueToAdd}");
        }

        public void ValueTypePassBetweenFunctionsWithResult()
        {
            int x = 14;
            int y = x;
            int result = 3;

            IncrementValue1(x);
            IncrementValue1(y);
            y = IncrementValue2(y);

            AddToValue(y, result);

            result = AddToValue(x, y);

            Console.WriteLine($" ValueTypePassBetweenFunctionsWithResult X = {x}, y = {y} result(x+y) = {result}");
        }

        private int AddToValue(int x, int valueToAdd)
        {
            x = x + valueToAdd;

            return x;
        }

        private int IncrementValue1(int x)
        {
            x += 1;
            return x;
        }

        private int IncrementValue2(int valueToIncrement)
        {
            valueToIncrement++;

            return valueToIncrement;
        }
    }
}
