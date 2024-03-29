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
    /// Model for table aspnet_SchemaVersions 
    /// </summary>
    public partial class aspnet_SchemaVersionsModel 
    {
        #region Ctor

        // Default contructor
        public aspnet_SchemaVersionsModel()
        {
            this.IsNewItem = true;
            this._aspnet___schema_versions = new aspnet_SchemaVersions();
        }

        // Default contructor that set entity to field
        public aspnet_SchemaVersionsModel(aspnet_SchemaVersions aspnet_schemaversions)
        {
        	this._aspnet___schema_versions = aspnet_schemaversions;
            this._feature = aspnet_schemaversions.Feature;
            this._compatible_schema_version = aspnet_schemaversions.CompatibleSchemaVersion;
            this._is_current_version = aspnet_schemaversions.IsCurrentVersion;
            this._originalaspnet_SchemaVersions = aspnet_schemaversions.DeepClone();
        }

        #endregion


        #region Entity Properties

        
        public event EventHandler PropertyChanged;
        private aspnet_SchemaVersions _aspnet___schema_versions;
        private aspnet_SchemaVersions _originalaspnet_SchemaVersions;
        
        public aspnet_SchemaVersions Mapaspnet_SchemaVersions()
        {
            this._aspnet___schema_versions.Feature = this._feature;
            this._aspnet___schema_versions.CompatibleSchemaVersion = this._compatible_schema_version;
            this._aspnet___schema_versions.IsCurrentVersion = this._is_current_version;
        	return _aspnet___schema_versions;
        }
        
        public void Undo()
        {
            if(this._originalaspnet_SchemaVersions == null) return;
            this._feature = this._originalaspnet_SchemaVersions.Feature;
            this._compatible_schema_version = this._originalaspnet_SchemaVersions.CompatibleSchemaVersion;
            this._is_current_version = this._originalaspnet_SchemaVersions.IsCurrentVersion;
        	this.Commit();
        }
        
        public void Reload()
        {
        	if(this._originalaspnet_SchemaVersions == null) return;
            this._aspnet___schema_versions.Feature = this._originalaspnet_SchemaVersions.Feature;
            this._aspnet___schema_versions.CompatibleSchemaVersion = this._originalaspnet_SchemaVersions.CompatibleSchemaVersion;
            this._aspnet___schema_versions.IsCurrentVersion = this._originalaspnet_SchemaVersions.IsCurrentVersion;
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

        
        private string _feature;
        public string Feature
        {
            get { return this._feature; }
            set
            {
                if (this._feature != value)
                {
                    this.IsDirty = true;
                    this._feature = value;
                }
            }
        }
        
        private string _compatible_schema_version;
        public string CompatibleSchemaVersion
        {
            get { return this._compatible_schema_version; }
            set
            {
                if (this._compatible_schema_version != value)
                {
                    this.IsDirty = true;
                    this._compatible_schema_version = value;
                }
            }
        }
        
        private bool _is_current_version;
        public bool IsCurrentVersion
        {
            get { return this._is_current_version; }
            set
            {
                if (this._is_current_version != value)
                {
                    this.IsDirty = true;
                    this._is_current_version = value;
                }
            }
        }

        #endregion


        #region all the custom code


        #endregion

    }
}
