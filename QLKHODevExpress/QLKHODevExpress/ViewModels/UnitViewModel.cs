using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKHODevExpress.Model;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Xpf;

namespace QLKHODevExpress.ViewModels
{
    public class UnitViewModel : Utilities.ViewModelBase
    {
        QuanLyKhoEntities _Context;
        IList<Unit> _ItemsSource;
        public IList<Unit> ItemsSource
        {
            get
            {
                if (_ItemsSource == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context = new QuanLyKhoEntities();
                    _ItemsSource = _Context.Units.ToList();
                }
                return _ItemsSource;
            }
        }
        void ValidateRow(RowValidationArgs args)
        {
            var item = (Unit)args.Item;
            if (args.IsNewItem)
                _Context.Units.Add(item);
            _Context.SaveChanges();
        }
        ICommand _ValidateRowCommandCommand;
        public ICommand ValidateRowCommandCommand
        {
            get
            {
                if (_ValidateRowCommandCommand == null)
                {
                    _ValidateRowCommandCommand = new DelegateCommand<RowValidationArgs>(ValidateRow);
                }
                return _ValidateRowCommandCommand;
            }
        }
        void ValidateRowDeletion(ValidateRowDeletionArgs args)
        {
            var item = (Unit)args.Items.Single();
            _Context.Units.Remove(item);
            _Context.SaveChanges();
        }
        ICommand _ValidateRowDeletionCommandCommand;
        public ICommand ValidateRowDeletionCommandCommand
        {
            get
            {
                if (_ValidateRowDeletionCommandCommand == null)
                {
                    _ValidateRowDeletionCommandCommand = new DelegateCommand<ValidateRowDeletionArgs>(ValidateRowDeletion);
                }
                return _ValidateRowDeletionCommandCommand;
            }
        }
        void DataSourceRefresh(DataSourceRefreshArgs args)
        {
            _ItemsSource = null;
            _Context = null;
            OnPropertyChanged(nameof(ItemsSource));
        }
        ICommand _DataSourceRefreshCommandCommand;
        public ICommand DataSourceRefreshCommandCommand
        {
            get
            {
                if (_DataSourceRefreshCommandCommand == null)
                {
                    _DataSourceRefreshCommandCommand = new DelegateCommand<DataSourceRefreshArgs>(DataSourceRefresh);
                }
                return _DataSourceRefreshCommandCommand;
            }
        }
    }
}
