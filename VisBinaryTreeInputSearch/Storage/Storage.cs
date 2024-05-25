using System.Text;
using System.IO;
using System.Text.Json;
using VisBinaryTreeInputSearch.BinaryTreeP;
using System.Diagnostics;


namespace VisBinaryTreeInputSearch.StorageConditons
{
    public class Storage
    {
        private readonly string saveFileKey = "CondtionsFile";      


        private List<ConditionOfTree> _storage;
        public int _choosenConditionIndex { get; private set; }

        public Storage()
        {
            _storage = new List<ConditionOfTree>();
            _choosenConditionIndex = _storage.Count - 1;
        }

        public int GetSize() { return _storage.Count; }

        public ConditionOfTree GetNextCondtion()
        {
            if (_choosenConditionIndex < _storage.Count - 1)
            {
                _choosenConditionIndex++;
            } 
            return _storage[_choosenConditionIndex];
        }

        public ConditionOfTree GetPreviusCondition()
        {
            if (_choosenConditionIndex > 0) 
            {
                _choosenConditionIndex--;
            }
            return _storage[_choosenConditionIndex];
        }

        public ConditionOfTree SetNullPosition()
        {
            if (_storage.Count == 0)
            {
                return null;
            }
            _choosenConditionIndex = 0;
            return _storage[_choosenConditionIndex];
        }

        public ConditionOfTree SetLastPostion()
        {
            if (_storage.Count == 0)
            {
                return null;
            }
            _choosenConditionIndex = _storage.Count - 1;
            return _storage[_choosenConditionIndex];
        }

        public void addCondition(ConditionOfTree condition) 
        {
            if (_choosenConditionIndex == -1)
            {
                _choosenConditionIndex++;
            }
            _storage.Add(condition);
        }

        public ConditionOfTree GetCurrent()
        {
            if (_storage.Count == 0)
            {
                return null;
            }
            return _storage[_choosenConditionIndex];
        }


        public void SaveConditions(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(saveFileKey);
            for (int i = 0; i < _storage.Count; i++)
            {
                sb.AppendLine(JsonSerializer.Serialize(_storage[i]));
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        public bool LoadConditions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            _storage.Clear();
            _choosenConditionIndex = -1;
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8)) 
            {
                if(streamReader.ReadLine() != saveFileKey)
                {
                    return false;
                }
                string? data = "";
                data = streamReader.ReadLine();
                ConditionOfTree? conditionOfTree = null;
                while (data != null) 
                {
                   
                    conditionOfTree = JsonSerializer.Deserialize<ConditionOfTree>(data);
                    
                    
                    if (conditionOfTree != null)
                    {
                        this.addCondition(conditionOfTree);
                    }
                    data = streamReader.ReadLine();
                }
                return true;
            }
        }
    }
}
