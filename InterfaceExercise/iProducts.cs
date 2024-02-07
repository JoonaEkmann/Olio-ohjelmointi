using System;
namespace InterfaceExercise
{
	internal interface iProducts
	{
		Product GetProduct(string name);

		double CalculateTotal();
	}
}

