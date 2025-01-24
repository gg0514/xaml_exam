using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;


namespace hello_behind.model
{
  
    [AddINotifyPropertyChangedInterface]  // Fody 어트리뷰트
    internal class Sample
    {
        public string TextValue { get; set; }
    }
}


//namespace hello_behind.model
//{
//    internal class Sample : INotifyPropertyChanged
//    {
//        private string _textValue;
//        public string TextValue
//        {
//            get => _textValue;
//            set
//            {
//                if (_textValue != value)
//                {
//                    _textValue = value;
//                    OnPropertyChanged(nameof(TextValue));  // PropertyChanged 이벤트 호출
//                }
//            }
//        }
//        public event PropertyChangedEventHandler PropertyChanged;
//        protected virtual void OnPropertyChanged(string propertyName)
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//    }
//}

