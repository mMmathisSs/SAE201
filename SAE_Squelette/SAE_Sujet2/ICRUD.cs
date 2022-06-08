using System;
using System.Collections.Generic;

namespace SAE_Squelette
{
	public interface ICRUD<T>
	{
		void Create();
		void Read();
		void Update();
		void Delete();
		List<T> FindAll();
		List<T> FindBySelection(string criteres);

	}
}