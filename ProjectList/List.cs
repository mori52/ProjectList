using System;
using System.Linq;

namespace ProjectList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        //23. 3 конструктора(пустой, на основе одного элемента, на основе массива )

        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }

        public ArrayList(int value)
        {
            Length = 1;

            _array = new int[10];
            _array[0] = value;
        }

        public ArrayList(int[] inputArray)
        {
            Length = inputArray.Length;
            _array = new int[(int)(inputArray.Length * 1.33 + 1)];

            for (int i = 0; i< inputArray.Length; i++)
            {
                _array[i] = inputArray[i];
            }
        }


        public void Add(int value)
        {
            //1. Добавление значения в конец

            if (Length==_array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddToTheBeggining(int value)
        {
            //2. Добавление значения в начало

            if (Length == _array.Length)
            {
                UpSize();
            }


            for (int i = Length - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[0] = value;

            Length++;
        }

        public void AddByIndex(int value, int index)
        {
            //3. Добавление значения по индексу

            if (Length == _array.Length)
            {
                UpSize();
            }

            

            for (int i = Length-1; i >= index; i--)
            {
                _array[i+1] = _array[i];
            }

            _array[index] = value;

            Length++;
        }

        public void RemoveLastElement()
        {
            //4. Удаление из конца одного элемента

            Length--;

            if (Length <= (_array.Length/2))
            {
                DownSize();
            }
        }

        public void RemoveFirstElement()
        {
            //5. Удаление из начала одного элемента

            for (int i = 1; i < Length; i++)
            {
                _array[i-1] = _array[i];
            }

            Length--;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public void RemoveElementByIndex(int index)
        {
            //6. Удаление по номеру индекса


            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i+1];
            }

            Length--;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public void RemoveNLastElements(int N)
        {
            //7. Удаление из конца N элементов

            for (int i = 0; i<=_array.Length-N;i++)
            {
                _array[i] = _array[i];
            }

            Length = Length - N;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public void RemoveNFirstElements(int N)
        {
            //8. Удаление из начала N элементов

            for (int i = N; i < Length; i++)
            {
                _array[i-N] = _array[i];
            }

            Length -= N;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public void RemoveNElementsByIndex(int N, int index)
        {
            //9. Удаление N элементов по индексу

            for (int i = index; i < Length - N; i++)
            {
                _array[i] = _array[i + N];
            }

            Length = Length-N;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public int GetElementByIndex(int index)
        {
            //11. доступ по индексу
            
                return _array[index];
        }

        public int GetIndexOfElement(int x)
        {
            //12. первый индекс по значению


            int index = -1;

            for (int i=0; i<_array.Length; i++)
            {
                if (_array[i]==x)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void ChangeIndexN(int N, int x)
        {
            //13. Изменение по индексу

            _array[N] = x;

        }

        public void Reverse()
        {
            //14. Pеверс (123 -> 321)

            int tmpArray;

            for (int i=0;i<(Length/2); i++)
            {
                tmpArray = _array[i];
                int x = Length - i - 1;
                _array[i] = _array[x];
                _array[x] = tmpArray;
            }

        }

        public int SearchMaxValue()
        {
            //15. Поиск значения максимального элемента

            int maxValue =_array[0];

            for (int i=0; i<_array.Length; i++)
            {
                if (maxValue < _array[i])
                {
                    maxValue = _array[i];
                }
            }

            return maxValue;
        }

        public int SearchMinValue()
        {
            //16. Поиск значения минимального элемента

            int minValue = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                if (minValue > _array[i])
                {
                    minValue = _array[i];
                }
            }
            return minValue;
        }

        public int SearchIndexOfMaxValue()
        {
            //17. Поиск индекса максимального элемента

            int maxValue = _array[0];
            int indexOfMaxValue = 0;

            for (int i = 0; i < Length; i++)
            {
                if (maxValue <= _array[i])
                {
                    maxValue = _array[i];
                    indexOfMaxValue = i;
                }
            }
            return indexOfMaxValue;
        }

        public int SearchIndexOfMinValue()
        {
            //18. Поиск индекса минимального элемента

            int minValue = _array[0];
            int indexOfMinValue = 0;

            for (int i = 0; i < Length; i++)
            {
                if (minValue > _array[i])
                {
                    minValue = _array[i];
                    indexOfMinValue = i;
                }
            }
            return indexOfMinValue;
        }

        public void SortingByIncrease()
        {
            //19. Сортировка по возрастанию

            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        int tmp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }

        }

        public void SortingByDecrease()
        {
            //20. Сортировка по убыванию

            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        int tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public int RemoveElementX(int x)
        {
            //21. Удаление по значению первого --> вернуть его индекс

            int a = GetIndexOfElement(x);
            RemoveElementByIndex(a);
            return a;

        }



        public int RemoveAllElementsX(int x)
        {
            //22. Удаление по значению всех --> вернуть их количество

            int kol = 0;

            for (int i = 0; i < Length; i++)
            {
                
                int a = GetIndexOfElement(x);
                RemoveElementByIndex(a); 
                kol++;
                
            }


            return kol;

        }



        //public void AddList(ArrayList newList)
        //{
        //    //24. добавление списка(вашего самодельного) в конец

        //    for (int i = 0; i < newList.Length; i++)
        //    {
        //        Add(newList[i]);
        //        Add(newList._array[i]);
        //    }

        //public void AddListToTheBegin(ArrayList newList)
        //{
        //    //25. добавление списка в начало

        //    for (int i = 0; i < newList.Length; i++)
        //    {
        //        Add(newList[i]);
        //        Add(newList._array[0]);
        //    }

        //}

        //public void AddListByIndex()
        //{
        //    //26. добавление списка по индексу
        //}




        //public override string ToString()
        //{
        //    return string.Join(";", _array.Take(Length));
        //}

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (this.Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33 + 1);

            int[] tmpArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void DownSize()
        {
            int newLength = (int)(_array.Length * 0.66 + 1);

            int[] tmpArray = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void ReturnTheError(int index)
        {
            // Вызов ошибки IndexOutOfRangeException

            if (index > _array.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void MakeArrayToLeft(int index, int n)
        {
            //Сдвиг массив на n позиций влево
            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i-n];
            }
        }

        private void MakeArrayToRight(int index, int n)
        {
            //Сдвиг массив на n позиций вправо
            for (int i = index; i < Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
        }
    }
}