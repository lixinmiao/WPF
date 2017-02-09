/* ==============================================================================
 * 功能描述：MediaDetailViewModel  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/6 14:37:21
 * ==============================================================================*/
using Infrastructure.Business;
using Infrastructure.Events;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MediaLibrary.ViewModel
{
    [Export]
    /// <summary>
    /// MediaDetailViewModel
    /// </summary>
    public class MediaDetailViewModel: NotificationObject
    {
        private IEventAggregator eventAggregator;
        [ImportingConstructor]
        public MediaDetailViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<ViewMediaDetailEvent>().Subscribe(this.ViewMediaDetail, ThreadOption.UIThread);
        }

        private bool isEditMode = false;
        public bool IsEditMode
        {
            get
            {
                return isEditMode;
            }

            set
            {
                isEditMode = value;RaisePropertyChanged(()=> this.IsEditMode);
            }
        }

        private FileItem fileItem;

        public FileItem FileItem
        {
            get
            {
                return fileItem;
            }

            set
            {
                fileItem = value;RaisePropertyChanged(() => FileItem);
            }
        }

       

        private void ViewMediaDetail(FileItem fileItem)
        {
            //MessageBox.Show(fileItem.FileName);
            this.FileItem = fileItem;
        }
        private DelegateCommand editCommand;
        public ICommand EditCommand
        {
            get
            {
                if (editCommand == null)
                {
                    editCommand = new DelegateCommand(editCommandExcute);
                }
                return editCommand;
            }
        }
        private void editCommandExcute()
        {
            IsEditMode = true;
        }

        private DelegateCommand cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (cancelCommand == null)
                {
                    cancelCommand = new DelegateCommand(cancelCommandExcute);
                }
                return cancelCommand;
            }
        }
        private void cancelCommandExcute()
        {
            IsEditMode = false;
        }

        private DelegateCommand<String> saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new DelegateCommand<String>(saveCommandExcute);
                }
                return saveCommand;
            }
        }
        private void saveCommandExcute(String filename)
        {
            IsEditMode = false;
            this.FileItem.FileName = filename;
            eventAggregator.GetEvent<SaveMediaDetailEvent>().Publish(this.FileItem);
        }
    }
}