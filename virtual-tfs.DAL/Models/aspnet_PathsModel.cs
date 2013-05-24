//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using VirtualTFS.DAL;

namespace VirtualTFS.DAL.Models
{
    /// <summary>
    /// Model for table aspnet_Paths 
    /// </summary>
    public partial class aspnet_PathsModel 
    {
        #region Ctor

        // Default contructor
        public aspnet_PathsModel()
        {
            this.IsNewItem = true;
            this._aspnet___paths = new aspnet_Paths();
        }

        // Default contructor that set entity to field
        public aspnet_PathsModel(aspnet_Paths aspnet_paths)
        {
        	this._aspnet___paths = aspnet_paths;
            this._application_id = aspnet_paths.ApplicationId;
            this._path_id = aspnet_paths.PathId;
            this._path = aspnet_paths.Path;
            this._lowered_path = aspnet_paths.LoweredPath;
            this._originalaspnet_Paths = aspnet_paths.DeepClone();
        }

        #endregion


        #region Entity Properties

        
        public event EventHandler PropertyChanged;
        private aspnet_Paths _aspnet___paths;
        private aspnet_Paths _originalaspnet_Paths;
        
        public aspnet_Paths Mapaspnet_Paths()
        {
            this._aspnet___paths.ApplicationId = this._application_id;
            this._aspnet___paths.PathId = this._path_id;
            this._aspnet___paths.Path = this._path;
            this._aspnet___paths.LoweredPath = this._lowered_path;
        	return _aspnet___paths;
        }
        
        public void Undo()
        {
            if(this._originalaspnet_Paths == null) return;
            this._application_id = this._originalaspnet_Paths.ApplicationId;
            this._path_id = this._originalaspnet_Paths.PathId;
            this._path = this._originalaspnet_Paths.Path;
            this._lowered_path = this._originalaspnet_Paths.LoweredPath;
        	this.Commit();
        }
        
        public void Reload()
        {
        	if(this._originalaspnet_Paths == null) return;
            this._aspnet___paths.ApplicationId = this._originalaspnet_Paths.ApplicationId;
            this._aspnet___paths.PathId = this._originalaspnet_Paths.PathId;
            this._aspnet___paths.Path = this._originalaspnet_Paths.Path;
            this._aspnet___paths.LoweredPath = this._originalaspnet_Paths.LoweredPath;
        }
        

        public bool IsNewItem { get; private set; }
        public bool IsDeleted { get; set; }
        public bool IsChecked { get; set; }
        
        private bool _isDirty;
        public bool IsDirty
        {
            get
            {
                return _isDirty;
            }
            private set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new EventArgs());
                }
            }
        }
        
        public void Commit() {
        	IsNewItem = false;
        	IsDirty = false;
        }

        #endregion


        #region Primitive Properties

        
        private System.Guid _application_id;
        public System.Guid ApplicationId
        {
            get { return this._application_id; }
            set
            {
                if (this._application_id != value)
                {
                    this.IsDirty = true;
                    this._application_id = value;
                }
            }
        }
        
        private System.Guid _path_id;
        public System.Guid PathId
        {
            get { return this._path_id; }
            set
            {
                if (this._path_id != value)
                {
                    this.IsDirty = true;
                    this._path_id = value;
                }
            }
        }
        
        private string _path;
        public string Path
        {
            get { return this._path; }
            set
            {
                if (this._path != value)
                {
                    this.IsDirty = true;
                    this._path = value;
                }
            }
        }
        
        private string _lowered_path;
        public string LoweredPath
        {
            get { return this._lowered_path; }
            set
            {
                if (this._lowered_path != value)
                {
                    this.IsDirty = true;
                    this._lowered_path = value;
                }
            }
        }

        #endregion


        #region all the custom code


        #endregion

    }
}