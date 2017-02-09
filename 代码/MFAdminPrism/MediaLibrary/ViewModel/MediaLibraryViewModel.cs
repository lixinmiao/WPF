/* ==============================================================================
 * 功能描述：MediaLibraryViewModel  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/3 12:03:27
 * ==============================================================================*/
using Infrastructure.Business;
using Infrastructure.Business.EnumType;
using Infrastructure.Controls;
using Infrastructure.Events;
using MediaLibrary.View;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MediaLibrary.ViewModel
{
    [Export]
    /// <summary>
    /// MediaLibraryViewModel
    /// </summary>
    public class MediaLibraryViewModel : NotificationObject
    {
        private Boolean isThumb=true;
        public Boolean IsThumb
        {
            get
            {
                return isThumb;
            }

            set
            {
                isThumb = value; RaisePropertyChanged(() => this.IsThumb);
            }
        }

        private ObservableCollection<FileItem> folderItemList = new ObservableCollection<FileItem>();
        public ObservableCollection<FileItem> FolderItemList
        {
            get
            {
                
                return folderItemList;
            }
            set
            {

                folderItemList = value; RaisePropertyChanged(() => this.FolderItemList);
            }
        }
        private ObservableCollection<FileItem> fileItemList = new ObservableCollection<FileItem>();
        public ObservableCollection<FileItem> FileItemList
        {
            get
            {

                return fileItemList;
            }
            set
            {

                fileItemList = value; RaisePropertyChanged(() => this.FileItemList);
            }
        }

        private List<FileItem> fileList = new List<FileItem>();
        private List<FileItem> folderList = new List<FileItem>();
        private Dictionary<int, List<FileItem>> folder_fileItemList = new Dictionary<int, List<FileItem>>();
        private int CurrentFolderIndex = 1;
      
        private IEventAggregator eventAggregator;
        [ImportingConstructor]
        public MediaLibraryViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<SaveMediaDetailEvent>().Subscribe(this.saveFileItem);
            InitFileItems();
        }
        private  void InitFileItems()
        {
     
            FileItem folderItem = new FileItem();
            folderItem.Index = 1;
            folderItem.ParentId = 0;
            folderItem.FileType = FileItemType.Folder;
            folderItem.FileName = "MediaLibrary";
            folderItem.Image = "pack://application:,,,/Infrastructure;component/Resources/Images/folder.png";
            folderList.Add(folderItem);
            fileList.Add(folderItem);
            folder_fileItemList.Add(folderItem.Index, new List<FileItem>());

            List<FileItem> rootChidrenFiles = new List<FileItem>();
            for (int i = 1; i <= 5; i++)
            {
                folderItem = new FileItem();
                folderItem.Index = fileList.Count + 1;
                folderItem.ParentId = 1;
                folderItem.FileType = FileItemType.Folder;
                folderItem.FileName = "Folder " +(fileList.Count + 1);
                folderItem.Image = "pack://application:,,,/Infrastructure;component/Resources/Images/folder.png";
                folderList.Add(folderItem);
                fileList.Add(folderItem);
                rootChidrenFiles.Add(folderItem);
                folder_fileItemList.Add(folderItem.Index, new List<FileItem>());
            }
            folder_fileItemList[1] = rootChidrenFiles;



            FileItemType[] filetypes = Enum.GetValues(typeof(FileItemType)) as FileItemType[];

            Int32[] keys=folder_fileItemList.Keys.ToArray();
            foreach (int folderId in keys)
            {
                List<FileItem> chidrenFiles = new List<FileItem>();
                for (int i = 0; i < filetypes.Length; i++)
                {
                    FileItem file = new FileItem();
                    file.Index = fileList.Count+1;
                    file.ParentId = folderId;
                    file.FileType = filetypes[i];
                    file.FileName = filetypes[i].ToString() + "_" + (fileList.Count+1);
                    file.Image = "pack://application:,,,/Infrastructure;component/Resources/Images/" + filetypes[i].ToString().ToLower() + ".png";
                    chidrenFiles.Add(file);
                    fileList.Add(file);
                    if (file.FileType.Equals(FileItemType.Folder))
                    {
                        folderList.Add(file);
                        folder_fileItemList.Add(file.Index, new List<FileItem>());
                    }
                }
                folder_fileItemList[folderId].AddRange(chidrenFiles);
            }
            //当前
            FolderItemList.Add(folderList.First());
            CurrentFolderIndex = folderList.First().Index;
            FileItemList = new ObservableCollection<FileItem>(folder_fileItemList[CurrentFolderIndex]);

        }

        private DelegateCommand<int?> breadCrumbItemClickCommand;
        public ICommand BreadCrumbItemClickCommand
        {
            get
            {
                if (breadCrumbItemClickCommand == null)
                {
                    breadCrumbItemClickCommand = new DelegateCommand<int?>(breadCrumbItemClickCommandExcute);
                }
                return breadCrumbItemClickCommand;
            }

        }

        private void breadCrumbItemClickCommandExcute(int? index)
        {
            int folderIndex = index.Value;
            if (CurrentFolderIndex != folderIndex)
            {
                FolderItemList.Clear();
                FileItemList.Clear();

                int folderId = folderIndex;
                List<FileItem> folderItems = new List<FileItem>();

                while (folderId > 0)
                {
                    var folders = from folder in folderList where folder.Index == folderId select folder;
                    FileItem folderItem = folders.First();
                    folderItems.Add(folderItem);
                    folderId = folderItem.ParentId;
                }
                folderItems.Reverse();
                FolderItemList = new ObservableCollection<FileItem>(folderItems);
                CurrentFolderIndex = folderIndex;

                List<FileItem> files = folder_fileItemList[folderIndex];
                foreach (var fileitem in files)
                {
                    fileitem.IsFileSelected = false;
                }
                FileItemList = new ObservableCollection<FileItem>(files);
            }


        }


        private DelegateCommand<int?> viewDetailCommand;
        public ICommand ViewDetailCommand
        {
            get
            {
                if (viewDetailCommand == null)
                {
                    viewDetailCommand = new DelegateCommand<int?>(viewDetailCommandExcute);
                }
                return viewDetailCommand;
            }
        }

        private void viewDetailCommandExcute(int? index)
        {
            int fileIndex = index.Value;

            var files = from file in this.fileItemList.ToArray() where file.Index == fileIndex select file;
            FileItem fileItem = files.First();
            fileItem.IsFileSelected = !fileItem.IsFileSelected;

            if (fileItem.FileType.Equals(FileItemType.Folder))
            {
                FolderItemList.Clear();
                FileItemList.Clear();

                int folderId = fileIndex;
                List<FileItem> folderItems = new List<FileItem>();
              
                while (folderId>0)
                {
                    var folders = from folder in folderList where folder.Index == folderId select folder;
                    FileItem folderItem = folders.First();
                    folderItems.Add(folderItem);
                    folderId = folderItem.ParentId;
                }
                folderItems.Reverse();
                FolderItemList = new ObservableCollection<FileItem>(folderItems);
                CurrentFolderIndex = fileIndex;

                files = folder_fileItemList[fileIndex];
                foreach (var fileitem  in files)
                {
                    fileitem.IsFileSelected = false;
                }
                FileItemList = new ObservableCollection<FileItem>(files);
               
            }
            else
            { 
                PopUpWindow popUpWindow = new PopUpWindow();
                popUpWindow.Width = 350;
                popUpWindow.Height = 300;
                MediaDetailView mediaDetailView = ServiceLocator.Current.GetInstance<MediaDetailView>();
                popUpWindow.SetUserControlShow(mediaDetailView);
                this.eventAggregator.GetEvent<ViewMediaDetailEvent>().Publish(fileItem);
                popUpWindow.Show();
               

            }
        }


        private DelegateCommand<int?> selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new DelegateCommand<int?>(selectCommandExcute);
                }
                return selectCommand;
            }
        }

       

        private void selectCommandExcute(int? index)
        {
            int fileIndex = index.Value;

            var files = from file in this.fileItemList.ToArray() where file.Index == fileIndex select file;
            FileItem fileItem = files.First();
            fileItem.IsFileSelected = !fileItem.IsFileSelected;
        }



        private DelegateCommand viewModeChangedCommand;
        public ICommand ViewModeChangedCommand
        {
            get
            {
                if (viewModeChangedCommand == null)
                {
                    viewModeChangedCommand = new DelegateCommand(viewModeChangedCommandExcute);
                }
                return viewModeChangedCommand;
            }

        }

        private void viewModeChangedCommandExcute()
        {
            if(this.isThumb)
            {

            }
            else
            {

            }
        }

        
        /// <summary>
        /// listview
        /// </summary>
        private DelegateCommand<int?> checkedCommand;
        public ICommand CheckedCommand
        {
            get
            {
                if (checkedCommand == null)
                {
                    checkedCommand = new DelegateCommand<int?>(checkedCommandExcute);
                }
                return checkedCommand;
            }

        }

      
        private void checkedCommandExcute(int? index)
        {
            int fileIndex = index.Value;

            var files = from file in this.fileItemList.ToArray() where file.Index == fileIndex select file;
            FileItem fileItem = files.First();
            fileItem.IsFileSelected =true;
        }


        private DelegateCommand<int?> uncheckedCommand;
        public ICommand UncheckedCommand
        {
            get
            {
                if (uncheckedCommand == null)
                {
                    uncheckedCommand = new DelegateCommand<int?>(uncheckedCommandExcute);
                }
                return uncheckedCommand;
            }

        }



        private void uncheckedCommandExcute(int? index)
        {
            int fileIndex = index.Value;

            var files = from file in this.fileItemList.ToArray() where file.Index == fileIndex select file;
            FileItem fileItem = files.First();
            fileItem.IsFileSelected = false;
        }


        private void saveFileItem(FileItem fileItem)
        {
            var files = from file in this.fileItemList.ToArray() where file.Index == fileItem.Index select file;
            FileItem fileSaved = files.First();
            fileSaved = fileItem;
        }
    }
}