﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Persona
{
	public virtual string Nombre
	{
		get;
		set;
	}

	public virtual string Apellidos
	{
		get;
		set;
	}

	public virtual date FechaNacimiento
	{
		get;
		set;
	}

	public virtual Int Telefono
	{
		get;
		set;
	}

	public virtual string Genero
	{
		get;
		set;
	}

	public virtual Int Matricula
	{
		get;
		set;
	}

	public virtual string Email
	{
		get;
		set;
	}

	public virtual string Contrasena
	{
		get;
		set;
	}

	public virtual string Foto
	{
		get;
		set;
	}

	public virtual void Ingresar(object usuario, object contrasena)
	{
		throw new System.NotImplementedException();
	}

	public virtual void Agendar_Cita()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Cancelar_Cita()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Consultar_cita()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Imprimir_Cita()
	{
		throw new System.NotImplementedException();
	}

}
