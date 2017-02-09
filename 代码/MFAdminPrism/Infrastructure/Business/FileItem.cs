/* ==============================================================================
 * 功能描述：FolderItem  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/3 14:49:20
 * ==============================================================================*/
using Infrastructure.Business.EnumType;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Infrastructure.Business
{
    /// <summary>
    /// FolderItem
    /// </summary>
    public class FileItem:NotificationObject
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {

                index = value; RaisePropertyChanged(() => this.Index);
            }
        }

        private int parentId;
        public int ParentId
        {
            get
            {
                return parentId;
            }

            set
            {
                parentId = value; RaisePropertyChanged(() => this.ParentId);
            }
        }

        private String fileName;
        public String FileName
        {
            get
            {
                return fileName;
            }
            set
            {

                fileName = value; RaisePropertyChanged(() => this.FileName);
            }
        }

        private FileItemType fileType;
      

        public FileItemType FileType
        {
            get
            {
                return fileType;
            }

            set
            {
                fileType = value; RaisePropertyChanged(() => this.FileType);
            }
        }

        private String image;
        public String Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value; RaisePropertyChanged(() => this.Image);
            }
        }

       

        private bool isFileSelected = false;
        public bool IsFileSelected
        {
            get
            {
                return isFileSelected;
            }

            set
            {
                isFileSelected = value; RaisePropertyChanged(() => this.IsFileSelected);
            }
        }

        public FileItem()
            : base()
        {
           
        }
    }
}