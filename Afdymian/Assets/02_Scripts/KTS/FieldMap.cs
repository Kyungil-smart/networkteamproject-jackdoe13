using UnityEngine;

public class FieldMap : MonoBehaviour
{
    
    [System.Serializable]
    public class Field
    {
        public int index;
        public string fieldName;
        public int cost;
        
        public Field(int fieldIndex)
        {
            index = fieldIndex;
            fieldName = "Field " + fieldIndex;
            cost = 0;
        }
    }

    private const int fieldCount = 12;

    public Field[] fields = new Field[fieldCount];

    private void Start()
    {
        InitializeFields();
    }
    
    private void InitializeFields()
    {
        for (int i = 0; i < fieldCount; i++)
        {
            fields[i] = new Field(i);
        }

        Debug.Log("필드가 생성되었습니다.");
    }
    
    public Field GetField(int index)
    {
        if (index < 0 || index >= fieldCount)
        {
            Debug.LogWarning("잘못된 필드 인덱스입니다: " + index);
            return null;
        }

        return fields[index];
    }
}