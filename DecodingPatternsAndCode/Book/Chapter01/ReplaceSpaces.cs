using System;

namespace DecodingPatternsAndCode.Tests.Book.Chapter01
{
    public static class ReplaceSpaces
    {
        public static void ReplaceSpacesBase(ref char[] arr, int trueLength)
        {
            int spacesCount = 0, i;
            for (i = 0; i < trueLength; i++)
            {
                if (arr[i] == ' ')
                {
                    spacesCount++;
                }
            }
            var index = trueLength + spacesCount * 2;

            Array.Resize(ref arr, index);

            if (trueLength < arr.Length) arr[trueLength] = '\0'; // End array

            for (i = trueLength - 1; i >= 0; i--)
            {
                if (arr[i] == ' ')
                {
                    arr[index - 1] = '0';
                    arr[index - 2] = '2';
                    arr[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    arr[index - 1] = arr[i];
                    index--;
                }
            }
        }

    }
}