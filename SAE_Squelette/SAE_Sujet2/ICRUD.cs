using System;
using System.Collections.Generic;

namespace SAE_Sujet2
{
	/// <summary>
	/// Permet d'implémenter le CRUD dans les différentes classes
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICRUD<T>
	{
		/// <summary>
		/// Méthode pour ajouter un  élément
		/// </summary>
		void Create();

		/// <summary>
		/// Méthode pour lire un élément
		/// </summary>
		void Read();

		/// <summary>
		/// Méthode pour mettre à jour un élément
		/// </summary>
		void Update();

		/// <summary>
		/// Méthode pour supprimer un élément
		/// </summary>
		void Delete();

		/// <summary>
		/// Méthode pour extraire les éléments de la BD
		/// </summary>
		/// <returns></returns>
		List<T> FindAll();

		/// <summary>
		/// Méthode pour extraire les éléments de la BD avec un filtre
		/// </summary>
		/// <param name="criteres"></param>
		/// <returns></returns>
		List<T> FindBySelection(string criteres);

	}
}