using System.Diagnostics;

namespace SP2016.Repository.Mapping
{
    /// <summary>
    /// ������� ����� ������ SPListItem � ���������� ��������
    /// </summary>
    [DebuggerDisplay("F:{FieldName}, P:{EntityPropertyName}")]
    public class FieldToEntityPropertyMapping
    {
        #region ������������

        /// <summary>
        /// ����������� ������
        /// </summary>
        public FieldToEntityPropertyMapping() { }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="name">�������� ���� ������ � �������� ��������</param>
        public FieldToEntityPropertyMapping(string name)
            : this(name, name)
        { }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="name">�������� ���� ������ � �������� ��������</param>
        /// <param name="readOnly">��������� �� ��������� �������� �������� ��� ���������� ��������</param>
        public FieldToEntityPropertyMapping(string name, bool readOnly)
            : this(name, name, readOnly)
        { }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="fieldName">�������� ���� ������</param>
        /// <param name="entityPropertyName">�������� �������� ��������</param>
        public FieldToEntityPropertyMapping(string fieldName, string entityPropertyName)
        {
            this.FieldName = fieldName;
            this.EntityPropertyName = entityPropertyName;
        }

        /// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="fieldName">�������� ���� ������</param>
        /// <param name="entityPropertyName">�������� �������� ��������</param>
        /// <param name="readOnly">��������� �� ��������� �������� �������� ��� ���������� ��������</param>
        public FieldToEntityPropertyMapping(string fieldName, string entityPropertyName, bool readOnly)
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
