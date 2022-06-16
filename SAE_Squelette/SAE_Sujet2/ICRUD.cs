using System;
using System.Collections.Generic;

namespace SAE_Sujet2
{
	/// <summary>
	/// Permet d'impl�menter le CRUD dans les diff�rentes classes
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICRUD<T>
	{
		/// <summary>
		/// M�thode pour ajouter un  �l�ment
		/// </summary>
		void Create();

		/// <summary>
		/// M�thode pour lire un �l�ment
		/// </summary>
		void Read();

		/// <summary>
		/// M�thode pour mettre � jour un �l�ment
		/// </summary>
		void Update();

		/// <summary>
		/// M�thode pour supprimer un �l�ment
		/// </summary>
		void Delete();

		/// <summary>
		/// M�thode pour extraire les �l�ments de la BD
		/// </summary>
		/// <returns></returns>
		List<T> FindAll();

		/// <summary>
		/// M�thode pour extraire les �l�ments de la BD avec un filtre
		/// </summary>
		/// <param name="criteres"></param>
		/// <returns></returns>
		List<T> FindBySelection(string criteres);

	}
}