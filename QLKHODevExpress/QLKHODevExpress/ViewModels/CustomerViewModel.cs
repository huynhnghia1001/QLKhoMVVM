using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKHODevExpress.Model;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Xpf;
using Object = QLKHODevExpress.Model.Object;

namespace QLKHODevExpress.ViewModels
{
    public class CustomerViewModel : Utilities.ViewModelBase
    {
        QuanLyKhoEntities _Context;
        IList<Object> _ItemsSource;
        public IList<Object> ItemsSource
        {
            get
            {
                if (_ItemsSource == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context = new QuanLyKhoEntities();
                    _ItemsSource = _Context.Objects.ToList();
                }
                return _ItemsSource;
            }
        }

        void ValidateRow(RowValidationArgs args)
        {
            var item = (Object)args.Item;
            if (args.IsNewItem)
                _Context.Objects.Add(item);
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
            var item = (Object)args.Items.Single();
            _Context.Objects.Remove(item);
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
        QuanLyKhoEntities _Context1;
        IList<Customer> _ItemsSource1;
        public IList<Customer> ItemsSource1
        {
            get
            {
                if (_ItemsSource1 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context1 = new QuanLyKhoEntities();
                    _ItemsSource1 = _Context1.Customers.ToList();
                }
                return _ItemsSource1;
            }
        }

        void ValidateRow1(RowValidationArgs args)
        {
            var item = (Customer)args.Item;
            if (args.IsNewItem)
                _Context1.Customers.Add(item);
            _Context1.SaveChanges();
        }
        ICommand _ValidateRowCommandCommand1;
        public ICommand ValidateRowCommandCommand1
        {
            get
            {
                if (_ValidateRowCommandCommand1 == null)
                {
                    _ValidateRowCommandCommand1 = new DelegateCommand<RowValidationArgs>(ValidateRow1);
                }
                return _ValidateRowCommandCommand1;
            }
        }

        void ValidateRowDeletion1(ValidateRowDeletionArgs args)
        {
            var item = (Customer)args.Items.Single();
            _Context1.Customers.Remove(item);
            _Context1.SaveChanges();
        }
        ICommand _ValidateRowDeletionCommandCommand1;
        public ICommand ValidateRowDeletionCommandCommand1
        {
            get
            {
                if (_ValidateRowDeletionCommandCommand1 == null)
                {
                    _ValidateRowDeletionCommandCommand1 = new DelegateCommand<ValidateRowDeletionArgs>(ValidateRowDeletion1);
                }
                return _ValidateRowDeletionCommandCommand1;
            }
        }

        void DataSourceRefresh1(DataSourceRefreshArgs args)
        {
            _ItemsSource1 = null;
            _Context1 = null;
            OnPropertyChanged(nameof(ItemsSource1));
        }
        ICommand _DataSourceRefreshCommandCommand1;
        public ICommand DataSourceRefreshCommandCommand1
        {
            get
            {
                if (_DataSourceRefreshCommandCommand1 == null)
                {
                    _DataSourceRefreshCommandCommand1 = new DelegateCommand<DataSourceRefreshArgs>(DataSourceRefresh1);
                }
                return _DataSourceRefreshCommandCommand1;
            }
        }
    }
}
