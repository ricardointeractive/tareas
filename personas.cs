/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 17/09/2013
 * Time: 08:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tarea1
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			variables p=new variables();
			Console.WriteLine ("nombre de la persona");
			p.nombre=Console.ReadLine();
			Console.WriteLine ("nombre " +p.nombre);
			Console.WriteLine ("correo de la persona");
			p.correo=Console.ReadLine();
			Console.WriteLine ("correo " +p.correo);
			Console.WriteLine ("edad de la persona");
			p.edad=int.Parse(Console.ReadLine());
			Console.WriteLine ("edad " +p.edad);
		}
	}
}