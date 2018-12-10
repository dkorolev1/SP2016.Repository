using System.Diagnostics;

namespace SP2016.Repository.Mapping
{
    /// <summary>
    /// ������� ����� ������ SPListItem � ���������� ��������
    /// </summary>
    [DebuggerDisplay("F:{FieldName}, P:{EntityPropertyName}")]
    public class FieldToPropertyMapping
    {
        #region ������������
        
        /// <summary>
        /// ����������� ������
        /// </summary>
        public FieldToPropertyMapping() { }
     
        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="name">�������� ���� ������ � �������� ��������</param>
        public FieldToPropertyMapping(string name)
            : this(name, name) { }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="name">�������� ���� ������ � �������� ��������</param>
        /// <param name="readOnly">��������� �� ��������� �������� �������� ��� ���������� ��������</param>
        public FieldToPropertyMapping(string name, bool readOnly)
            : this(name, name, readOnly) { }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="fieldName">�������� ���� ������</param>
        /// <param name="entityPropertyName">�������� �������� ��������</param>
        public FieldToPropertyMapping(string fieldName, string entityPropertyName)
        {
            FieldName = fieldName;
            EntityPropertyName = entityPropertyName;
        }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="fieldName">�������� ���� ������</param>
        /// <param name="entityPropertyName">�������� �������� ��������</param>
        /// <param name="readOnly">��������� �� ��������� �������� �������� ��� ���������� ��������</param>
        public FieldToPropertyMapping(string fieldName, string entityPropertyName, bool readOnly)
            : this(fieldName, entityPropertyName)
        {
            ReadOnly = readOnly;
        }

        #endregion

        /// <summary>
        /// �������� ����
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// �������� �������� ��������
        /// </summary>
        public string EntityPropertyName { get; set; }

        /// <summary>
        /// ������� ���� "������ ��� ������"
        /// </summary>
        public bool ReadOnly { get; set; }
    }
}
