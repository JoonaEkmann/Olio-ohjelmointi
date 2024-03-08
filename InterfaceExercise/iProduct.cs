using System;
namespace InterfaceExercise
{
	internal interface iProduct
	{
		Product GetProduct(string name);
		double CalculateTotal();
	}
}

