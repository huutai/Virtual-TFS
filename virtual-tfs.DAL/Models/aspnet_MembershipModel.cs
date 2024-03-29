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
    /// Model for table aspnet_Membership 
    /// </summary>
    public partial class aspnet_MembershipModel 
    {
        #region Ctor

        // Default contructor
        public aspnet_MembershipModel()
        {
            this.IsNewItem = true;
            this._aspnet___membership = new aspnet_Membership();
        }

        // Default contructor that set entity to field
        public aspnet_MembershipModel(aspnet_Membership aspnet_membership)
        {
        	this._aspnet___membership = aspnet_membership;
            this._application_id = aspnet_membership.ApplicationId;
            this._user_id = aspnet_membership.UserId;
            this._password = aspnet_membership.Password;
            this._password_format = aspnet_membership.PasswordFormat;
            this._password_salt = aspnet_membership.PasswordSalt;
            this._mobile_pin = aspnet_membership.MobilePIN;
            this._email = aspnet_membership.Email;
            this._lowered_email = aspnet_membership.LoweredEmail;
            this._password_question = aspnet_membership.PasswordQuestion;
            this._password_answer = aspnet_membership.PasswordAnswer;
            this._is_approved = aspnet_membership.IsApproved;
            this._is_locked_out = aspnet_membership.IsLockedOut;
            this._create_date = aspnet_membership.CreateDate;
            this._last_login_date = aspnet_membership.LastLoginDate;
            this._last_password_changed_date = aspnet_membership.LastPasswordChangedDate;
            this._last_lockout_date = aspnet_membership.LastLockoutDate;
            this._failed_password_attempt_count = aspnet_membership.FailedPasswordAttemptCount;
            this._failed_password_attempt_window_start = aspnet_membership.FailedPasswordAttemptWindowStart;
            this._failed_password_answer_attempt_count = aspnet_membership.FailedPasswordAnswerAttemptCount;
            this._failed_password_answer_attempt_window_start = aspnet_membership.FailedPasswordAnswerAttemptWindowStart;
            this._comment = aspnet_membership.Comment;
            this._originalaspnet_Membership = aspnet_membership.DeepClone();
        }

        #endregion


        #region Entity Properties

        
        public event EventHandler PropertyChanged;
        private aspnet_Membership _aspnet___membership;
        private aspnet_Membership _originalaspnet_Membership;
        
        public aspnet_Membership Mapaspnet_Membership()
        {
            this._aspnet___membership.ApplicationId = this._application_id;
            this._aspnet___membership.UserId = this._user_id;
            this._aspnet___membership.Password = this._password;
            this._aspnet___membership.PasswordFormat = this._password_format;
            this._aspnet___membership.PasswordSalt = this._password_salt;
            this._aspnet___membership.MobilePIN = this._mobile_pin;
            this._aspnet___membership.Email = this._email;
            this._aspnet___membership.LoweredEmail = this._lowered_email;
            this._aspnet___membership.PasswordQuestion = this._password_question;
            this._aspnet___membership.PasswordAnswer = this._password_answer;
            this._aspnet___membership.IsApproved = this._is_approved;
            this._aspnet___membership.IsLockedOut = this._is_locked_out;
            this._aspnet___membership.CreateDate = this._create_date;
            this._aspnet___membership.LastLoginDate = this._last_login_date;
            this._aspnet___membership.LastPasswordChangedDate = this._last_password_changed_date;
            this._aspnet___membership.LastLockoutDate = this._last_lockout_date;
            this._aspnet___membership.FailedPasswordAttemptCount = this._failed_password_attempt_count;
            this._aspnet___membership.FailedPasswordAttemptWindowStart = this._failed_password_attempt_window_start;
            this._aspnet___membership.FailedPasswordAnswerAttemptCount = this._failed_password_answer_attempt_count;
            this._aspnet___membership.FailedPasswordAnswerAttemptWindowStart = this._failed_password_answer_attempt_window_start;
            this._aspnet___membership.Comment = this._comment;
        	return _aspnet___membership;
        }
        
        public void Undo()
        {
            if(this._originalaspnet_Membership == null) return;
            this._application_id = this._originalaspnet_Membership.ApplicationId;
            this._user_id = this._originalaspnet_Membership.UserId;
            this._password = this._originalaspnet_Membership.Password;
            this._password_format = this._originalaspnet_Membership.PasswordFormat;
            this._password_salt = this._originalaspnet_Membership.PasswordSalt;
            this._mobile_pin = this._originalaspnet_Membership.MobilePIN;
            this._email = this._originalaspnet_Membership.Email;
            this._lowered_email = this._originalaspnet_Membership.LoweredEmail;
            this._password_question = this._originalaspnet_Membership.PasswordQuestion;
            this._password_answer = this._originalaspnet_Membership.PasswordAnswer;
            this._is_approved = this._originalaspnet_Membership.IsApproved;
            this._is_locked_out = this._originalaspnet_Membership.IsLockedOut;
            this._create_date = this._originalaspnet_Membership.CreateDate;
            this._last_login_date = this._originalaspnet_Membership.LastLoginDate;
            this._last_password_changed_date = this._originalaspnet_Membership.LastPasswordChangedDate;
            this._last_lockout_date = this._originalaspnet_Membership.LastLockoutDate;
            this._failed_password_attempt_count = this._originalaspnet_Membership.FailedPasswordAttemptCount;
            this._failed_password_attempt_window_start = this._originalaspnet_Membership.FailedPasswordAttemptWindowStart;
            this._failed_password_answer_attempt_count = this._originalaspnet_Membership.FailedPasswordAnswerAttemptCount;
            this._failed_password_answer_attempt_window_start = this._originalaspnet_Membership.FailedPasswordAnswerAttemptWindowStart;
            this._comment = this._originalaspnet_Membership.Comment;
        	this.Commit();
        }
        
        public void Reload()
        {
        	if(this._originalaspnet_Membership == null) return;
            this._aspnet___membership.ApplicationId = this._originalaspnet_Membership.ApplicationId;
            this._aspnet___membership.UserId = this._originalaspnet_Membership.UserId;
            this._aspnet___membership.Password = this._originalaspnet_Membership.Password;
            this._aspnet___membership.PasswordFormat = this._originalaspnet_Membership.PasswordFormat;
            this._aspnet___membership.PasswordSalt = this._originalaspnet_Membership.PasswordSalt;
            this._aspnet___membership.MobilePIN = this._originalaspnet_Membership.MobilePIN;
            this._aspnet___membership.Email = this._originalaspnet_Membership.Email;
            this._aspnet___membership.LoweredEmail = this._originalaspnet_Membership.LoweredEmail;
            this._aspnet___membership.PasswordQuestion = this._originalaspnet_Membership.PasswordQuestion;
            this._aspnet___membership.PasswordAnswer = this._originalaspnet_Membership.PasswordAnswer;
            this._aspnet___membership.IsApproved = this._originalaspnet_Membership.IsApproved;
            this._aspnet___membership.IsLockedOut = this._originalaspnet_Membership.IsLockedOut;
            this._aspnet___membership.CreateDate = this._originalaspnet_Membership.CreateDate;
            this._aspnet___membership.LastLoginDate = this._originalaspnet_Membership.LastLoginDate;
            this._aspnet___membership.LastPasswordChangedDate = this._originalaspnet_Membership.LastPasswordChangedDate;
            this._aspnet___membership.LastLockoutDate = this._originalaspnet_Membership.LastLockoutDate;
            this._aspnet___membership.FailedPasswordAttemptCount = this._originalaspnet_Membership.FailedPasswordAttemptCount;
            this._aspnet___membership.FailedPasswordAttemptWindowStart = this._originalaspnet_Membership.FailedPasswordAttemptWindowStart;
            this._aspnet___membership.FailedPasswordAnswerAttemptCount = this._originalaspnet_Membership.FailedPasswordAnswerAttemptCount;
            this._aspnet___membership.FailedPasswordAnswerAttemptWindowStart = this._originalaspnet_Membership.FailedPasswordAnswerAttemptWindowStart;
            this._aspnet___membership.Comment = this._originalaspnet_Membership.Comment;
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
        
        private System.Guid _user_id;
        public System.Guid UserId
        {
            get { return this._user_id; }
            set
            {
                if (this._user_id != value)
                {
                    this.IsDirty = true;
                    this._user_id = value;
                }
            }
        }
        
        private string _password;
        public string Password
        {
            get { return this._password; }
            set
            {
                if (this._password != value)
                {
                    this.IsDirty = true;
                    this._password = value;
                }
            }
        }
        
        private int _password_format;
        public int PasswordFormat
        {
            get { return this._password_format; }
            set
            {
                if (this._password_format != value)
                {
                    this.IsDirty = true;
                    this._password_format = value;
                }
            }
        }
        
        private string _password_salt;
        public string PasswordSalt
        {
            get { return this._password_salt; }
            set
            {
                if (this._password_salt != value)
                {
                    this.IsDirty = true;
                    this._password_salt = value;
                }
            }
        }
        
        private string _mobile_pin;
        public string MobilePIN
        {
            get { return this._mobile_pin; }
            set
            {
                if (this._mobile_pin != value)
                {
                    this.IsDirty = true;
                    this._mobile_pin = value;
                }
            }
        }
        
        private string _email;
        public string Email
        {
            get { return this._email; }
            set
            {
                if (this._email != value)
                {
                    this.IsDirty = true;
                    this._email = value;
                }
            }
        }
        
        private string _lowered_email;
        public string LoweredEmail
        {
            get { return this._lowered_email; }
            set
            {
                if (this._lowered_email != value)
                {
                    this.IsDirty = true;
                    this._lowered_email = value;
                }
            }
        }
        
        private string _password_question;
        public string PasswordQuestion
        {
            get { return this._password_question; }
            set
            {
                if (this._password_question != value)
                {
                    this.IsDirty = true;
                    this._password_question = value;
                }
            }
        }
        
        private string _password_answer;
        public string PasswordAnswer
        {
            get { return this._password_answer; }
            set
            {
                if (this._password_answer != value)
                {
                    this.IsDirty = true;
                    this._password_answer = value;
                }
            }
        }
        
        private bool _is_approved;
        public bool IsApproved
        {
            get { return this._is_approved; }
            set
            {
                if (this._is_approved != value)
                {
                    this.IsDirty = true;
                    this._is_approved = value;
                }
            }
        }
        
        private bool _is_locked_out;
        public bool IsLockedOut
        {
            get { return this._is_locked_out; }
            set
            {
                if (this._is_locked_out != value)
                {
                    this.IsDirty = true;
                    this._is_locked_out = value;
                }
            }
        }
        
        private System.DateTime _create_date;
        public System.DateTime CreateDate
        {
            get { return this._create_date; }
            set
            {
                if (this._create_date != value)
                {
                    this.IsDirty = true;
                    this._create_date = value;
                }
            }
        }
        
        private System.DateTime _last_login_date;
        public System.DateTime LastLoginDate
        {
            get { return this._last_login_date; }
            set
            {
                if (this._last_login_date != value)
                {
                    this.IsDirty = true;
                    this._last_login_date = value;
                }
            }
        }
        
        private System.DateTime _last_password_changed_date;
        public System.DateTime LastPasswordChangedDate
        {
            get { return this._last_password_changed_date; }
            set
            {
                if (this._last_password_changed_date != value)
                {
                    this.IsDirty = true;
                    this._last_password_changed_date = value;
                }
            }
        }
        
        private System.DateTime _last_lockout_date;
        public System.DateTime LastLockoutDate
        {
            get { return this._last_lockout_date; }
            set
            {
                if (this._last_lockout_date != value)
                {
                    this.IsDirty = true;
                    this._last_lockout_date = value;
                }
            }
        }
        
        private int _failed_password_attempt_count;
        public int FailedPasswordAttemptCount
        {
            get { return this._failed_password_attempt_count; }
            set
            {
                if (this._failed_password_attempt_count != value)
                {
                    this.IsDirty = true;
                    this._failed_password_attempt_count = value;
                }
            }
        }
        
        private System.DateTime _failed_password_attempt_window_start;
        public System.DateTime FailedPasswordAttemptWindowStart
        {
            get { return this._failed_password_attempt_window_start; }
            set
            {
                if (this._failed_password_attempt_window_start != value)
                {
                    this.IsDirty = true;
                    this._failed_password_attempt_window_start = value;
                }
            }
        }
        
        private int _failed_password_answer_attempt_count;
        public int FailedPasswordAnswerAttemptCount
        {
            get { return this._failed_password_answer_attempt_count; }
            set
            {
                if (this._failed_password_answer_attempt_count != value)
                {
                    this.IsDirty = true;
                    this._failed_password_answer_attempt_count = value;
                }
            }
        }
        
        private System.DateTime _failed_password_answer_attempt_window_start;
        public System.DateTime FailedPasswordAnswerAttemptWindowStart
        {
            get { return this._failed_password_answer_attempt_window_start; }
            set
            {
                if (this._failed_password_answer_attempt_window_start != value)
                {
                    this.IsDirty = true;
                    this._failed_password_answer_attempt_window_start = value;
                }
            }
        }
        
        private string _comment;
        public string Comment
        {
            get { return this._comment; }
            set
            {
                if (this._comment != value)
                {
                    this.IsDirty = true;
                    this._comment = value;
                }
            }
        }

        #endregion


        #region all the custom code


        #endregion

    }
}
