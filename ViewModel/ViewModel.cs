using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LicenseGenerator.ViewModel
{
    /// <summary>
    /// ViewModel基类，实现了INotifyPropertyChanged接口
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// 更改属性值并发出通知
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">属性对应的字段</param>
        /// <param name="newValue">更新的值</param>
        /// <param name="propertyName"></param>
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }

            OnPropertyChanging(propertyName);

            field = newValue;

            OnPropertyChanged(propertyName);

            return true;
        }

        protected void OnPropertyChanging(string propertyName)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
