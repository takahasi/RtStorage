using System;
using System.Collections.Generic;

namespace RtStorage.Models
{
    public interface IRecordDescriptionRepository
    {
        IEnumerable<RecordDescription> GetRecordDescriptions(SearchCondition param);

        /// <summary>
        /// DataType�̈ꗗ���擾����B
        /// </summary>
        IEnumerable<string> GetDataTypes(string componentType, string portName);

        /// <summary>
        /// ComponentType�̈ꗗ���擾����
        /// </summary>
        IEnumerable<string> GetComponentTypes(string dataType, string portName);

        IEnumerable<string> GetPortNames(string dataType, string componentType);
        void Insert(RecordDescription data);

        /// <summary>
        /// �f�[�^�x�[�X�̓��e������������B
        /// </summary>
        void Clear();

    }

    /// <summary>
    /// Select���\�b�h�Ō�������Ƃ��̏����B
    /// null�ɐݒ肵���t�B�[���h�͌��������Ɋ܂߂Ȃ�
    /// </summary>
    public class SearchCondition
    {
        public SearchCondition()
        {
            DataType = null;
            ComponentType = null;
            PortName = null;
            StartDateTime = null;
            EndDateTime = null;
        }

        public string DataType { get; set; }
        public string ComponentType { get; set; }
        public string PortName { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}