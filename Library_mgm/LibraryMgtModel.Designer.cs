//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Library_mgm
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibraryMgtEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibraryMgtEntities object using the connection string found in the 'LibraryMgtEntities' section of the application configuration file.
        /// </summary>
        public LibraryMgtEntities() : base("name=LibraryMgtEntities", "LibraryMgtEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryMgtEntities object.
        /// </summary>
        public LibraryMgtEntities(string connectionString) : base(connectionString, "LibraryMgtEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryMgtEntities object.
        /// </summary>
        public LibraryMgtEntities(EntityConnection connection) : base(connection, "LibraryMgtEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<user> users
        {
            get
            {
                if ((_users == null))
                {
                    _users = base.CreateObjectSet<user>("users");
                }
                return _users;
            }
        }
        private ObjectSet<user> _users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTousers(user user)
        {
            base.AddObject("users", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryMgtModel", Name="user")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class user : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new user object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="id">Initial value of the id property.</param>
        public static user Createuser(global::System.String name, global::System.String id)
        {
            user user = new user();
            user.name = name;
            user.id = id;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.String _id;
        partial void OnidChanging(global::System.String value);
        partial void OnidChanged();

        #endregion

    
    }

    #endregion

    
}
