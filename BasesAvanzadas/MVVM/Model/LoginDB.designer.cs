﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasesAvanzadas.MVVM.Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LearnHub")]
	public partial class LoginDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertestudiante(estudiante instance);
    partial void Updateestudiante(estudiante instance);
    partial void Deleteestudiante(estudiante instance);
    partial void Insertprofesor(profesor instance);
    partial void Updateprofesor(profesor instance);
    partial void Deleteprofesor(profesor instance);
    #endregion
		
		public LoginDBDataContext() : 
				base(global::BasesAvanzadas.Properties.Settings.Default.LearnHubConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<estudiante> estudiantes
		{
			get
			{
				return this.GetTable<estudiante>();
			}
		}
		
		public System.Data.Linq.Table<profesor> profesors
		{
			get
			{
				return this.GetTable<profesor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.estudiantes")]
	public partial class estudiante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_estudiante;
		
		private string _Nombre_s_;
		
		private string _Apellido_s_;
		
		private string _Correo;
		
		private string _Contraseña;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_estudianteChanging(int value);
    partial void Onid_estudianteChanged();
    partial void OnNombre_s_Changing(string value);
    partial void OnNombre_s_Changed();
    partial void OnApellido_s_Changing(string value);
    partial void OnApellido_s_Changed();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    #endregion
		
		public estudiante()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estudiante", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_estudiante
		{
			get
			{
				return this._id_estudiante;
			}
			set
			{
				if ((this._id_estudiante != value))
				{
					this.Onid_estudianteChanging(value);
					this.SendPropertyChanging();
					this._id_estudiante = value;
					this.SendPropertyChanged("id_estudiante");
					this.Onid_estudianteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Nombre(s)]", Storage="_Nombre_s_", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre_s_
		{
			get
			{
				return this._Nombre_s_;
			}
			set
			{
				if ((this._Nombre_s_ != value))
				{
					this.OnNombre_s_Changing(value);
					this.SendPropertyChanging();
					this._Nombre_s_ = value;
					this.SendPropertyChanged("Nombre_s_");
					this.OnNombre_s_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Apellido(s)]", Storage="_Apellido_s_", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido_s_
		{
			get
			{
				return this._Apellido_s_;
			}
			set
			{
				if ((this._Apellido_s_ != value))
				{
					this.OnApellido_s_Changing(value);
					this.SendPropertyChanging();
					this._Apellido_s_ = value;
					this.SendPropertyChanged("Apellido_s_");
					this.OnApellido_s_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.profesor")]
	public partial class profesor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_profesor;
		
		private string _Nombre_s_;
		
		private string _Apellido_s_;
		
		private int _cursos_id_curso;
		
		private string _Correo;
		
		private string _Contraseña;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_profesorChanging(int value);
    partial void Onid_profesorChanged();
    partial void OnNombre_s_Changing(string value);
    partial void OnNombre_s_Changed();
    partial void OnApellido_s_Changing(string value);
    partial void OnApellido_s_Changed();
    partial void Oncursos_id_cursoChanging(int value);
    partial void Oncursos_id_cursoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    #endregion
		
		public profesor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_profesor", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_profesor
		{
			get
			{
				return this._id_profesor;
			}
			set
			{
				if ((this._id_profesor != value))
				{
					this.Onid_profesorChanging(value);
					this.SendPropertyChanging();
					this._id_profesor = value;
					this.SendPropertyChanged("id_profesor");
					this.Onid_profesorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Nombre(s)]", Storage="_Nombre_s_", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre_s_
		{
			get
			{
				return this._Nombre_s_;
			}
			set
			{
				if ((this._Nombre_s_ != value))
				{
					this.OnNombre_s_Changing(value);
					this.SendPropertyChanging();
					this._Nombre_s_ = value;
					this.SendPropertyChanged("Nombre_s_");
					this.OnNombre_s_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Apellido(s)]", Storage="_Apellido_s_", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido_s_
		{
			get
			{
				return this._Apellido_s_;
			}
			set
			{
				if ((this._Apellido_s_ != value))
				{
					this.OnApellido_s_Changing(value);
					this.SendPropertyChanging();
					this._Apellido_s_ = value;
					this.SendPropertyChanged("Apellido_s_");
					this.OnApellido_s_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cursos_id_curso", DbType="Int NOT NULL")]
		public int cursos_id_curso
		{
			get
			{
				return this._cursos_id_curso;
			}
			set
			{
				if ((this._cursos_id_curso != value))
				{
					this.Oncursos_id_cursoChanging(value);
					this.SendPropertyChanging();
					this._cursos_id_curso = value;
					this.SendPropertyChanged("cursos_id_curso");
					this.Oncursos_id_cursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
